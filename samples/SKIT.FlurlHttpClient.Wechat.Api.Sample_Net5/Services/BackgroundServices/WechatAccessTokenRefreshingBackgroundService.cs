using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SKIT.FlurlHttpClient.Wechat.Api;
using SKIT.FlurlHttpClient.Wechat.Api.Models;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample_Net5.Services.BackgroundServices
{
    class WechatAccessTokenRefreshingBackgroundService : BackgroundService
    {
        private readonly ILogger _logger;
        private readonly Options.WechatOptions _wechatOptions;
        private readonly DistributedLock.IDistributedLockFactory _distributedLockFactory;
        private readonly HttpClients.IWechatApiHttpClientFactory _wechatApiHttpClientFactory;
        private readonly Repositories.IWechatAccessTokenEntityRepository _wechatAccessTokenEntityRepository;

        public WechatAccessTokenRefreshingBackgroundService(
            ILoggerFactory loggerFactory,
            IOptions<Options.WechatOptions> wechatOptions,
            DistributedLock.IDistributedLockFactory distributedLockFactory,
            HttpClients.IWechatApiHttpClientFactory wechatApiHttpClientFactory,
            Repositories.IWechatAccessTokenEntityRepository wechatAccessTokenEntityRepository)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _wechatOptions = wechatOptions.Value;
            _distributedLockFactory = distributedLockFactory;
            _wechatApiHttpClientFactory = wechatApiHttpClientFactory;
            _wechatAccessTokenEntityRepository = wechatAccessTokenEntityRepository;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                IList<Task> tasks = new List<Task>();
                foreach (var wechatAccount in _wechatOptions.Accounts)
                {
                    Task task = TryRefreshWechatAccessTokenAsync(wechatAccount.AppId, stoppingToken);
                    tasks.Add(task);
                }

                await Task.WhenAll(tasks);
                await Task.Delay(1 * 60 * 1000); // 每隔 1 分钟轮询刷新
            }
        }

        private async Task TryRefreshWechatAccessTokenAsync(string appId, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(appId))
                return; // 无效参数

            var entity = _wechatAccessTokenEntityRepository.FirstOrDefault(e => e.AppId == appId);
            if (entity?.ExpireTimestamp > DateTimeOffset.Now.ToUnixTimeSeconds())
                return; // AccessToken 未过期

            var locker = _distributedLockFactory.Create("accessToken:" + appId);
            using var lockHandler = await locker.TryAcquireAsync(TimeSpan.FromSeconds(15), cancellationToken);
            if (lockHandler == null)
                return; // 未取得锁

            var client = _wechatApiHttpClientFactory.Create(appId);
            var request = new CgibinTokenRequest();
            var response = await client.ExecuteCgibinTokenAsync(request, cancellationToken);
            if (!response.IsSuccessful())
            {
                _logger.LogWarning(
                    "刷新 AppId 为 {0} 微信 AccessToken 失败（状态码：{1}，错误代码：{2}，错误描述：{3}）。", 
                    appId, response.RawStatus, response.ErrorCode, response.ErrorMessage
                );
                return; // 请求失败
            }

            long nextExpireTimestamp = DateTimeOffset.Now
                .AddSeconds(response.ExpiresIn)
                .AddMinutes(-10)
                .ToUnixTimeSeconds(); // 提前十分钟过期，以便于系统能及时刷新，防止因在过期临界点时出现问题
            if (entity == null)
            {
                entity = new Models.WechatAccessTokenEntity()
                {
                    AppId = appId,
                    AccessToken = response.AccessToken,
                    ExpireTimestamp = nextExpireTimestamp
                };
                _wechatAccessTokenEntityRepository.Insert(entity);
            }
            else
            {
                entity.AccessToken = response.AccessToken;
                entity.ExpireTimestamp = nextExpireTimestamp;
                _wechatAccessTokenEntityRepository.Update(entity);
            }

            _logger.LogInformation("刷新 AppId 为 {0} 的微信 AccessToken 成功。", appId);
        }
    }
}
