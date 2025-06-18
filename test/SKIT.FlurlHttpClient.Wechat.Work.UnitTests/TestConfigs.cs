using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests
{
    internal class TestConfigs
    {
        static TestConfigs()
        {
            // NOTICE:  请在项目根目录下按照 appsettings.json 的格式新建 appsettings.local.json 填入测试参数。
            // WARNING: 请在 DEBUG 模式下运行测试用例。
            // WARNING: 敏感信息请不要提交到 git！

            try
            {
                using var stream = File.OpenRead("appsettings.local.json");
                using var jdoc = JsonDocument.Parse(stream);

                var config = jdoc.RootElement.GetProperty("TestConfigs");
                WechatCorpId = config.GetProperty("CorpId").GetString()!;
                WechatAgentId = int.Parse(config.GetProperty("AgentId").GetString()!);
                WechatAgentSecret = config.GetProperty("AgentSecret").GetString()!;
                WechatAccessToken = config.GetProperty("AccessToken").GetString()!;
                WechatFinanceSecretKey = config.GetProperty("FinanceSecretKey").GetString()!;
                WechatFinanceEncryptionPrivateKey = config.GetProperty("FinanceEncryptionPrivateKey").GetString()!;
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因", ex);
            }
        }

        public static readonly string WechatCorpId;
        public static readonly int WechatAgentId;
        public static readonly string WechatAgentSecret;
        public static readonly string WechatAccessToken;
        public static readonly string WechatFinanceSecretKey;
        public static readonly string WechatFinanceEncryptionPrivateKey;
    }
}
