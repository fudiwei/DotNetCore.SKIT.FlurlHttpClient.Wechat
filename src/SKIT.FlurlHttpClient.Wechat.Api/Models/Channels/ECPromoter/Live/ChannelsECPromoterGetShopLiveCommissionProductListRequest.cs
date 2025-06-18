namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_shop_live_commission_product_list 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetShopLiveCommissionProductListRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetShopLiveCommissionProductListRequest, ChannelsECPromoterGetShopLiveCommissionProductListResponse>
    {
        /// <summary>
        /// 获取或设置小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
        public string ShopId { get; set; } = string.Empty;

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
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? Cursor { get; set; }
    }
}
