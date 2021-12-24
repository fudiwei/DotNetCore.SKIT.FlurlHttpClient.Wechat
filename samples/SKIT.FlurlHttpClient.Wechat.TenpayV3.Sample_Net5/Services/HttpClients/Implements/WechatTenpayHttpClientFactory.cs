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
            var merchantOptions = _tenpayOptions.Merchants?.FirstOrDefault(e => string.Equals(merchantId, e.MerchantId));
            if (merchantOptions == null)
                throw new Exception("未在配置项中找到该 MerchantId 对应的微信商户号。");

            return new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = merchantOptions.MerchantId,
                MerchantV3Secret = merchantOptions.SecretV3,
                MerchantCertSerialNumber = merchantOptions.CertSerialNumber,
                MerchantCertPrivateKey = merchantOptions.CertPrivateKey,
                CertificateManager = _tenpayCertificateManagerFactory.Create(merchantOptions.MerchantId),
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
