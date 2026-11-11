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

                    public class BaseUsageRule
                    {
                        public static class Types
                        {
                            public abstract class __zz__AvailablePeriod : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.BaseUsageRule.Types.__zz__AvailablePeriod
                            {
                            }

                            public class AvailablePeriod : __zz__AvailablePeriod
                            {
                                public static class Types
                                {
                                    public class WeeklyPeriod : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.BaseUsageRule.Types.AvailablePeriod.Types.__zz__WeeklyPeriod
                                    {
                                        public class DayPeriod : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.BaseUsageRule.Types.AvailablePeriod.Types.WeeklyPeriod.Types.DayPeriod
                                        {
                                        }

                                        /// <summary>
                                        /// 获取或设置当天可用时间段列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("day_period_list")]
                                        [System.Text.Json.Serialization.JsonPropertyName("day_period_list")]
                                        public List<DayPeriod>? DayPeriodList { get; set; }
                                    }

                                    public class IrregularPeriod : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.BaseUsageRule.Types.AvailablePeriod.Types.IrregularPeriod
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置每周固定可用时间信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("weekly_available_period")]
                                [System.Text.Json.Serialization.JsonPropertyName("weekly_available_period")]
                                public Types.WeeklyPeriod? WeeklyPeriod { get; set; }

                                /// <summary>
                                /// 获取或设置无规律的可用时间段信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("irregular_available_period_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("irregular_available_period_list")]
                                public List<Types.IrregularPeriod>? IrregularPeriodList { get; set; }
                            }

                            public class NormalCoupon : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.BaseUsageRule.Types.NormalCoupon
                            {
                            }

                            public class DiscountCoupon : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.BaseUsageRule.Types.DiscountCoupon
                            {
                            }

                            public class ExchangeCoupon : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.BaseUsageRule.Types.ExchangeCoupon
                            {
                            }
                        }
                    }

                    public class ProgressiveBundleUsageRule : BaseUsageRule
                    {
                        /// <summary>
                        /// 获取或设置券可核销时间信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_available_period")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_available_period")]
                        public Types.AvailablePeriod? AvailablePeriod { get; set; }

                        /// <summary>
                        /// 获取或设置满减券使用规则列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("normal_coupon_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("normal_coupon_list")]
                        public List<Types.NormalCoupon>? NormalCouponList { get; set; }

                        /// <summary>
                        /// 获取或设置折扣券使用规则列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_coupon_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_coupon_list")]
                        public List<Types.DiscountCoupon>? DiscountCouponList { get; set; }

                        /// <summary>
                        /// 获取或设置兑换券使用规则列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exchange_coupon_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("exchange_coupon_list")]
                        public List<Types.ExchangeCoupon>? ExchangeCouponList { get; set; }
                    }

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
                /// 获取或设置券 Code 分配模式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_code_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_code_mode")]
                public string? CouponCodeMode { get; set; }

                /// <summary>
                /// 获取或设置发放规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_send_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_send_rule")]
                public Types.SendRule? SendRule { get; set; }

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
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string? OutRequestNumebr { get; set; }

        /// <summary>
        /// 获取或设置批次组信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_bundle")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_bundle")]
        public Types.StockBundle? StockBundle { get; set; }
    }
}
