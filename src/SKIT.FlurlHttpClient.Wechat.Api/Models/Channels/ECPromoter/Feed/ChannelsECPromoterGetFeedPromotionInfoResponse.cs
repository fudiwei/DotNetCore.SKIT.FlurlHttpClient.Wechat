namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_feed_promotion_info 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetFeedPromotionInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Feed
            {
                /// <summary>
                /// 获取或设置短视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("export_id")]
                [System.Text.Json.Serialization.JsonPropertyName("export_id")]
                public string ExportId { get; set; } = default!;

                /// <summary>
                /// 获取或设置内嵌短视频的卡片信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("feed_token")]
                [System.Text.Json.Serialization.JsonPropertyName("feed_token")]
                public string FeedToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置推广推客信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoter_share_link")]
                [System.Text.Json.Serialization.JsonPropertyName("promoter_share_link")]
                public string PromoterShareLink { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置短视频列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feed_list")]
        [System.Text.Json.Serialization.JsonPropertyName("feed_list")]
        public Types.Feed[] List { get; set; } = default!;
    }
}
