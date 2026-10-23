using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.UnitTests
{
    internal static class ITConfigs
    {
        internal class AppSettings
        {
            public static class Types
            {
                public class Credentials
                {
                    public string? PlatformId { get; set; }
                    public string? PlatformCertificateSerialNumber { get; set; }
                    public string? PlatformCertificatePrivateKey { get; set; }
                    public string? TBEPCertificateSerialNumber { get; set; }
                    public string? TBEPCertificatePrivateKey { get; set; }
                }
            }

            public Types.Credentials? Credentials { get; set; }
        }

        static ITConfigs()
        {
            // NOTICE: 请在项目根目录下按照 appsettings.json 的格式新建 appsettings.local.json 填入测试参数。
            // WARN: 敏感信息请不要提交到 git！

            try
            {
                using var stream = File.OpenRead("appsettings.local.json");
                var appsettings = JsonSerializer.Deserialize<AppSettings>(stream, JsonSerializerOptions.Web)!;

                Credentials_PlatformId = appsettings.Credentials?.PlatformId ?? string.Empty;
                Credentials_PlatformCertificateSerialNumber = appsettings.Credentials?.PlatformCertificateSerialNumber ?? string.Empty;
                Credentials_PlatformCertificatePrivateKey = appsettings.Credentials?.PlatformCertificatePrivateKey ?? string.Empty;
                Credentials_TBEPCertificateSerialNumber = appsettings.Credentials?.TBEPCertificateSerialNumber ?? string.Empty;
                Credentials_TBEPCertificatePrivateKey = appsettings.Credentials?.TBEPCertificatePrivateKey ?? string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因。", ex);
            }
        }

        public static readonly string Credentials_PlatformId;
        public static readonly string Credentials_PlatformCertificateSerialNumber;
        public static readonly string Credentials_PlatformCertificatePrivateKey;
        public static readonly string Credentials_TBEPCertificateSerialNumber;
        public static readonly string Credentials_TBEPCertificatePrivateKey;
    }
}
