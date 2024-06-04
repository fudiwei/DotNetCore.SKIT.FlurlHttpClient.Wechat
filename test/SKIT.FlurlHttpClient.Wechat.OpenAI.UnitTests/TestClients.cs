namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            OpenAIInstance = new WechatOpenAIClient(new WechatOpenAIClientOptions()
            {
                AppId = TestConfigs.WechatAppId,
                Token = TestConfigs.WechatToken,
                EncodingAESKey = TestConfigs.WechatEncodingAESKey
            });
            ChatbotInstance = new WechatChatbotClient(new WechatChatbotClientOptions()
            {
                AppId = TestConfigs.WechatAppId,
                Token = TestConfigs.WechatToken,
                EncodingAESKey = TestConfigs.WechatEncodingAESKey
            });
        }

        public static readonly WechatOpenAIClient OpenAIInstance;
        public static readonly WechatChatbotClient ChatbotInstance;
    }
}
