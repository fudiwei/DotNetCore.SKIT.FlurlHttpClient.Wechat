namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests
{
    class TestClients
    {
        static TestClients()
        {
            Instance = new WechatTenpayClient(new WechatTenpayClientOptions()
            { 
                MerchantId = TestConfigs.WechatMerchantId,
                MerchantSecret = TestConfigs.WechatMerchantSecret,
                MerchantCertificateBytes = TestConfigs.WechatMerchantCertificateBytes,
                AppId = TestConfigs.WechatAppId
            });
        }

        public static readonly WechatTenpayClient Instance;
    }
}
