using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stock-bundles 接口的请求。</para>
    /// </summary>
    public class CreateMarketingPartnerProductCouponStockBundleRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class StockBundle
            {
                public static class Types
                {
                    public class SendRule : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.SendRule
                    {
                    }

                    public class UsageRule : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.UsageRule
                    {
                    }

                    public class ProgressiveBundleUsageRule : UsageRule
                    {
                        /// <summary>
                        /// 获取或设置券可核销时间信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_available_period")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_available_period")]
                        public Types.AvailablePeriod AvailablePeriod { get; set; } = new Types.AvailablePeriod();

                        /// <summary>
                        /// 获取或设置满减券使用规则列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("normal_coupon_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("normal_coupon_list")]
                        public IList<Types.NormalCoupon>? NormalCouponList { get; set; }

                        /// <summary>
                        /// 获取或设置折扣券使用规则列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_coupon_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_coupon_list")]
                        public IList<Types.DiscountCoupon>? DiscountCouponList { get; set; }

                        /// <summary>
                        /// 获取或设置兑换券使用规则列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exchange_coupon_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("exchange_coupon_list")]
                        public IList<Types.ExchangeCoupon>? ExchangeCouponList { get; set; }
                    }

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
                /// 获取或设置券 Code 分配模式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_code_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_code_mode")]
                public string CouponCodeMode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置发放规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_send_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_send_rule")]
                public Types.SendRule SendRule { get; set; } = new Types.SendRule();

                /// <summary>
                /// 获取或设置多次优惠使用规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("progressive_bundle_usage_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("progressive_bundle_usage_rule")]
                public Types.ProgressiveBundleUsageRule? ProgressiveBundleUsageRule { get; set; }

                /// <summary>
                /// 获取或设置使用规则展示信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("usage_rule_display_info")]
                [System.Text.Json.Serialization.JsonPropertyName("usage_rule_display_info")]
                public Types.UsageRuleDisplayInfo UsageRuleDisplayInfo { get; set; } = new Types.UsageRuleDisplayInfo();

                /// <summary>
                /// 获取或设置商品券展示信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_display_info")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_display_info")]
                public Types.CouponDisplayInfo CouponDisplayInfo { get; set; } = new Types.CouponDisplayInfo();

                /// <summary>
                /// 获取或设置可用门店范围。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_scope")]
                [System.Text.Json.Serialization.JsonPropertyName("store_scope")]
                public string StoreScope { get; set; } = string.Empty;

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
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumebr { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置批次组信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_bundle")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_bundle")]
        public Types.StockBundle? StockBundle { get; set; }
    }
}
