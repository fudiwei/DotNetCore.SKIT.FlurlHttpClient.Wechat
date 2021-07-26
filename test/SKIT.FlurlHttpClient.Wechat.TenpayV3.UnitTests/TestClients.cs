using System;

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

        public static readonly Settings.CertificateManager GlobalCertificateManager;

        public static readonly WechatTenpayClient Instance;
    }
}
