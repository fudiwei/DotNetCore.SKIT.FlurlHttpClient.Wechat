namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/shop/live/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCompassShopLiveListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Live
            {
                /// <summary>
                /// 获取或设置直播 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_id")]
                [System.Text.Json.Serialization.JsonPropertyName("live_id")]
                public string LiveId { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_title")]
                [System.Text.Json.Serialization.JsonPropertyName("live_title")]
                public string LiveTitle { get; set; } = default!;

                /// <summary>
                /// 获取或设置开播时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_time")]
                [System.Text.Json.Serialization.JsonPropertyName("live_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long LiveTimestamp { get; set; }

                /// <summary>
                /// 获取或设置直播时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_duration")]
                [System.Text.Json.Serialization.JsonPropertyName("live_duration")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int LiveDuration { get; set; }

                /// <summary>
                /// 获取或设置直播封面 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_cover_img_url")]
                [System.Text.Json.Serialization.JsonPropertyName("live_cover_img_url")]
                public string LiveCoverImageUrl { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置直播列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_list")]
        [System.Text.Json.Serialization.JsonPropertyName("live_list")]
        public Types.Live[] LiveList { get; set; } = default!;
    }
}
