using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.Ads.UnitTests
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
                WechatAgencyId = config.GetProperty("AgencyId").GetString();
                WechatAgencyAppId = config.GetProperty("AgencyAppId").GetString();
                WechatAgencyApiKey = config.GetProperty("AgencyApiKey").GetString();
                WechatAccessToken = config.GetProperty("AccessToken").GetString();

                ProjectSourceDirectory = jdoc.RootElement.GetProperty("ProjectSourceDirectory").GetString();
                ProjectTestDirectory = jdoc.RootElement.GetProperty("ProjectTestDirectory").GetString();
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因", ex);
            }
        }

        public static readonly string WechatAgencyId;
        public static readonly string WechatAgencyAppId;
        public static readonly string WechatAgencyApiKey;
        public static readonly string WechatAccessToken;

        public static readonly string ProjectSourceDirectory;
        public static readonly string ProjectTestDirectory;
    }
}
