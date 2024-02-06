using System;
using System.Linq;
using System.Net.Http;
using Microsoft.Extensions.Options;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Services.HttpClients.Implements
{
    internal partial class WechatTenpayClientFactory : IWechatTenpayClientFactory
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly Options.TenpayOptions _tenpayOptions;
        private readonly IWechatTenpayCertificateManagerFactory _tenpayCertificateManagerFactory;

        public WechatTenpayClientFactory(
            IHttpClientFactory httpClientFactory,
            IOptions<Options.TenpayOptions> tenpayOptions,
            IWechatTenpayCertificateManagerFactory tenpayCertificateManagerFactory)
        {
            _httpClientFactory = httpClientFactory;
            _tenpayOptions = tenpayOptions.Value;
            _tenpayCertificateManagerFactory = tenpayCertificateManagerFactory;
        }

        public WechatTenpayClient Create(string merchantId)
        {
            // NOTICE:
            //   这里的工厂方法是为了演示多租户而存在的，可根据商户号生成不同的 API 客户端。
            //   如果你的项目只存在唯一一个租户，那么直接注入 `WechatTenpayClient` 即可。

            var tenpayMerchantConfig = _tenpayOptions.Merchants?.FirstOrDefault(e => string.Equals(merchantId, e.MerchantId));
            if (tenpayMerchantConfig == null)
                throw new Exception("未在配置项中找到该 MerchantId 对应的微信商户号。");

            var wechatTenpayClientOptions = new WechatTenpayClientOptions()
            {
                MerchantId = tenpayMerchantConfig.MerchantId,
                MerchantV3Secret = tenpayMerchantConfig.SecretV3,
                MerchantCertificateSerialNumber = tenpayMerchantConfig.CertificateSerialNumber,
                MerchantCertificatePrivateKey = tenpayMerchantConfig.CertificatePrivateKey,
                PlatformCertificateManager = _tenpayCertificateManagerFactory.Create(tenpayMerchantConfig.MerchantId),
                AutoEncryptRequestSensitiveProperty = false,
                AutoDecryptResponseSensitiveProperty = false
            };
            var wechatTenpayClient = WechatTenpayClientBuilder.Create(wechatTenpayClientOptions)
                .UseHttpClient(_httpClientFactory.CreateClient(), disposeClient: false)
                .Build();
            return wechatTenpayClient;
        }
    }
}
