using System;
using System.Linq;
using System.Net.Http;
using Microsoft.Extensions.Options;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Services.HttpClients.Implements
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

    internal partial class WechatTenpayClientFactory : IWechatTenpayClientFactory
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly Options.TenpayOptions _tenpayOptions;
        private readonly IWechatTenpayCertificateManagerFactory _tenpayCertificateManagerFactory;
        private readonly IWechatTenpayPublicKeyManagerFactory _tenpayPublicKeyManagerFactory;

        public WechatTenpayClientFactory(
            IHttpClientFactory httpClientFactory,
            IOptions<Options.TenpayOptions> tenpayOptions,
            IWechatTenpayCertificateManagerFactory tenpayCertificateManagerFactory,
            IWechatTenpayPublicKeyManagerFactory tenpayPublicKeyManagerFactory)
        {
            _httpClientFactory = httpClientFactory;
            _tenpayOptions = tenpayOptions.Value;
            _tenpayCertificateManagerFactory = tenpayCertificateManagerFactory;
            _tenpayPublicKeyManagerFactory = tenpayPublicKeyManagerFactory;
        }

        public WechatTenpayClient Create(string merchantId)
        {
            // NOTICE:
            //   这里的工厂方法是为了演示多租户而存在的，可根据商户号生成不同的 API 客户端。
            //   如果你的项目只存在唯一一个租户，那么直接注入 `WechatTenpayClient` 即可。

            var tenpayMerchantOptions = _tenpayOptions.Merchants?.FirstOrDefault(e => string.Equals(merchantId, e.MerchantId));
            if (tenpayMerchantOptions == null)
                throw new Exception("未在配置项中找到该 MerchantId 对应的微信商户号。");

            var wechatTenpayClientOptions = new WechatTenpayClientOptions()
            {
                MerchantId = tenpayMerchantOptions.MerchantId,
                MerchantV3Secret = tenpayMerchantOptions.SecretV3,
                MerchantCertificateSerialNumber = tenpayMerchantOptions.CertificateSerialNumber,
                MerchantCertificatePrivateKey = tenpayMerchantOptions.CertificatePrivateKey,
                AutoEncryptRequestSensitiveProperty = false,
                AutoDecryptResponseSensitiveProperty = false,

                // 基于平台证书的认证方式还需设置以下参数：
                PlatformAuthScheme = PlatformAuthScheme.Certificate,
                PlatformCertificateManager = _tenpayCertificateManagerFactory.Create(tenpayMerchantOptions.MerchantId),

                // 基于平台公钥的认证方式还需设置以下参数：
                //PlatformAuthScheme = PlatformAuthScheme.PublicKey,
                //PlatformPublicKeyManager = _tenpayPublicKeyManagerFactory.Create(tenpayMerchantOptions.MerchantId)
            };
            var wechatTenpayClient = WechatTenpayClientBuilder.Create(wechatTenpayClientOptions)
                .UseHttpClient(_httpClientFactory.CreateClient(), disposeClient: false)
                .Build();
            return wechatTenpayClient;
        }
    }
}
