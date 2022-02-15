namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/generate_urllink 接口的请求。</para>
    /// </summary>
    public class WxaGenerateUrlLinkRequest : WechatApiRequest, IMapResponse<WxaGenerateUrlLinkRequest, WxaGenerateUrlLinkResponse>
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
                public string EnvironmentId { get; set; } = string.Empty;

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
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string Path { get; set; } = string.Empty;

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
        public string? EnvironmentVersion { get; set; }

        /// <summary>
        /// 获取或设置是否到期失效。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_expire")]
        [System.Text.Json.Serialization.JsonPropertyName("is_expire")]
        public bool? IsExpirable { get; set; }

        /// <summary>
        /// 获取或设置失效类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_type")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_type")]
        public int? ExpireType { get; set; }

        /// <summary>
        /// 获取或设置到期失效的时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        public long? ExpireTimestamp { get; set; }

        /// <summary>
        /// 获取或设置到期失效的时间间隔（单位：天）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_interval")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_interval")]
        public int? ExpireInterval { get; set; }

        /// <summary>
        /// 获取或设置云开发静态网站自定义 H5 配置参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cloud_base")]
        [System.Text.Json.Serialization.JsonPropertyName("cloud_base")]
        public Types.CloudBase? CloudBase { get; set; }
    }
}
