using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    class TestClients
    {
        static TestClients()
        {
            Instance = new WechatTenpayClient(new WechatTenpayClientOptions()
            { 
                MerchantId = TestConfigs.WechatMerchantId,
                MerchantV3Secret = TestConfigs.WechatMerchantSecret,
                MerchantCertSerialNumber = TestConfigs.WechatMerchantCertSerialNumber,
                MerchantCertPrivateKey = TestConfigs.WechatMerchantCertPrivateKey
            });
        }

        public static readonly WechatTenpayClient Instance;
    }
}
