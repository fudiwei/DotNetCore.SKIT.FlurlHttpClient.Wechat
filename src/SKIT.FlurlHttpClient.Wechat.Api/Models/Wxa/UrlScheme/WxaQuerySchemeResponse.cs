namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/queryscheme 接口的响应。</para>
    /// </summary>
    public class WxaQuerySchemeResponse : WechatApiResponse
    {
        public static class Types
        {
            public class UrlScheme
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string Path { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序页面参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query")]
                [System.Text.Json.Serialization.JsonPropertyName("query")]
                public string? Query { get; set; }

                /// <summary>
                /// 获取或设置要打开的小程序版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("env_version")]
                [System.Text.Json.Serialization.JsonPropertyName("env_version")]
                public string EnvironmentVersion { get; set; } = default!;

                /// <summary>
                /// 获取或设置过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public long ExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }

            public class Quota
            {
                /// <summary>
                /// 获取或设置长期有效的已生成次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("long_time_used")]
                [System.Text.Json.Serialization.JsonPropertyName("long_time_used")]
                public int LongTimeUsed { get; set; }

                /// <summary>
                /// 获取或设置长期有效的次数上限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("long_time_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("long_time_limit")]
                public int LongTimeLimit { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置 URL Scheme 信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scheme_info")]
        [System.Text.Json.Serialization.JsonPropertyName("scheme_info")]
        public Types.UrlScheme UrlScheme { get; set; } = default!;

        /// <summary>
        /// 获取或设置配额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scheme_quota")]
        [System.Text.Json.Serialization.JsonPropertyName("scheme_quota")]
        public Types.Quota Quota { get; set; } = default!;
    }
}
