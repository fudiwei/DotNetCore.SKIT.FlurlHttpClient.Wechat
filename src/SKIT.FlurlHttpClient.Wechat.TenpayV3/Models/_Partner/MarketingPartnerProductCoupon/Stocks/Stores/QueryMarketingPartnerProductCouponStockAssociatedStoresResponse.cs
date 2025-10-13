namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks/{stock_id}/associated-stores 接口的响应。</para>
    /// </summary>
    public class QueryMarketingPartnerProductCouponStockAssociatedStoresResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Store
            {
                /// <summary>
                /// 获取或设置门店 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_id")]
                [System.Text.Json.Serialization.JsonPropertyName("store_id")]
                public string StoreId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置门店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_list")]
        [System.Text.Json.Serialization.JsonPropertyName("store_list")]
        public Types.Store[] StoreList { get; set; } = default!;

        /// <summary>
        /// 获取或设置下一页分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_page_token")]
        [System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// 获取或设置券总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
