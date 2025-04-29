namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/querybookauth 接口的响应。</para>
    /// </summary>
    public class WxaBookQueryBookAuthResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置作品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("book_id")]
                [System.Text.Json.Serialization.JsonPropertyName("book_id")]
                public string BookId { get; set; } = default!;

                /// <summary>
                /// 获取或设置主授权账号 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grantor_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("grantor_appid")]
                public string GrantorAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置被授权账号 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grantee_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("grantee_appid")]
                public string GranteeAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置授权到期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public long? ExpireTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("results")]
        [System.Text.Json.Serialization.JsonPropertyName("results")]
        public Types.Result[] ResultList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sum")]
        [System.Text.Json.Serialization.JsonPropertyName("sum")]
        public int? TotalCount { get; set; }
    }
}
