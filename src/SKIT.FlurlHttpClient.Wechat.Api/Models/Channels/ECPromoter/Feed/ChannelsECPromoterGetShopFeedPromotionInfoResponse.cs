namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_shop_feed_promotion_info 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetShopFeedPromotionInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Feed : ChannelsECPromoterGetFeedPromotionInfoResponse.Types.Feed
            {
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
