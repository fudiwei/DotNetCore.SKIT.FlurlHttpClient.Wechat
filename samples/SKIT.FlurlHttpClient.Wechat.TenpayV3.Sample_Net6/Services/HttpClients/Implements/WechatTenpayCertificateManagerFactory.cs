using System.Collections.Concurrent;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample_Net5.Services.HttpClients.Implements
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

    partial class WechatTenpayCertificateManagerFactory : IWechatTenpayCertificateManagerFactory
    {
        private readonly ConcurrentDictionary<string, CertificateManager> _dict;

        public WechatTenpayCertificateManagerFactory()
        {
            _dict = new ConcurrentDictionary<string, CertificateManager>();
        }

        public CertificateManager Create(string merchantId)
        {
            // 注意：这里的工厂方法是为了演示多租户而存在的；如果你的项目只存在唯一一个租户，那么直接注入 `CertificateManager` 就可以

            return _dict.GetOrAdd(merchantId, new InMemoryCertificateManager());
        }
    }
}
