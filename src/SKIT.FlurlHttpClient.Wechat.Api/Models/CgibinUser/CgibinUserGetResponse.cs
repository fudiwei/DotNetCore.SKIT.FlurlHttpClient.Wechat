namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/user/get 接口的响应。</para>
    /// </summary>
    public class CgibinUserGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置 OpenId 的列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string[] OpenIdList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置关注该公众账号的总用户数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        /// 获取或设置拉取列表的用户数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// 获取或设置列表数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;

        /// <summary>
        /// 获取或设置拉取列表的最后一个用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("next_openid")]
        public string NextOpenId { get; set; } = default!;
    }
}
