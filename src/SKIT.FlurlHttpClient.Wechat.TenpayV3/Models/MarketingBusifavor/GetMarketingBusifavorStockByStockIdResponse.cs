namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/busifavor/stocks/{stock_id} 接口的响应。</para>
    /// </summary>
    public class GetMarketingBusifavorStockByStockIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class StockSendRule
            {
                /// <summary>
                /// 获取或设置发放总上限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_coupons")]
                [System.Text.Json.Serialization.JsonPropertyName("max_coupons")]
                public int MaxCoupons { get; set; }

                /// <summary>
                /// 获取或设置批次总预算（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("max_amount")]
                public long? MaxAmount { get; set; }

                /// <summary>
                /// 获取或设置单个用户可领个数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_coupons_per_user")]
                [System.Text.Json.Serialization.JsonPropertyName("max_coupons_per_user")]
                public int MaxCouponsPerUser { get; set; }

                /// <summary>
                /// 获取或设置单天发放上限金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_amount_by_day")]
                [System.Text.Json.Serialization.JsonPropertyName("max_amount_by_day")]
                public long? MaxAmountPerDay { get; set; }

                /// <summary>
                /// 获取或设置单天发放上限个数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_coupons_by_day")]
                [System.Text.Json.Serialization.JsonPropertyName("max_coupons_by_day")]
                public int? MaxCouponsPerDay { get; set; }

                /// <summary>
                /// 获取或设置是否开启自然人限制。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("natural_person_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("natural_person_limit")]
                public bool? IsNaturalPersonLimit { get; set; }

                /// <summary>
                /// 获取或设置是否开启防刷拦截。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prevent_api_abuse")]
                [System.Text.Json.Serialization.JsonPropertyName("prevent_api_abuse")]
                public bool? IsPreventApiAbuse { get; set; }

                /// <summary>
                /// 获取或设置是否允许转赠。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transferable")]
                [System.Text.Json.Serialization.JsonPropertyName("transferable")]
                public bool? IsTransferable { get; set; }

                /// <summary>
                /// 获取或设置是否允许分享链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shareable")]
                [System.Text.Json.Serialization.JsonPropertyName("shareable")]
                public bool? IsShareable { get; set; }
            }

            public class CouponUseRule : CreateMarketingBusifavorStockRequest.Types.__zz__CouponUseRule
            {
                public static class Types
                {
                    public class CouponAvailableTime : CreateMarketingBusifavorStockRequest.Types.CouponUseRule.Types.__zz__CouponAvailableTime
                    {
                        public static class Types
                        {
                            public class AvailableWeek
                            {
                                public static class Types
                                {
                                    public class AvailableTimeRange : CreateMarketingBusifavorStockRequest.Types.CouponUseRule.Types.CouponAvailableTime.Types.AvailableWeek.Types.AvailableTimeRange
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置可用星期数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("week_day")]
                                [System.Text.Json.Serialization.JsonPropertyName("week_day")]
                                public List<int>? WeekDayList { get; set; }

                                /// <summary>
                                /// 获取或设置当天可用时间段。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("available_day_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("available_day_time")]
                                public List<Types.AvailableTimeRange>? AvailableTimeRangeList { get; set; }
                            }

                            public class AvailableTime : CreateMarketingBusifavorStockRequest.Types.CouponUseRule.Types.CouponAvailableTime.Types.AvailableTime
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置固定周期有效时间段信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("available_week")]
                        [System.Text.Json.Serialization.JsonPropertyName("available_week")]
                        public Types.AvailableWeek? AvailableWeek { get; set; }

                        /// <summary>
                        /// 获取或设置无规律的有效时间段信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("irregulary_avaliable_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("irregulary_avaliable_time")]
                        public List<Types.AvailableTime>? IrregularyAvailableTimeList { get; set; }
                    }

                    public class NormalCoupon : CreateMarketingBusifavorStockRequest.Types.CouponUseRule.Types.NormalCoupon
                    {
                    }

                    public class DiscountCoupon : CreateMarketingBusifavorStockRequest.Types.CouponUseRule.Types.DiscountCoupon
                    {
                    }

                    public class ExchangeCoupon : CreateMarketingBusifavorStockRequest.Types.CouponUseRule.Types.ExchangeCoupon
                    {
                    }
                }

                /// <summary>
                /// 获取或设置券生效时间信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_available_time")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_available_time")]
                public Types.CouponAvailableTime? CouponAvailableTime { get; set; }

                /// <summary>
                /// 获取或设置固定面额满减券使用规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fixed_normal_coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("fixed_normal_coupon")]
                public Types.NormalCoupon? NormalCoupon { get; set; }

                /// <summary>
                /// 获取或设置折扣券使用规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_coupon")]
                public Types.DiscountCoupon? DiscountCoupon { get; set; }

                /// <summary>
                /// 获取或设置换购券使用规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exchange_coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("exchange_coupon")]
                public Types.ExchangeCoupon? ExchangeCoupon { get; set; }
            }

            public class CustomEntrance : CreateMarketingBusifavorStockRequest.Types.__zz__CustomEntrance
            {
                public static class Types
                {
                    public class MiniProgram : CreateMarketingBusifavorStockRequest.Types.CustomEntrance.Types.MiniProgram
                    {
                    }
                }

                /// <summary>
                /// 获取或设置商家小程序入口信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mini_programs_info")]
                [System.Text.Json.Serialization.JsonPropertyName("mini_programs_info")]
                public Types.MiniProgram? MiniProgram { get; set; }
            }

            public class DisplayPattern : CreateMarketingBusifavorStockRequest.Types.__zz__DisplayPattern
            {
                public static class Types
                {
                    public class FinderInfo : CreateMarketingBusifavorStockRequest.Types.DisplayPattern.Types.FinderInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置视频号信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finder_info")]
                [System.Text.Json.Serialization.JsonPropertyName("finder_info")]
                public Types.FinderInfo? FinderInfo { get; set; }
            }

            public class NotifyConfig : CreateMarketingBusifavorStockRequest.Types.NotifyConfig
            {
            }

            public class CouponCodeInformation
            {
                /// <summary>
                /// 获取或设置该批次总共已上传的 Code 总数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置该批次当前可用的 Code 数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available_count")]
                [System.Text.Json.Serialization.JsonPropertyName("available_count")]
                public int AvailableCount { get; set; }
            }

            public class CouponSendInformation
            {
                /// <summary>
                /// 获取或设置已发放券张数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_send_num")]
                [System.Text.Json.Serialization.JsonPropertyName("total_send_num")]
                public int? TotalSendCount { get; set; }

                /// <summary>
                /// 获取或设置已发放券金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_send_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("total_send_amount")]
                public long? TotalSendAmount { get; set; }

                /// <summary>
                /// 获取或设置单天已发放券张数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("today_send_num")]
                [System.Text.Json.Serialization.JsonPropertyName("today_send_num")]
                public int? TodaySendCount { get; set; }

                /// <summary>
                /// 获取或设置单天已发放券金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("today_send_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("today_send_amount")]
                public long? TodaySendAmount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置批次 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string? StockId { get; set; }

        /// <summary>
        /// 获取或设置批次名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_name")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_name")]
        public string? StockName { get; set; }

        /// <summary>
        /// 获取或设置批次类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_type")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_type")]
        public string? StockType { get; set; }

        /// <summary>
        /// 获取或设置批次状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_state")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_state")]
        public string? StockState { get; set; }

        /// <summary>
        /// 获取或设置批次归属商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("belong_merchant")]
        [System.Text.Json.Serialization.JsonPropertyName("belong_merchant")]
        public string? BelongMerchantId { get; set; }

        /// <summary>
        /// 获取或设置发放规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_send_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_send_rule")]
        public Types.StockSendRule? StockSendRule { get; set; }

        /// <summary>
        /// 获取或设置核销规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_use_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_use_rule")]
        public Types.CouponUseRule? CouponUseRule { get; set; }

        /// <summary>
        /// 获取或设置自定义入口信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_entrance")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_entrance")]
        public Types.CustomEntrance? CustomEntrance { get; set; }

        /// <summary>
        /// 获取或设置样式设置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("display_pattern_info")]
        [System.Text.Json.Serialization.JsonPropertyName("display_pattern_info")]
        public Types.DisplayPattern? DisplayPattern { get; set; }

        /// <summary>
        /// 获取或设置事件通知配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_config")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_config")]
        public Types.NotifyConfig? NotifyConfig { get; set; }

        /// <summary>
        /// 获取或设置商家券 Code 数量信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_code_count")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_code_count")]
        public Types.CouponCodeInformation? CouponCodeInformation { get; set; }

        /// <summary>
        /// 获取或设置批次发放情况信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_count_information")]
        [System.Text.Json.Serialization.JsonPropertyName("send_count_information")]
        public Types.CouponSendInformation? CouponSendInformation { get; set; }

        /// <summary>
        /// 获取或设置适用商品范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_name")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
        public string? GoodsName { get; set; }

        /// <summary>
        /// 获取或设置商家券 Code 模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_code_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_code_mode")]
        public string? CouponCodeMode { get; set; }

        /// <summary>
        /// 获取或设置批次备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment")]
        [System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
