using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks 接口的响应。</para>
    /// </summary>
    public class QueryMarketingPartnerProductCouponStocksResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Stock
            {
                public static class Types
                {
                    public class SendRule : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.SendRule
                    {
                    }

                    public class UsageRule
                    {
                        public static class Types
                        {
                            public class AvailablePeriod
                            {
                                public static class Types
                                {
                                    public class WeeklyPeriod
                                    {
                                        /// <summary>
                                        /// 获取或设置每周可用星期数列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("day_list")]
                                        [System.Text.Json.Serialization.JsonPropertyName("day_list")]
                                        public string[]? DayList { get; set; }

                                        /// <summary>
                                        /// 获取或设置当天可用时间段列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("day_period_list")]
                                        [System.Text.Json.Serialization.JsonPropertyName("day_period_list")]
                                        public DayPeriod[]? DayPeriodList { get; set; }
                                    }

                                    public class DayPeriod
                                    {
                                        /// <summary>
                                        /// 获取或设置当天可用开始时间（单位：秒）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("begin_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                                        public int BeginTime { get; set; }

                                        /// <summary>
                                        /// 获取或设置当天可用结束时间（单位：秒）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("end_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                        public int EndTime { get; set; }
                                    }

                                    public class IrregularPeriod
                                    {
                                        /// <summary>
                                        /// 获取或设置开始时间。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("begin_time")]
                                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                                        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                                        public DateTimeOffset BeginTime { get; set; }

                                        /// <summary>
                                        /// 获取或设置结束时间。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("end_time")]
                                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                                        public DateTimeOffset EndTime { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置开始时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("available_begin_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("available_begin_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                                public DateTimeOffset BeginTime { get; set; }

                                /// <summary>
                                /// 获取或设置结束时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("available_end_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("available_end_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                                public DateTimeOffset EndTime { get; set; }

                                /// <summary>
                                /// 获取或设置生效后 N 天内有效。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("available_days")]
                                [System.Text.Json.Serialization.JsonPropertyName("available_days")]
                                public int? AvailableDays { get; set; }

                                /// <summary>
                                /// 获取或设置领取后 N 天开始生效。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("wait_days_after_receive")]
                                [System.Text.Json.Serialization.JsonPropertyName("wait_days_after_receive")]
                                public int? WaitDaysAfterReceive { get; set; }

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
                                public Types.IrregularPeriod[]? IrregularPeriodList { get; set; }
                            }

                            public class NormalCoupon : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.UsageRule.Types.NormalCoupon
                            {
                            }

                            public class DiscountCoupon : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.UsageRule.Types.DiscountCoupon
                            {
                            }

                            public class ExchangeCoupon : CreateMarketingPartnerProductCouponStockRequest.Types.StockInfo.Types.UsageRule.Types.ExchangeCoupon
                            {
                            }
                        }
                    }

                    public class SingleUsageRule : UsageRule
                    {
                        /// <summary>
                        /// 获取或设置券可核销时间信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_available_period")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_available_period")]
                        public Types.AvailablePeriod AvailablePeriod { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置满减券使用规则信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("normal_coupon")]
                        [System.Text.Json.Serialization.JsonPropertyName("normal_coupon")]
                        public Types.NormalCoupon? NormalCoupon { get; set; }

                        /// <summary>
                        /// 获取或设置折扣券使用规则信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_coupon")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_coupon")]
                        public Types.DiscountCoupon? DiscountCoupon { get; set; }

                        /// <summary>
                        /// 获取或设置兑换券使用规则信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exchange_coupon")]
                        [System.Text.Json.Serialization.JsonPropertyName("exchange_coupon")]
                        public Types.ExchangeCoupon? ExchangeCoupon { get; set; }
                    }

                    public class SequentialUsageRule : UsageRule
                    {
                        /// <summary>
                        /// 获取或设置券可核销时间信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_available_period")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_available_period")]
                        public Types.AvailablePeriod AvailablePeriod { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置满减券使用规则列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("normal_coupon_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("normal_coupon_list")]
                        public Types.NormalCoupon[]? NormalCouponList { get; set; }

                        /// <summary>
                        /// 获取或设置折扣券使用规则列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_coupon_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_coupon_list")]
                        public Types.DiscountCoupon[]? DiscountCouponList { get; set; }

                        /// <summary>
                        /// 获取或设置兑换券使用规则列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exchange_coupon_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("exchange_coupon_list")]
                        public Types.ExchangeCoupon[]? ExchangeCouponList { get; set; }

                        /// <summary>
                        /// 获取或设置是否提供首笔特惠。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("special_first")]
                        [System.Text.Json.Serialization.JsonPropertyName("special_first")]
                        public bool? IsSpecialFirst { get; set; }
                    }

                    public class UsageRuleDisplayInfo
                    {
                        public static class Types
                        {
                            public class AvailableStore
                            {
                                /// <summary>
                                /// 获取或设置可用门店描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("description")]
                                [System.Text.Json.Serialization.JsonPropertyName("description")]
                                public string Description { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置门店小程序 AppId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mini_program_appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("mini_program_appid")]
                                public string? MiniProgramAppId { get; set; }

                                /// <summary>
                                /// 获取或设置门店小程序页面路径。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mini_program_path")]
                                [System.Text.Json.Serialization.JsonPropertyName("mini_program_path")]
                                public string? MiniProgramPagePath { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置券使用方式列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_usage_method_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_usage_method_list")]
                        public string[] UsageMethodList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置券使用说明。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("usage_description")]
                        [System.Text.Json.Serialization.JsonPropertyName("usage_description")]
                        public string? UsageDescription { get; set; }

                        /// <summary>
                        /// 获取或设置品牌方小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mini_program_appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("mini_program_appid")]
                        public string? MiniProgramAppId { get; set; }

                        /// <summary>
                        /// 获取或设置品牌方小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mini_program_path")]
                        [System.Text.Json.Serialization.JsonPropertyName("mini_program_path")]
                        public string? MiniProgramPagePath { get; set; }

                        /// <summary>
                        /// 获取或设置品牌方 App 跳转路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_path")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_path")]
                        public string? AppPath { get; set; }

                        /// <summary>
                        /// 获取或设置可用门店信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_available_store_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_available_store_info")]
                        public Types.AvailableStore? AvailableStore { get; set; }
                    }

                    public class CouponDisplayInfo
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
                        /// 获取或设置券 Code 展示模式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code_display_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("code_display_mode")]
                        public string CodeDisplayMode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置背景颜色。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("background_color")]
                        [System.Text.Json.Serialization.JsonPropertyName("background_color")]
                        public string? BackgroundColor { get; set; }

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

                    public class CodeCountInfo
                    {
                        /// <summary>
                        /// 获取或设置总数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                        public int TotalCount { get; set; }

                        /// <summary>
                        /// 获取或设置可用数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("available_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("available_count")]
                        public int AvailableCount { get; set; }
                    }

                    public class SentCountInfo
                    {
                        /// <summary>
                        /// 获取或设置已发放总次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                        public int TotalCount { get; set; }

                        /// <summary>
                        /// 获取或设置当天已发放次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("today_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("today_count")]
                        public int TodayCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_coupon_id")]
                public string ProductCouponId { get; set; } = default!;

                /// <summary>
                /// 获取或设置品牌 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_id")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                public string BrandId { get; set; } = default!;

                /// <summary>
                /// 获取或设置批次 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_id")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
                public string StockId { get; set; } = default!;

                /// <summary>
                /// 获取或设置券 Code 分配模式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_code_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_code_mode")]
                public string CouponCodeMode { get; set; } = default!;

                /// <summary>
                /// 获取或设置发放规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_send_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_send_rule")]
                public Types.SendRule SendRule { get; set; } = default!;

                /// <summary>
                /// 获取或设置单券使用规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("single_usage_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("single_usage_rule")]
                public Types.SingleUsageRule? SingleUsageRule { get; set; }

                /// <summary>
                /// 获取或设置多次优惠使用规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sequential_usage_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("sequential_usage_rule")]
                public Types.SequentialUsageRule? SequentialUsageRule { get; set; }

                /// <summary>
                /// 获取或设置使用规则展示信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("usage_rule_display_info")]
                [System.Text.Json.Serialization.JsonPropertyName("usage_rule_display_info")]
                public Types.UsageRuleDisplayInfo UsageRuleDisplayInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品券展示信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_display_info")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_display_info")]
                public Types.CouponDisplayInfo CouponDisplayInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置可用门店范围。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_scope")]
                [System.Text.Json.Serialization.JsonPropertyName("store_scope")]
                public string StoreScope { get; set; } = default!;

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

                /// <summary>
                /// 获取或设置 Code 数量信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_code_count_info")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_code_count_info")]
                public Types.CodeCountInfo CodeCountInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置已发放数量信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sent_count_info")]
                [System.Text.Json.Serialization.JsonPropertyName("sent_count_info")]
                public Types.SentCountInfo SentCountInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置批次状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public string State { get; set; } = default!;

                /// <summary>
                /// 获取或设置失效请求单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deactivate_request_no")]
                [System.Text.Json.Serialization.JsonPropertyName("deactivate_request_no")]
                public string? DeactivateOutRequestNumber { get; set; }

                /// <summary>
                /// 获取或设置失效时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deactivate_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("deactivate_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset? DeactivateTime { get; set; }

                /// <summary>
                /// 获取或设置失效原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deactivate_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("deactivate_reason")]
                public string? DeactivateReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置批次列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_list")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_list")]
        public Types.Stock[] StockList { get; set; } = default!;

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
