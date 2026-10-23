namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    internal static class ITClients
    {
        public static WechatApiClient CreateInstance()
        {
            return new WechatApiClient(new WechatApiClientOptions()
            {
                AppId = ITConfigs.Credentials_AppId,
                AppSecret = ITConfigs.Credentials_AppSecret
            });
        }
    }
}
