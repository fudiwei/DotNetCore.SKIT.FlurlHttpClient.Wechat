using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_shop_feed_promotion_info 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetShopFeedPromotionInfoRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetShopFeedPromotionInfoRequest, ChannelsECPromoterGetShopFeedPromotionInfoResponse>
    {
        public static class Types
        {
            public class Feed : ChannelsECPromoterGetFeedPromotionInfoRequest.Types.Feed
            {
            }
        }

        /// <summary>
        /// 获取或设置小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
        public string ShopAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置推客 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_appid")]
        public string? SharerAppId { get; set; }

        /// <summary>
        /// 获取或设置关联账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promoter_id")]
        [System.Text.Json.Serialization.JsonPropertyName("promoter_id")]
        public string PromoterId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置关联账号类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promoter_type")]
        [System.Text.Json.Serialization.JsonPropertyName("promoter_type")]
        public int PromoterType { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mini_program_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("mini_program_appid")]
        public string MiniProgramAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置短视频列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feed_list")]
        [System.Text.Json.Serialization.JsonPropertyName("feed_list")]
        public IList<Types.Feed> FeedList { get; set; } = new List<Types.Feed>();
    }
}
