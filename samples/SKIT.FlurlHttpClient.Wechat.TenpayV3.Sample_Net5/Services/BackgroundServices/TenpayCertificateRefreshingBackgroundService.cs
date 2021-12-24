using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SKIT.FlurlHttpClient.Wechat.TenpayV3.Models;
using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample_Net5.Services.BackgroundServices
{
    class TenpayCertificateRefreshingBackgroundService : BackgroundService
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
                var wxpayMerchant = _tenpayOptions.Merchants.FirstOrDefault();
                if (wxpayMerchant == null)
                {
                    _logger.LogWarning("未找到微信商户配置项。");
                    break;
                }

                try
                {
                    var client = _tenpayHttpClientFactory.Create(wxpayMerchant.MerchantId);
                    var request = new QueryCertificatesRequest();
                    var response = await client.ExecuteQueryCertificatesAsync(request, cancellationToken: stoppingToken);
                    if (response.IsSuccessful())
                    {
                        // 注意：如果启用了 AutoDecryptResponseSensitiveProperty，则无需再手动执行下面被注释的解密方法
                        // response = client.DecryptResponseSensitiveProperty(response);

                        foreach (var certificateModel in response.CertificateList)
                        {
                            client.CertificateManager.AddEntry(new CertificateEntry(certificateModel));
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

                await Task.Delay(TimeSpan.FromDays(1)); // 每隔 1 天轮询刷新
            }
        }
    }
}
