using System;

namespace SKIT.FlurlHttpClient.Wechat.Ads.UnitTests
{
    class TestClients
    {
        static TestClients()
        {
            Instance = new WechatAdsClient(new WechatAdsClientOptions()
            {
                AgencyId = TestConfigs.WechatAgencyId,
                AgencyAppId = TestConfigs.WechatAgencyAppId,
                AgencyApiKey = TestConfigs.WechatAgencyApiKey
            });
        }

        public static readonly WechatAdsClient Instance;
    }
}
