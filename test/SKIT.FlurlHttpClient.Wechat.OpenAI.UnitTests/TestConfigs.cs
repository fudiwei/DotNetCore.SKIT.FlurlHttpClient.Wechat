using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    class TestConfigs
    {
        static TestConfigs()
        {
            // NOTICE: 请在项目根目录下按照 appsettings.json 的格式新建 appsettings.local.json 填入测试参数。
            // WARN: 敏感信息请不要提交到 git！

            try
            {
                using var stream = File.OpenRead("appsettings.local.json");
                using var jdoc = JsonDocument.Parse(stream);

                var config = jdoc.RootElement.GetProperty("TestConfig");
                WechatClientId = config.GetProperty("ClientId").GetString();
                WechatClientKey = config.GetProperty("ClientKey").GetString();
                WechatAppId = config.GetProperty("AppId").GetString();
                WechatToken = config.GetProperty("Token").GetString();
                WechatEncodingAESKey = config.GetProperty("EncodingAESKey").GetString();
                WechatAccessToken = config.GetProperty("AccessToken").GetString();

                ProjectSourceDirectory = jdoc.RootElement.GetProperty("ProjectSourceDirectory").GetString();
                ProjectTestDirectory = jdoc.RootElement.GetProperty("ProjectTestDirectory").GetString();
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因", ex);
            }
        }

        public static readonly string WechatClientId;
        public static readonly string WechatClientKey;
        public static readonly string WechatAppId;
        public static readonly string WechatToken;
        public static readonly string WechatEncodingAESKey;
        public static readonly string WechatAccessToken;

        public static readonly string ProjectSourceDirectory;
        public static readonly string ProjectTestDirectory;
    }
}
