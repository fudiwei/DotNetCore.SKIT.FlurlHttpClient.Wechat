namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.UnitTests
{
    internal static class ITClients
    {
        public static WechatTenpayBusinessClient CreateInstance()
        {
            return new WechatTenpayBusinessClient(new WechatTenpayBusinessClientOptions()
            {
                PlatformId = ITConfigs.Credentials_PlatformId,
                PlatformCertificateSerialNumber = ITConfigs.Credentials_PlatformCertificateSerialNumber,
                PlatformCertificatePrivateKey = ITConfigs.Credentials_PlatformCertificatePrivateKey,
                TBEPCertificateSerialNumber = ITConfigs.Credentials_TBEPCertificateSerialNumber,
                TBEPCertificatePublicKey = ITConfigs.Credentials_TBEPCertificatePrivateKey
            });
        }
    }
}
