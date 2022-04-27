namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new WechatTenpayBusinessClient(new WechatTenpayBusinessClientOptions()
            {
                PlatformId = TestConfigs.WechatPlatformId,
                PlatformCertificateSerialNumber = TestConfigs.WechatPlatformCertSerialNumber,
                PlatformCertificatePrivateKey = TestConfigs.WechatPlatformCertPrivateKey,
                TBEPCertificateSerialNumber = TestConfigs.WechatTBEPCertSerialNumber,
                TBEPCertificatePublicKey = TestConfigs.WechatTBEPCertPrivateKey
            });
        }

        public static readonly WechatTenpayBusinessClient Instance;
    }
}
