namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks/{stock_id}/disassociate-stores 接口的响应。</para>
    /// </summary>
    public class DisassociateMarketingPartnerProductCouponStockFromStoresResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Store : AssociateMarketingPartnerProductCouponStockToStoresResponse.Types.Store
            {
            }
        }

        /// <summary>
        /// 获取或设置门店总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置取消关联成功的门店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_store_list")]
        [System.Text.Json.Serialization.JsonPropertyName("success_store_list")]
        public Types.Store[]? SucceededStoreList { get; set; }

        /// <summary>
        /// 获取或设置取消关联失败的门店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failed_store_list")]
        [System.Text.Json.Serialization.JsonPropertyName("failed_store_list")]
        public Types.Store[]? FailedStoreList { get; set; }
    }
}
