using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests
{
    class TestClients
    {
        static TestClients()
        {
            Instance = new WechatWorkClient(new WechatWorkClientOptions()
            {
                CorpId = TestConfigs.WechatCorpId,
                AgentId = TestConfigs.WechatAgentId,
                AgentSecret = TestConfigs.WechatAgentSecret
            });
        }

        public static readonly WechatWorkClient Instance;
    }
}
