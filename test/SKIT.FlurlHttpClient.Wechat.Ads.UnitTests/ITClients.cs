namespace SKIT.FlurlHttpClient.Wechat.Ads.UnitTests
{
    internal static class ITClients
    {
        public static WechatAdsClient CreateInstance()
        {
            return new WechatAdsClient(new WechatAdsClientOptions()
            {
                AgencyId = ITConfigs.Credentials_AgencyId,
                AgencyAppId = ITConfigs.Credentials_AgencyAppId,
                AgencyApiKey = ITConfigs.Credentials_AgencyApiKey
            });
        }
    }
}
