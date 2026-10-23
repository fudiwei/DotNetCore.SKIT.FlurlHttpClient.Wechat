using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
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
                    public string? MerchantCertificateAlgorithm { get; set; }
                    public string? MerchantRSACertificateSerialNumber { get; set; }
                    public string? MerchantRSACertificatePrivateKey { get; set; }
                    public string? MerchantSM2CertificateSerialNumber { get; set; }
                    public string? MerchantSM2CertificatePrivateKey { get; set; }
                }

                public class Fixtures
                {
                    public string? AppId { get; set; }
                    public string? OpenId { get; set; }
                    public string? TransactionId { get; set; }
                }
            }

            public Types.Credentials? Credentials { get; set; }
            public Types.Fixtures? Fixtures { get; set; }
        }

        static ITConfigs()
        {
            // NOTICE: 请在项目根目录下按照 appsettings.json 的格式新建 appsettings.local.json 填入测试参数。
            // WARN: 敏感信息请不要提交到 git！

            try
            {
                using var stream = File.OpenRead("appsettings.local.json");
                var appsettings = JsonSerializer.Deserialize<AppSettings>(stream, JsonSerializerOptions.Web)!;

                Credentials_MerchantId = appsettings.Credentials?.MerchantId ?? string.Empty;
                Credentials_MerchantSecret = appsettings.Credentials?.MerchantSecret ?? string.Empty;
                Credentials_MerchantCertificateAlgorithm = appsettings.Credentials?.MerchantCertificateAlgorithm;
                Credentials_MerchantRSACertificateSerialNumber = appsettings.Credentials?.MerchantRSACertificateSerialNumber ?? string.Empty;
                Credentials_MerchantRSACertificatePrivateKey = appsettings.Credentials?.MerchantRSACertificatePrivateKey ?? string.Empty;
                Credentials_MerchantSM2CertificateSerialNumber = appsettings.Credentials?.MerchantSM2CertificateSerialNumber ?? string.Empty;
                Credentials_MerchantSM2CertificatePrivateKey = appsettings.Credentials?.MerchantSM2CertificatePrivateKey ?? string.Empty;
                Fixtures_OpenId = appsettings.Fixtures?.OpenId ?? string.Empty;
                Fixtures_AppId = appsettings.Fixtures?.AppId ?? string.Empty;
                Fixtures_TransactionId = appsettings.Fixtures?.TransactionId ?? string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因。", ex);
            }
        }

        public static readonly string Credentials_MerchantId;
        public static readonly string Credentials_MerchantSecret;
        public static readonly string? Credentials_MerchantCertificateAlgorithm;
        public static readonly string Credentials_MerchantRSACertificateSerialNumber;
        public static readonly string Credentials_MerchantRSACertificatePrivateKey;
        public static readonly string Credentials_MerchantSM2CertificateSerialNumber;
        public static readonly string Credentials_MerchantSM2CertificatePrivateKey;
        public static readonly string Fixtures_AppId;
        public static readonly string Fixtures_OpenId;
        public static readonly string Fixtures_TransactionId;
    }
}
