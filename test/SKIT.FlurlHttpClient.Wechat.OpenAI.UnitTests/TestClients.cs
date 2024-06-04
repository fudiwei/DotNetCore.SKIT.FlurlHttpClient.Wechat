namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new WechatChatbotClient(new WechatChatbotClientOptions()
            {
                AppId = TestConfigs.WechatAppId,
                Token = TestConfigs.WechatToken,
                EncodingAESKey = TestConfigs.WechatEncodingAESKey
            });
        }

        public static readonly WechatChatbotClient Instance;
    }
}
