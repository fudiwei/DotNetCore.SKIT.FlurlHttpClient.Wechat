using System.Collections.Concurrent;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Services.HttpClients.Implements
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

    internal partial class WechatTenpayCertificateManagerFactory : IWechatTenpayCertificateManagerFactory
    {
        private readonly ConcurrentDictionary<string, ICertificateManager> _dict;

        public WechatTenpayCertificateManagerFactory()
        {
            _dict = new ConcurrentDictionary<string, ICertificateManager>();
        }

        public ICertificateManager Create(string merchantId)
        {
            // NOTICE:
            //   这里的工厂方法是为了演示多租户而存在的，可根据商户号生成不同的证书管理器。
            //   如果你的项目只存在唯一一个租户，那么直接注入 `CertificateManager` 即可。

            return _dict.GetOrAdd(merchantId, new InMemoryCertificateManager());
        }
    }
}
