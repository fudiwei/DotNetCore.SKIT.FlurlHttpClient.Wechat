namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    internal static class ITClients
    {
        public static WechatTenpayClient CreateInstance()
        {
            bool useSM = "SM2".Equals(ITConfigs.Credentials_MerchantCertificateAlgorithm, StringComparison.OrdinalIgnoreCase);

            var manager = new Settings.InMemoryCertificateManager();
            return new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = ITConfigs.Credentials_MerchantId,
                MerchantV3Secret = ITConfigs.Credentials_MerchantSecret,
                MerchantCertificateSerialNumber = useSM ? ITConfigs.Credentials_MerchantSM2CertificateSerialNumber : ITConfigs.Credentials_MerchantRSACertificateSerialNumber,
                MerchantCertificatePrivateKey = useSM ? ITConfigs.Credentials_MerchantSM2CertificatePrivateKey : ITConfigs.Credentials_MerchantRSACertificatePrivateKey,
                SignScheme = useSM ? Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3 : Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256,
                PlatformCertificateManager = manager
            });
        }
    }
}
