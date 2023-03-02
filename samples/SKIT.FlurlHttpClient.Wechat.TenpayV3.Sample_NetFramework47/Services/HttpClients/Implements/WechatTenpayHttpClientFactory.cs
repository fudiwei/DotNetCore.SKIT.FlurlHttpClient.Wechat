namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Services.HttpClients.Implements
{
    internal partial class WechatTenpayHttpClientFactory : IWechatTenpayHttpClientFactory
    {
        private readonly IWechatTenpayCertificateManagerFactory _tenpayCertificateManagerFactory;

        public WechatTenpayHttpClientFactory(
            IWechatTenpayCertificateManagerFactory tenpayCertificateManagerFactory)
        {
            _tenpayCertificateManagerFactory = tenpayCertificateManagerFactory;
        }

        public WechatTenpayClient Create(string merchantId)
        {
            // NOTICE:
            //   这里的工厂方法是为了演示多租户而存在的，可根据商户号生成不同的 API 客户端。
            //   如果你的项目只存在唯一一个租户，那么直接注入 `WechatTenpayClient` 即可。

            var tenpayMerchantOptions = Options.TenpayOptions.Instance.Value.Merchants?.FirstOrDefault(e => string.Equals(merchantId, e.MerchantId));
            if (tenpayMerchantOptions == null)
                throw new Exception("未在配置项中找到该 MerchantId 对应的微信商户号。");

            return new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = tenpayMerchantOptions.MerchantId,
                MerchantV3Secret = tenpayMerchantOptions.SecretV3,
                MerchantCertSerialNumber = tenpayMerchantOptions.CertSerialNumber,
                MerchantCertPrivateKey = tenpayMerchantOptions.CertPrivateKey,
                CertificateManager = _tenpayCertificateManagerFactory.Create(tenpayMerchantOptions.MerchantId),
                AutoEncryptRequestSensitiveProperty = false,
                AutoDecryptResponseSensitiveProperty = false
            });
        }
    }
}
