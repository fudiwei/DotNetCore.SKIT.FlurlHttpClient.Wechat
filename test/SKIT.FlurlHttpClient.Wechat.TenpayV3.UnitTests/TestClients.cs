using System;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            var certificateManager = new Settings.InMemoryCertificateManager();
            Instance = new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = TestConfigs.WechatMerchantId,
                MerchantV3Secret = TestConfigs.WechatMerchantSecret,
                MerchantCertificateSerialNumber = TestConfigs.WechatMerchantCertificateSerialNumber,
                MerchantCertificatePrivateKey = TestConfigs.WechatMerchantCertificatePrivateKey,
                PlatformCertificateManager = certificateManager
            });
        }

        internal static async Task InitializeCertificateManagerAsync()
        {
            var request = new Models.QueryCertificatesRequest();
            var response = await Instance.ExecuteQueryCertificatesAsync(request);

            if (!response.IsSuccessful())
                throw new Exception();

            foreach (var certificate in Instance.DecryptResponseSensitiveProperty(response).CertificateList)
            {
                Instance.PlatformCertificateManager.AddEntry(new Settings.CertificateEntry(certificate));
            }
        }

        public static readonly WechatTenpayClient Instance;
    }
}
