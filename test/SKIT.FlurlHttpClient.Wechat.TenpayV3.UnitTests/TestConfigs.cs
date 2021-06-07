using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
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
            WechatAppId = config.GetProperty("AppId").GetString();
            WechatMerchantId = config.GetProperty("MerchantId").GetString();
            WechatMerchantSecret = config.GetProperty("MerchantSecret").GetString();
            WechatMerchantCertSerialNumber = config.GetProperty("MerchantCertSerialNumber").GetString();
            WechatMerchantCertPrivateKey = config.GetProperty("MerchantCertPrivateKey").GetString();
            WechatOpenId = config.GetProperty("OpenId").GetString();

            ProjectSourceDirectory = json.RootElement.GetProperty("ProjectSourceDirectory").GetString();
            ProjectTestDirectory = json.RootElement.GetProperty("ProjectTestDirectory").GetString();
        }

        public static readonly string WechatAppId;
        public static readonly string WechatMerchantId;
        public static readonly string WechatMerchantSecret;
        public static readonly string WechatMerchantCertSerialNumber;
        public static readonly string WechatMerchantCertPrivateKey;
        public static readonly string WechatOpenId;

        public static readonly string ProjectSourceDirectory;
        public static readonly string ProjectTestDirectory;
    }
}
