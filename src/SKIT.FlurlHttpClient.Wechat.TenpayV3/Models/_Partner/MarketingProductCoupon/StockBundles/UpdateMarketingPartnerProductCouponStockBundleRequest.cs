namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stock-bundles/{stock_bundle_id} 接口的请求。</para>
    /// </summary>
    public class UpdateMarketingPartnerProductCouponStockBundleRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class UsageRuleDisplayInfo : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.__zz__UsageRuleDisplayInfo
            {
                public static class Types
                {
                    public class AvailableStore : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.UsageRuleDisplayInfo.Types.AvailableStore
                    {
                    }
                }

                /// <summary>
                /// 获取或设置可用门店信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_available_store_info")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_available_store_info")]
                public Types.AvailableStore? AvailableStore { get; set; }
            }

            public class CouponDisplayInfo : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.__zz__CouponDisplayInfo
            {
                public static class Types
                {
                    public class EntranceMiniProgram : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.CouponDisplayInfo.Types.EntranceMiniProgram
                    {
                    }

                    public class EntranceOfficalAccount : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.CouponDisplayInfo.Types.EntranceOfficalAccount
                    {
                    }

                    public class EntranceFinder : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.CouponDisplayInfo.Types.EntranceFinder
                    {
                    }
                }

                /// <summary>
                /// 获取或设置小程序入口信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entrance_mini_program")]
                [System.Text.Json.Serialization.JsonPropertyName("entrance_mini_program")]
                public Types.EntranceMiniProgram? EntranceMiniProgram { get; set; }

                /// <summary>
                /// 获取或设置公众号入口信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entrance_official_account")]
                [System.Text.Json.Serialization.JsonPropertyName("entrance_official_account")]
                public Types.EntranceOfficalAccount? EntranceOfficalAccount { get; set; }

                /// <summary>
                /// 获取或设置视频号入口信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entrance_finder")]
                [System.Text.Json.Serialization.JsonPropertyName("entrance_finder")]
                public Types.EntranceFinder? EntranceFinder { get; set; }
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
        public string? ProductCouponId { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string? BrandId { get; set; }

        /// <summary>
        /// 获取或设置批次组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? StockBundleId { get; set; }

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string? OutRequestNumebr { get; set; }

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
