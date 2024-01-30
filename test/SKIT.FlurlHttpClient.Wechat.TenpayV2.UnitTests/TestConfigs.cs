using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests
{
    class TestConfigs
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
                WechatAppId = config.GetProperty("AppId").GetString()!;
                WechatMerchantId = config.GetProperty("MerchantId").GetString()!;
                WechatMerchantSecret = config.GetProperty("MerchantSecret").GetString()!;
                WechatMerchantCertificateBytes = config.GetProperty("MerchantCertificateBase64String").GetBytesFromBase64();
                WechatOpenId = config.GetProperty("OpenId").GetString()!;
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因", ex);
            }
        }

        public static readonly string WechatAppId;
        public static readonly string WechatMerchantId;
        public static readonly string WechatMerchantSecret;
        public static readonly byte[] WechatMerchantCertificateBytes;
        public static readonly string WechatOpenId;
    }
}
