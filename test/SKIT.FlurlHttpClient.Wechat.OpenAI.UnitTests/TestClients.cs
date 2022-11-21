namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new WechatOpenAIClient(new WechatOpenAIClientOptions()
            {
                AppId = TestConfigs.WechatAppId,
                Token = TestConfigs.WechatToken,
                EncodingAESKey = TestConfigs.WechatEncodingAESKey
            });
        }

        public static readonly WechatOpenAIClient Instance;
    }
}
