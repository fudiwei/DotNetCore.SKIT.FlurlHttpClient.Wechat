using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    class TestClients
    {
        static TestClients()
        {
            Instance = new WechatApiClient(new WechatApiClientOptions()
            { 
                AppId = TestConfigs.WechatAppId,
                AppSecret =  TestConfigs.WechatAppSecret
            });
        }

        public static readonly WechatApiClient Instance;
    }
}
