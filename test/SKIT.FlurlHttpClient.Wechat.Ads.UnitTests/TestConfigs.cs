using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.Ads.UnitTests
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
            WechatAgencyId = config.GetProperty("AgencyId").GetString();
            WechatAgencyAppId = config.GetProperty("AgencyAppId").GetString();
            WechatAgencyApiKey = config.GetProperty("AgencyApiKey").GetString();
            WechatAccessToken = config.GetProperty("AccessToken").GetString();

            ProjectSourceDirectory = json.RootElement.GetProperty("ProjectSourceDirectory").GetString();
            ProjectTestDirectory = json.RootElement.GetProperty("ProjectTestDirectory").GetString();
        }

        public static readonly string WechatAgencyId;
        public static readonly string WechatAgencyAppId;
        public static readonly string WechatAgencyApiKey;
        public static readonly string WechatAccessToken;

        public static readonly string ProjectSourceDirectory;
        public static readonly string ProjectTestDirectory;
    }
}
