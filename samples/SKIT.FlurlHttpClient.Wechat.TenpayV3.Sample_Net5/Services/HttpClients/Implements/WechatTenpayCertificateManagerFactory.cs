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
            return _dict.GetOrAdd(merchantId, new InMemoryCertificateManager());
        }
    }
}
