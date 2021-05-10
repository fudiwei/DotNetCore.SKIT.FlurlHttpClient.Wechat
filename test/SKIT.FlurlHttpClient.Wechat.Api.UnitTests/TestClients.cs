using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    class TestClients
    {
        static TestClients()
        {
            Instance = new WechatApiClient(TestConfigs.WechatAppId, TestConfigs.WechatAppSecret);
        }

        public static readonly WechatApiClient Instance;
    }
}
