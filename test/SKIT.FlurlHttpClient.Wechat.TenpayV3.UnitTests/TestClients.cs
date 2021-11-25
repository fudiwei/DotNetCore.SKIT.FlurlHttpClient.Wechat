using System;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    class TestClients
    {
        static TestClients()
        {
            GlobalCertificateManager = new Settings.InMemoryCertificateManager();
            Instance = new WechatTenpayClient(new WechatTenpayClientOptions()
            { 
                MerchantId = TestConfigs.WechatMerchantId,
                MerchantV3Secret = TestConfigs.WechatMerchantSecret,
                MerchantCertSerialNumber = TestConfigs.WechatMerchantCertSerialNumber,
                MerchantCertPrivateKey = TestConfigs.WechatMerchantCertPrivateKey,
                CertificateManager = GlobalCertificateManager
            });
        }

        internal static async Task InitializeCertificateManagerAsync()
        {
            var request = new Models.QueryCertificatesRequest();
            var response = await Instance.ExecuteQueryCertificatesAsync(request);

            response = Instance.DecryptResponseSensitiveProperty(response);
            foreach (var certificateModel in response.CertificateList)
            {
                GlobalCertificateManager.AddEntry(new Settings.CertificateEntry(certificateModel));
            }
        }

        public static readonly Settings.CertificateManager GlobalCertificateManager;

        public static readonly WechatTenpayClient Instance;
    }
}
