using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
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
                WechatMerchantId = config.GetProperty("MerchantId").GetString()!;
                WechatMerchantSecret = config.GetProperty("MerchantSecret").GetString()!;
                WechatMerchantCertSerialNumber = config.GetProperty("MerchantCertSerialNumber").GetString()!;
                WechatMerchantCertPrivateKey = config.GetProperty("MerchantCertPrivateKey").GetString()!;
                WechatAppId = config.GetProperty("AppId").GetString()!;
                WechatOpenId = config.GetProperty("OpenId").GetString()!;

                ProjectSourceDirectory = jdoc.RootElement.GetProperty("ProjectSourceDirectory").GetString()!;
                ProjectTestDirectory = jdoc.RootElement.GetProperty("ProjectTestDirectory").GetString()!;
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因", ex);
            }
        }

        public static readonly string WechatMerchantId;
        public static readonly string WechatMerchantSecret;
        public static readonly string WechatMerchantCertSerialNumber;
        public static readonly string WechatMerchantCertPrivateKey;
        public static readonly string WechatAppId;
        public static readonly string WechatOpenId;

        public static readonly string ProjectSourceDirectory;
        public static readonly string ProjectTestDirectory;
    }
}
