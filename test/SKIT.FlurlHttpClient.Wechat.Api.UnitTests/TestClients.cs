namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new WechatApiClient(new WechatApiClientOptions()
            {
                AppId = TestConfigs.WechatAppId,
                AppSecret = TestConfigs.WechatAppSecret
            });
        }

        public static readonly WechatApiClient Instance;
    }
}
