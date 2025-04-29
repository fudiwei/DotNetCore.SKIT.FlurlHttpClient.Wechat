namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguidebuyerrelationlist 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGuideBuyerRelationListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Buyer
            {
                /// <summary>
                /// 获取或设置客户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置客户微信昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buyer_nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("buyer_nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置绑定时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置客户账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Buyer[]? BuyerList { get; set; }

        /// <summary>
        /// 获取或设置客户总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
