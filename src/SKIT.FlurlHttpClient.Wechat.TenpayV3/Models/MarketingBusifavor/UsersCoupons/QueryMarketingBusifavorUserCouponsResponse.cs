namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/busifavor/users/{openid}/coupons 接口的响应。</para>
    /// </summary>
    public class QueryMarketingBusifavorUserCouponsResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Coupon
            {
                public static class Types
                {
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
                }

                /// <summary>
                /// 获取或设置商家券 Code。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_code")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_code")]
                public string? CouponCode { get; set; }

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
                /// 获取或设置券状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_state")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_state")]
                public string? CouponState { get; set; }

                /// <summary>
                /// 获取或设置批次归属商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("belong_merchant")]
                [System.Text.Json.Serialization.JsonPropertyName("belong_merchant")]
                public string? BelongMerchantId { get; set; }

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

                /// <summary>
                /// 获取或设置券核销规则信息。
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
                /// 获取或设置适用商品范围。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_name")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
                public string? GoodsName { get; set; }

                /// <summary>
                /// 获取或设置批次备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comment")]
                [System.Text.Json.Serialization.JsonPropertyName("comment")]
                public string? Comment { get; set; }

                /// <summary>
                /// 获取或设置券可使用开始时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available_start_time")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("available_start_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset AvailableStartTime { get; set; }

                /// <summary>
                /// 获取或设置券过期时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset ExpireTime { get; set; }

                /// <summary>
                /// 获取或设置领券时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receive_time")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("receive_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset ReceiveTime { get; set; }

                /// <summary>
                /// 获取或设置发券时商户请求单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_request_no")]
                [System.Text.Json.Serialization.JsonPropertyName("send_request_no")]
                public string? SendOutRequestNumber { get; set; }

                /// <summary>
                /// 获取或设置核销时商户请求单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("use_request_no")]
                [System.Text.Json.Serialization.JsonPropertyName("use_request_no")]
                public string? UseOutRequestNumber { get; set; }

                /// <summary>
                /// 获取或设置核销请求时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("use_time")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("use_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset? UseTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public List<Types.Coupon>? CouponList { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置券总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
