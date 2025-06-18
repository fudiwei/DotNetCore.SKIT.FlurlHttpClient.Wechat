namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/sharer/get_sharer_list 接口的响应。</para>
    /// </summary>
    public class ShopSharerGetSharerListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Sharer
            {
                /// <summary>
                /// 获取或设置分享员 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置分享员昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置邀请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invited_time")]
                [System.Text.Json.Serialization.JsonPropertyName("invited_time")]
                public long InviteTimestamp { get; set; }

                /// <summary>
                /// 获取或设置绑定时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bind_time")]
                [System.Text.Json.Serialization.JsonPropertyName("bind_time")]
                public long BindTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置分享员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharers")]
        [System.Text.Json.Serialization.JsonPropertyName("sharers")]
        public Types.Sharer[] SharerList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
