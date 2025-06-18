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
                /// 获取或设置单天剩余访问次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remain_visit_quota")]
                [System.Text.Json.Serialization.JsonPropertyName("remain_visit_quota")]
                public int RemainVisitQuota { get; set; }
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
        [Newtonsoft.Json.JsonProperty("quota_info")]
        [System.Text.Json.Serialization.JsonPropertyName("quota_info")]
        public Types.Quota Quota { get; set; } = default!;
    }
}
