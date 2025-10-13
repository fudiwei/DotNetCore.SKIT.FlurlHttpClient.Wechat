namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks/{stock_id} 接口的请求。</para>
    /// </summary>
    public class UpdateMarketingPartnerProductCouponStockRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class UsageRuleDisplayInfo : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.UsageRuleDisplayInfo
            {
            }

            public class CouponDisplayInfo : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.CouponDisplayInfo
            {
            }

            public class NotifyConfig : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.NotifyConfig
            {
            }
        }

        /// <summary>
        /// 获取或设置商品券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProductCouponId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置批次 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StockId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumebr { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置使用规则展示信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("usage_rule_display_info")]
        [System.Text.Json.Serialization.JsonPropertyName("usage_rule_display_info")]
        public Types.UsageRuleDisplayInfo? UsageRuleDisplayInfo { get; set; }

        /// <summary>
        /// 获取或设置商品券展示信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_display_info")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_display_info")]
        public Types.CouponDisplayInfo? CouponDisplayInfo { get; set; }

        /// <summary>
        /// 获取或设置可用门店范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_scope")]
        [System.Text.Json.Serialization.JsonPropertyName("store_scope")]
        public string? StoreScope { get; set; }

        /// <summary>
        /// 获取或设置事件通知配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_config")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_config")]
        public Types.NotifyConfig? NotifyConfig { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }
    }
}
