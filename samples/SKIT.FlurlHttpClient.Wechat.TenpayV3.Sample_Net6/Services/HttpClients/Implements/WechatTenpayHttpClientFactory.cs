using System;
using System.Linq;
using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Options;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Services.HttpClients.Implements
{
    partial class WechatTenpayHttpClientFactory : IWechatTenpayHttpClientFactory
    {
        private readonly System.Net.Http.IHttpClientFactory _httpClientFactory;
        private readonly Options.TenpayOptions _tenpayOptions;
        private readonly IWechatTenpayCertificateManagerFactory _tenpayCertificateManagerFactory;

        public WechatTenpayHttpClientFactory(
            System.Net.Http.IHttpClientFactory httpClientFactory,
            IOptions<Options.TenpayOptions> tenpayOptions,
            IWechatTenpayCertificateManagerFactory tenpayCertificateManagerFactory)
        {
            _httpClientFactory = httpClientFactory;
            _tenpayOptions = tenpayOptions.Value;
            _tenpayCertificateManagerFactory = tenpayCertificateManagerFactory;

            FlurlHttp.GlobalSettings.FlurlClientFactory = new DelegatingFlurlClientFactory(_httpClientFactory);
        }

        public WechatTenpayClient Create(string merchantId)
        {
            // NOTICE:
            //   这里的工厂方法是为了演示多租户而存在的，可根据商户号生成不同的 API 客户端。
            //   如果你的项目只存在唯一一个租户，那么直接注入 `WechatTenpayClient` 即可。

            var tenpayMerchantOptions = _tenpayOptions.Merchants?.FirstOrDefault(e => string.Equals(merchantId, e.MerchantId));
            if (tenpayMerchantOptions == null)
                throw new Exception("未在配置项中找到该 MerchantId 对应的微信商户号。");

            return new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = tenpayMerchantOptions.MerchantId,
                MerchantV3Secret = tenpayMerchantOptions.SecretV3,
                MerchantCertSerialNumber = tenpayMerchantOptions.CertSerialNumber,
                MerchantCertPrivateKey = tenpayMerchantOptions.CertPrivateKey,
                CertificateManager = _tenpayCertificateManagerFactory.Create(tenpayMerchantOptions.MerchantId),
                AutoEncryptRequestSensitiveProperty = true,
                AutoDecryptResponseSensitiveProperty = true
            });
        }
    }

    partial class WechatTenpayHttpClientFactory
    {
        internal class DelegatingFlurlClientFactory : IFlurlClientFactory
        {
            private readonly System.Net.Http.IHttpClientFactory _httpClientFactory;

            public DelegatingFlurlClientFactory(System.Net.Http.IHttpClientFactory httpClientFactory)
            {
                _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
            }

            public IFlurlClient Get(Url url)
            {
                return new FlurlClient(_httpClientFactory.CreateClient(url.ToUri().Host));
            }

            public void Dispose()
            {
                // Do Nothing
            }
        }
    }
}
