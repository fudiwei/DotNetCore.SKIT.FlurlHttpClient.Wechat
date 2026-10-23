namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests
{
    internal static class ITClients
    {
        public static WechatWorkClient CreateInstance()
        {
            return new WechatWorkClient(new WechatWorkClientOptions()
            {
                CorpId = ITConfigs.Credentials_CorpId,
                AgentId = ITConfigs.Credentials_AgentId,
                AgentSecret = ITConfigs.Credentials_AgentSecret
            });
        }
    }
}
