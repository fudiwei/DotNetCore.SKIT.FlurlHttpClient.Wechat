using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    class TestClients
    {
        static TestClients()
        {
            Instance = new WechatOpenAIClient(new WechatOpenAIClientOptions()
            { 
                ClientId = TestConfigs.WechatClientId,
                ClientKey =  TestConfigs.WechatClientKey
            });
        }

        public static readonly WechatOpenAIClient Instance;
    }
}
