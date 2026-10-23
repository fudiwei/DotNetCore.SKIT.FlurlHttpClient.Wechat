using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.Ads.UnitTests
{
    internal static class ITConfigs
    {
        internal class AppSettings
        {
            public static class Types
            {
                public class Credentials
                {
                    public string? AgencyId { get; set; }
                    public string? AgencyAppId { get; set; }
                    public string? AgencyApiKey { get; set; }
                    public string? AccessToken { get; set; }
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

                Credentials_AgencyId = appsettings.Credentials?.AgencyId ?? string.Empty;
                Credentials_AgencyAppId = appsettings.Credentials?.AgencyAppId ?? string.Empty;
                Credentials_AgencyApiKey = appsettings.Credentials?.AgencyApiKey ?? string.Empty;
                Credentials_AccessToken = appsettings.Credentials?.AccessToken ?? string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因。", ex);
            }
        }

        public static readonly string Credentials_AgencyId;
        public static readonly string Credentials_AgencyAppId;
        public static readonly string Credentials_AgencyApiKey;
        public static readonly string Credentials_AccessToken;
    }
}
