using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.UnitTests
{
    internal class TestConfigs
    {
        static TestConfigs()
        {
            // NOTICE: 请在项目根目录下按照 appsettings.json 的格式新建 appsettings.local.json 填入测试参数。
            // WARN: 敏感信息请不要提交到 git！

            try
            {
                using var stream = File.OpenRead("appsettings.local.json");
                using var jdoc = JsonDocument.Parse(stream);

                var config = jdoc.RootElement.GetProperty("TestConfigs");
                WechatPlatformId = config.GetProperty("PlatformId").GetString()!;
                WechatPlatformCertSerialNumber = config.GetProperty("PlatformCertSerialNumber").GetString()!;
                WechatPlatformCertPrivateKey = config.GetProperty("PlatformCertPrivateKey").GetString()!;
                WechatTBEPCertSerialNumber = config.GetProperty("TBEPCertSerialNumber").GetString()!;
                WechatTBEPCertPrivateKey = config.GetProperty("TBEPCertPrivateKey").GetString()!;
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因", ex);
            }
        }

        public static readonly string WechatPlatformId;
        public static readonly string WechatPlatformCertSerialNumber;
        public static readonly string WechatPlatformCertPrivateKey;
        public static readonly string WechatTBEPCertSerialNumber;
        public static readonly string WechatTBEPCertPrivateKey;
    }
}
