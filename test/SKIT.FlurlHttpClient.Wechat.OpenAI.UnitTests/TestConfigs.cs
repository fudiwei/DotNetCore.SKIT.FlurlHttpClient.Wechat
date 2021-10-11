using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    class TestConfigs
    {
        static TestConfigs()
        {
            // NOTICE: 请在项目根目录下按照 appsettings.json 的格式填入测试参数。
            // WARN: 敏感信息请不要提交到 git！

            using var stream = File.OpenRead("appsettings.json");
            using var json = JsonDocument.Parse(stream);

            var config = json.RootElement.GetProperty("WechatConfig");
            WechatClientId = config.GetProperty("ClientId").GetString();
            WechatClientKey = config.GetProperty("ClientKey").GetString();
            WechatAppId = config.GetProperty("AppId").GetString();
            WechatToken = config.GetProperty("Token").GetString();
            WechatEncodingAESKey = config.GetProperty("EncodingAESKey").GetString();
            WechatAccessToken = config.GetProperty("AccessToken").GetString();

            ProjectSourceDirectory = json.RootElement.GetProperty("ProjectSourceDirectory").GetString();
            ProjectTestDirectory = json.RootElement.GetProperty("ProjectTestDirectory").GetString();
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
