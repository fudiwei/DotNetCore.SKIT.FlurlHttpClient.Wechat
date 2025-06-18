using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Services.BackgroundServices
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Models;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

    internal class TenpayCertificateRefreshingBackgroundService : BackgroundService
    {
        private readonly ILogger _logger;
        private readonly Options.TenpayOptions _tenpayOptions;
        private readonly HttpClients.IWechatTenpayClientFactory _wechatTenpayClientFactory;

        public TenpayCertificateRefreshingBackgroundService(
            ILoggerFactory loggerFactory,
            IOptions<Options.TenpayOptions> tenpayOptions,
            HttpClients.IWechatTenpayClientFactory wechatTenpayClientFactory)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _tenpayOptions = tenpayOptions.Value;
            _wechatTenpayClientFactory = wechatTenpayClientFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // NOTICE:
            //   2024-10-01 后微信支付新增了基于微信支付公钥的验证身份方式，
            //   如果你已切换至使用平台公钥，则不再需要下载平台证书，可删除此定时任务。

            while (!stoppingToken.IsCancellationRequested)
            {
                foreach (var tenpayMerchantOptions in _tenpayOptions.Merchants)
                {
                    try
                    {
                        const string ALGORITHM_TYPE = "RSA";
                        var client = _wechatTenpayClientFactory.Create(tenpayMerchantOptions.MerchantId);
                        var request = new QueryCertificatesRequest() { AlgorithmType = ALGORITHM_TYPE };
                        var response = await client.ExecuteQueryCertificatesAsync(request, cancellationToken: stoppingToken);
                        if (response.IsSuccessful())
                        {
                            // NOTICE:
                            //   如果构造 Client 时启用了 `AutoDecryptResponseSensitiveProperty` 配置项，则无需再执行下面一行的手动解密方法：
                            response = client.DecryptResponseSensitiveProperty(response);

                            foreach (var certificate in response.CertificateList)
                            {
                                client.PlatformCertificateManager.AddEntry(CertificateEntry.Parse(ALGORITHM_TYPE, certificate));
                            }

                            _logger.LogInformation("刷新微信商户平台证书成功。");
                        }
                        else
                        {
                            _logger.LogWarning(
                                "刷新微信商户平台证书失败（状态码：{0}，错误代码：{1}，错误描述：{2}）。",
                                response.GetRawStatus(), response.ErrorCode, response.ErrorMessage
                            );
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "刷新微信商户平台证书遇到异常。");
                    }
                }

                await Task.Delay(TimeSpan.FromDays(1)); // 每隔 1 天轮询刷新
            }
        }
    }
}
