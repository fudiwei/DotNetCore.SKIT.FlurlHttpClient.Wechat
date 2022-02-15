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
        private readonly HttpClients.IWechatTenpayHttpClientFactory _tenpayHttpClientFactory;

        public TenpayCertificateRefreshingBackgroundService(
            ILoggerFactory loggerFactory,
            IOptions<Options.TenpayOptions> tenpayOptions,
            HttpClients.IWechatTenpayHttpClientFactory tenpayHttpClientFactory)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _tenpayOptions = tenpayOptions.Value;
            _tenpayHttpClientFactory = tenpayHttpClientFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                foreach (var tenpayMerchantOptions in _tenpayOptions.Merchants)
                {
                    try
                    {
                        var client = _tenpayHttpClientFactory.Create(tenpayMerchantOptions.MerchantId);
                        var request = new QueryCertificatesRequest();
                        var response = await client.ExecuteQueryCertificatesAsync(request, cancellationToken: stoppingToken);
                        if (response.IsSuccessful())
                        {
                            // NOTICE:
                            //   如果启用了 `AutoDecryptResponseSensitiveProperty` 配置项，则无需再手动执行下面被注释的解密方法：
                            //   response = client.DecryptResponseSensitiveProperty(response);

                            foreach (var certificateModel in response.CertificateList)
                            {
                                client.PlatformCertificateManager.AddEntry(new CertificateEntry(certificateModel));
                            }

                            _logger.LogInformation("刷新微信商户平台证书成功。");
                        }
                        else
                        {
                            _logger.LogWarning(
                                "刷新微信商户平台证书失败（状态码：{0}，错误代码：{1}，错误描述：{2}）。",
                                response.RawStatus, response.ErrorCode, response.ErrorMessage
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
