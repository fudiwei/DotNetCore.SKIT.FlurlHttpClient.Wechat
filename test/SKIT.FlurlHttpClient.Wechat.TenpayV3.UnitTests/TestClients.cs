using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    class TestClients
    {
        static TestClients()
        {
            GlobalCertificateStorer = new Settings.InMemoryCertificateStorer();
            Instance = new WechatTenpayClient(new WechatTenpayClientOptions()
            { 
                MerchantId = TestConfigs.WechatMerchantId,
                MerchantV3Secret = TestConfigs.WechatMerchantSecret,
                MerchantCertSerialNumber = TestConfigs.WechatMerchantCertSerialNumber,
                MerchantCertPrivateKey = TestConfigs.WechatMerchantCertPrivateKey,
                CertificateStorer = GlobalCertificateStorer
            });
        }

        public static readonly Settings.ICertificateStorer GlobalCertificateStorer;

        public static readonly WechatTenpayClient Instance;
    }
}
