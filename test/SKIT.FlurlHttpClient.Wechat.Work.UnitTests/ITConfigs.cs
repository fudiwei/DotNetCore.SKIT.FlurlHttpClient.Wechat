using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests
{
    internal static class ITConfigs
    {
        internal class AppSettings
        {
            public static class Types
            {
                public class Credentials
                {
                    public string? CorpId { get; set; }
                    public int AgentId { get; set; }
                    public string? AgentSecret { get; set; }
                    public string? AccessToken { get; set; }
                    public string? FinanceSecretKey { get; set; }
                    public int FinanceEncryptionVersion { get; set; }
                    public string? FinanceEncryptionPrivateKey { get; set; }
                }
            }

            public Types.Credentials? Credentials { get; set; }
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

                Credentials_CorpId = appsettings.Credentials?.CorpId ?? string.Empty;
                Credentials_AgentId = appsettings.Credentials?.AgentId ?? 0;
                Credentials_AgentSecret = appsettings.Credentials?.AgentSecret ?? string.Empty;
                Credentials_AccessToken = appsettings.Credentials?.AccessToken ?? string.Empty;
                Credentials_FinanceSecretKey = appsettings.Credentials?.FinanceSecretKey ?? string.Empty;
                Credentials_FinanceEncryptionVersion = appsettings.Credentials?.FinanceEncryptionVersion ?? 0;
                Credentials_FinanceEncryptionPrivateKey = appsettings.Credentials?.FinanceEncryptionPrivateKey ?? string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因。", ex);
            }
        }

        public static readonly string Credentials_CorpId;
        public static readonly int Credentials_AgentId;
        public static readonly string Credentials_AgentSecret;
        public static readonly string Credentials_AccessToken;
        public static readonly string Credentials_FinanceSecretKey;
        public static readonly int Credentials_FinanceEncryptionVersion;
        public static readonly string Credentials_FinanceEncryptionPrivateKey;
    }
}
