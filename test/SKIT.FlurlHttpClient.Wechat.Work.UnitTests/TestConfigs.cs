using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests
{
    class TestConfigs
    {
        static TestConfigs()
        {
            // NOTICE: 请在项目根目录下建立 appsettings.local.json，按照 appsettings.json 的格式填入测试参数。
            // WARN: 敏感信息请不要提交到 git！

            using var stream = File.OpenRead("appsettings.local.json");
            using var json = JsonDocument.Parse(stream);
            var config = json.RootElement.GetProperty("WechatConfig");
            WechatCorpId = config.GetProperty("CorpId").GetString();
            WechatAgentId = int.Parse(config.GetProperty("AgentId").GetString());
            WechatAgentSecret = config.GetProperty("AgentSecret").GetString();
        }

        public static readonly string WechatCorpId;
        public static readonly int WechatAgentId;
        public static readonly string WechatAgentSecret;
    }
}
