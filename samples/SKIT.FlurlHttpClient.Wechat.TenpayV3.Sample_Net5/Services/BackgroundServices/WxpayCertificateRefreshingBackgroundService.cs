using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SKIT.FlurlHttpClient.Wechat.TenpayV3;
using SKIT.FlurlHttpClient.Wechat.TenpayV3.Models;
using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample_Net5.Services.BackgroundServices
{
    class WxpayCertificateRefreshingBackgroundService : BackgroundService
    {
        private readonly ILogger _logger;
        private readonly Options.WxpayOptions _wxpayOptions;
        private readonly CertificateManager _certificateManager;
        private readonly HttpClients.IWechatTenpayHttpClientFactory _wechatTenpayHttpClientFactory;

        public WxpayCertificateRefreshingBackgroundService(
            ILoggerFactory loggerFactory,
            IOptions<Options.WxpayOptions> wxpayOptions,
            CertificateManager certificateManager,
            HttpClients.IWechatTenpayHttpClientFactory wechatTenpayHttpClientFactory)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _wxpayOptions = wxpayOptions.Value;
            _certificateManager = certificateManager;
            _wechatTenpayHttpClientFactory = wechatTenpayHttpClientFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var wxpayMerchant = _wxpayOptions.Merchants.FirstOrDefault();
                if (wxpayMerchant == null)
                {
                    _logger.LogWarning("未找到微信商户配置项。");
                    break;
                }

                try
                {
                    var client = _wechatTenpayHttpClientFactory.Create(wxpayMerchant.MerchantId);
                    var request = new QueryCertificatesRequest();
                    var response = await client.ExecuteQueryCertificatesAsync(request, cancellationToken: stoppingToken);
                    if (response.IsSuccessful())
                    {
                        client.DecryptResponseEncryptedData(ref response);
                        foreach (var cert in response.CertificateList)
                        {
                            _certificateManager.SetCertificate(cert.SerialNumber, cert.EncryptCertificate.CipherText);
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
