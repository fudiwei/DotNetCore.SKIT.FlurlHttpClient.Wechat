namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/api_get_authorizer_list 接口的响应。</para>
    /// </summary>
    public class CgibinComponentApiGetAuthorizerListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Authorizer
            {
                /// <summary>
                /// 获取或设置授权方 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorizer_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("authorizer_appid")]
                public string AuthorizerAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置授权方 RefreshToken。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refresh_token")]
                [System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
                public string? AuthorizerRefreshToken { get; set; }

                /// <summary>
                /// 获取或设置授权时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_time")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_time")]
                public long AuthTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置授权方总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int Total { get; set; }

        /// <summary>
        /// 获取或设置授权方列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Authorizer[] AuthorizerList { get; set; } = default!;
    }
}
