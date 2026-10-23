using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests
{
    internal static class ITConfigs
    {
        internal class AppSettings
        {
            public static class Types
            {
                public class Credentials
                {
                    public string? MerchantId { get; set; }
                    public string? MerchantSecret { get; set; }
                    public byte[]? MerchantCertificateBase64String { get; set; }
                }

                public class Fixtures
                {
                    public string? AppId { get; set; }
                    public string? OpenId { get; set; }
                }
            }

            public Types.Credentials? Credentials { get; set; }
            public Types.Fixtures? Fixtures { get; set; }
        }

        static ITConfigs()
        {
            // NOTICE:  请在项目根目录下按照 appsettings.json 的格式新建 appsettings.local.json 填入测试参数。
            // WARNING: 请在 DEBUG 模式下运行测试用例。
            // WARNING: 敏感信息请不要提交到 git！

            try
            {
                using var stream = File.OpenRead("appsettings.local.json");
                var appsettings = JsonSerializer.Deserialize<AppSettings>(stream, JsonSerializerOptions.Web)!;

                Credentials_MerchantId = appsettings.Credentials?.MerchantId ?? string.Empty;
                Credentials_MerchantSecret = appsettings.Credentials?.MerchantSecret ?? string.Empty;
                Credentials_MerchantCertificateBytes = appsettings.Credentials?.MerchantCertificateBase64String ?? Array.Empty<byte>();
                Fixtures_OpenId = appsettings.Fixtures?.OpenId ?? string.Empty;
                Fixtures_AppId = appsettings.Fixtures?.AppId ?? string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因。", ex);
            }
        }

        public static readonly string Credentials_MerchantId;
        public static readonly string Credentials_MerchantSecret;
        public static readonly byte[] Credentials_MerchantCertificateBytes;
        public static readonly string Fixtures_AppId;
        public static readonly string Fixtures_OpenId;
    }
}
