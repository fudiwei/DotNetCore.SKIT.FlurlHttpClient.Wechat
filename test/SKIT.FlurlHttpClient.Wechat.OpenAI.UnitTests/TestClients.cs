using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    class TestClients
    {
        static TestClients()
        {
            InstanceForPlatform = new WechatOpenAIPlatformClient(new WechatOpenAIPlatformClientOptions()
            { 
                AppId = TestConfigs.WechatAppId,
                Token = TestConfigs.WechatToken,
                EncodingAESKey = TestConfigs.WechatEncodingAESKey
            });

            InstanceForThirdParty = new WechatOpenAIThirdPartyClient(new WechatOpenAIThirdPartyClientOptions()
            {
                ClientId = TestConfigs.WechatClientId,
                ClientKey = TestConfigs.WechatClientKey
            });
        }

        public static readonly WechatOpenAIPlatformClient InstanceForPlatform;
        public static readonly WechatOpenAIThirdPartyClient InstanceForThirdParty;
    }
}
