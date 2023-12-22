namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/query_urllink 接口的响应。</para>
    /// </summary>
    public class WxaQueryUrlLinkResponse : WechatApiResponse
    {
        public static class Types
        {
            public class UrlLink
            {
                public static class Types
                {
                    public class CloudBase
                    {
                        /// <summary>
                        /// 获取或设置云开发环境 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("env")]
                        [System.Text.Json.Serialization.JsonPropertyName("env")]
                        public string EnvironmentId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置静态网站自定义域名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("domain")]
                        [System.Text.Json.Serialization.JsonPropertyName("domain")]
                        public string? Domain { get; set; }

                        /// <summary>
                        /// 获取或设置云开发静态网站 H5 页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path")]
                        [System.Text.Json.Serialization.JsonPropertyName("path")]
                        public string? Path { get; set; }

                        /// <summary>
                        /// 获取或设置云开发静态网站 H5 页面参数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("query")]
                        [System.Text.Json.Serialization.JsonPropertyName("query")]
                        public string? Query { get; set; }

                        /// <summary>
                        /// 获取或设置第三方平台的 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("resource_appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("resource_appid")]
                        public string? ResourceAppId { get; set; }
                    }
                }

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

                /// <summary>
                /// 获取或设置云开发静态网站自定义 H5 配置参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cloud_base")]
                [System.Text.Json.Serialization.JsonPropertyName("cloud_base")]
                public Types.CloudBase? CloudBase { get; set; }
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
        /// 获取或设置 URL Link 信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_link_info")]
        [System.Text.Json.Serialization.JsonPropertyName("url_link_info")]
        public Types.UrlLink UrlLink { get; set; } = default!;

        /// <summary>
        /// 获取或设置配额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quota_info")]
        [System.Text.Json.Serialization.JsonPropertyName("quota_info")]
        public Types.Quota Quota { get; set; } = default!;
    }
}
