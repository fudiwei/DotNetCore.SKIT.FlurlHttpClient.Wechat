using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
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
                    public string? AppSecret { get; set; }
                    public string? AccessToken { get; set; }
                }

                public class Fixtures
                {
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

                Credentials_AppId = appsettings.Credentials?.AppId ?? string.Empty;
                Credentials_AppSecret = appsettings.Credentials?.AppSecret ?? string.Empty;
                Credentials_AccessToken = appsettings.Credentials?.AccessToken ?? string.Empty;
                Fixtures_OpenId = appsettings.Fixtures?.OpenId ?? string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因。", ex);
            }
        }

        public static readonly string Credentials_AppId;
        public static readonly string Credentials_AppSecret;
        public static readonly string Credentials_AccessToken;
        public static readonly string Fixtures_OpenId;
    }
}
