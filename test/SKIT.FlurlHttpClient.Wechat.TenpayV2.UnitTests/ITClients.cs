namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests
{
    internal static class ITClients
    {
        public static WechatTenpayClient CreateInstance()
        {
            return new WechatTenpayClient(new WechatTenpayClientOptions()
            {
                MerchantId = ITConfigs.Credentials_MerchantId,
                MerchantSecret = ITConfigs.Credentials_MerchantSecret,
                MerchantCertificateBytes = ITConfigs.Credentials_MerchantCertificateBytes,
                AppId = ITConfigs.Fixtures_AppId
            });
        }
    }
}
