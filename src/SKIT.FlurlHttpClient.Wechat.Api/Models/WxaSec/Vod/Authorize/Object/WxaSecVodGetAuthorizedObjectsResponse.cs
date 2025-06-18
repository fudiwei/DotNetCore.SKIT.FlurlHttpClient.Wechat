namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/getauthorizedobjects 接口的响应。</para>
    /// </summary>
    public class WxaSecVodGetAuthorizedObjectsResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Object
            {
                /// <summary>
                /// 获取或设置剧目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("drama_id")]
                [System.Text.Json.Serialization.JsonPropertyName("drama_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long DramaId { get; set; }

                /// <summary>
                /// 获取或设置授权方小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorizer_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("authorizer_appid")]
                public string AuthorizerAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置授权时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorized_time")]
                [System.Text.Json.Serialization.JsonPropertyName("authorized_time")]
                public long AuthorizeTimestamp { get; set; }

                /// <summary>
                /// 获取或设置授权到期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authz_expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("authz_expire_time")]
                public long? ExpireTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置授权列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("objects")]
        [System.Text.Json.Serialization.JsonPropertyName("objects")]
        public Types.Object[] ObjectList { get; set; } = default!;

        /// <summary>
        /// 获取或设置记录总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
