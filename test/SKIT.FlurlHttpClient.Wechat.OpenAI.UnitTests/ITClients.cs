namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    internal static class ITClients
    {
        public static WechatOpenAIClient CreateOpenAIInstance()
        {
            return new WechatOpenAIClient(new WechatOpenAIClientOptions()
            {
                AppId = ITConfigs.Credentials_AppId,
                Token = ITConfigs.Credentials_Token,
                EncodingAESKey = ITConfigs.Credentials_EncodingAESKey
            });
        }

        public static WechatChatbotClient CreateChatbotInstance()
        {
            return new WechatChatbotClient(new WechatChatbotClientOptions()
            {
                AppId = ITConfigs.Credentials_AppId,
                Token = ITConfigs.Credentials_Token,
                EncodingAESKey = ITConfigs.Credentials_EncodingAESKey
            });
        }
    }
}
