using System;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            var manager = new Settings.InMemoryCertificateManager();
            InstanceUseRSA = new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = TestConfigs.WechatMerchantId,
                MerchantV3Secret = TestConfigs.WechatMerchantSecret,
                MerchantCertificateSerialNumber = TestConfigs.WechatMerchantRSACertificateSerialNumber,
                MerchantCertificatePrivateKey = TestConfigs.WechatMerchantRSACertificatePrivateKey,
                PlatformCertificateManager = manager
            });
            InstanceUseSM2 = new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = TestConfigs.WechatMerchantId,
                MerchantV3Secret = TestConfigs.WechatMerchantSecret,
                SignScheme = Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3,
                MerchantCertificateSerialNumber = TestConfigs.WechatMerchantSM2CertificateSerialNumber!,
                MerchantCertificatePrivateKey = TestConfigs.WechatMerchantSM2CertificatePrivateKey!,
                PlatformCertificateManager = manager
            });
        }

        internal static async Task InitializeCertificateManagerAsync()
        {
            var request = new Models.QueryCertificatesRequest() { AlgorithmType = "ALL" };
            var response = await InstanceUseRSA.ExecuteQueryCertificatesAsync(request);

            if (!response.IsSuccessful())
                throw new Exception();

            foreach (var certificate in InstanceUseRSA.DecryptResponseSensitiveProperty(response).CertificateList)
            {
                InstanceUseRSA.PlatformCertificateManager.AddEntry(new Settings.CertificateEntry(certificate));
            }
        }

        public static readonly WechatTenpayClient InstanceUseRSA;
        public static readonly WechatTenpayClient InstanceUseSM2;
    }
}
