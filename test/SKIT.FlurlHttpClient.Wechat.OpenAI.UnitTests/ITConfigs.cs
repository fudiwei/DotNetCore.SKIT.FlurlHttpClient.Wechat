using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    internal static class ITConfigs
    {
        internal class AppSettings
        {
            public static class Types
            {
                public class Credentials
                {
                    public string? AppId { get; set; }
                    public string? Token { get; set; }
                    public string? EncodingAESKey { get; set; }
                    public string? AccessToken { get; set; }
                }

                public class Fixtures
                {
                    public string? AccountId { get; set; }
                    public string? UserId { get; set; }
                    public string? UserName { get; set; }
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

                Credentials_AppId = appsettings.Credentials?.AppId ?? string.Empty;
                Credentials_Token = appsettings.Credentials?.Token ?? string.Empty;
                Credentials_EncodingAESKey = appsettings.Credentials?.EncodingAESKey ?? string.Empty;
                Credentials_AccessToken = appsettings.Credentials?.AccessToken ?? string.Empty;
                Fixtures_AccountId = appsettings.Fixtures?.AccountId ?? string.Empty;
                Fixtures_UserId = appsettings.Fixtures?.UserId ?? string.Empty;
                Fixtures_UserName = appsettings.Fixtures?.UserName ?? string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因。", ex);
            }
        }

        public static readonly string Credentials_AppId;
        public static readonly string Credentials_Token;
        public static readonly string Credentials_EncodingAESKey;
        public static readonly string Credentials_AccessToken;
        public static readonly string Fixtures_AccountId;
        public static readonly string Fixtures_UserId;
        public static readonly string Fixtures_UserName;
    }
}
