namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/get_wxa_followers 接口的响应。</para>
    /// </summary>
    public class WxaBusinessGetWxaFollowersResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Follower
            {
                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订阅时所处直播间 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("room_id")]
                [System.Text.Json.Serialization.JsonPropertyName("room_id")]
                public long RoomId { get; set; }

                /// <summary>
                /// 获取或设置订阅时所处直播间状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("room_status")]
                [System.Text.Json.Serialization.JsonPropertyName("room_status")]
                public int RoomStatus { get; set; }

                /// <summary>
                /// 获取或设置订阅时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subscribe_time")]
                [System.Text.Json.Serialization.JsonPropertyName("subscribe_time")]
                public long SubscribeTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置长期订阅用户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("followers")]
        [System.Text.Json.Serialization.JsonPropertyName("followers")]
        public Types.Follower[] FollowerList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_break")]
        [System.Text.Json.Serialization.JsonPropertyName("page_break")]
        public int NextPageBreak { get; set; }
    }
}
