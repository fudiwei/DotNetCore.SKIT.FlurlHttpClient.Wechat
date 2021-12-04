using System;
using System.Linq;
using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Options;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample_Net5.Services.HttpClients.Implements
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

    partial class WechatTenpayHttpClientFactory : IWechatTenpayHttpClientFactory
    {
        private readonly System.Net.Http.IHttpClientFactory _httpClientFactory;
        private readonly Options.TenpayOptions _wechatOptions;
        private readonly CertificateManager _certificateManager;

        public WechatTenpayHttpClientFactory(
            System.Net.Http.IHttpClientFactory httpClientFactory,
            IOptions<Options.TenpayOptions> wechatOptions,
            CertificateManager certificateManager)
        {
            _httpClientFactory = httpClientFactory;
            _wechatOptions = wechatOptions.Value;
            _certificateManager = certificateManager;

            FlurlHttp.GlobalSettings.FlurlClientFactory = new DelegatingFlurlClientFactory(_httpClientFactory);
        }

        public WechatTenpayClient Create(string merchantId)
        {
            var wechatMerchant = _wechatOptions.Merchants?.FirstOrDefault(e => string.Equals(merchantId, e.MerchantId));
            if (wechatMerchant == null)
                throw new Exception("未在配置项中找到该 MerchantId 对应的微信商户号。");

            return new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = wechatMerchant.MerchantId,
                MerchantV3Secret = wechatMerchant.SecretV3,
                MerchantCertSerialNumber = wechatMerchant.CertSerialNumber,
                MerchantCertPrivateKey = wechatMerchant.CertPrivateKey,
                CertificateManager = _certificateManager,
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
