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
                ClientKey = TestConfigs.WechatClientKey,
                AppId = TestConfigs.WechatAppId,
                Token = TestConfigs.WechatToken,
                EncodingAESKey = TestConfigs.WechatEncodingAESKey
            });
        }

        public static readonly WechatOpenAIClient Instance;
    }
}
