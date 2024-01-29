using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/favor/coupon-stocks 接口的请求。</para>
    /// </summary>
    public class CreateMarketingFavorStockRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class StockUseRule
            {
                /// <summary>
                /// 获取或设置发放总上限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_coupons")]
                [System.Text.Json.Serialization.JsonPropertyName("max_coupons")]
                public int? MaxCoupons { get; set; }

                /// <summary>
                /// 获取或设置发放总预算（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("max_amount")]
                public long? MaxAmount { get; set; }

                /// <summary>
                /// 获取或设置单天预算发放上限（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_amount_by_day")]
                [System.Text.Json.Serialization.JsonPropertyName("max_amount_by_day")]
                public long? MaxAmountPerDay { get; set; }

                /// <summary>
                /// 获取或设置单个用户可领个数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_coupons_per_user")]
                [System.Text.Json.Serialization.JsonPropertyName("max_coupons_per_user")]
                public int? MaxCouponsPerUser { get; set; }

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
            }

            public class CouponUseRule
            {
                public static class Types
                {
                    public class CouponAvailableTime
                    {
                        public static class Types
                        {
                            public class AvailableTime
                            {
                                /// <summary>
                                /// 获取或设置可用星期数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("available_week_day")]
                                [System.Text.Json.Serialization.JsonPropertyName("available_week_day")]
                                public int? AvailableWeekDay { get; set; }

                                /// <summary>
                                /// 获取或设置当天开始时间（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("begin_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                                public int? BeginTimeSeconds { get; set; }

                                /// <summary>
                                /// 获取或设置当天结束时间（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                public int? EndTimeSeconds { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置固定时间段可用信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fix_available_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("fix_available_time")]
                        public Types.AvailableTime? FixedAvailableTime { get; set; }

                        /// <summary>
                        /// 获取或设置是否领取后 N 天有效。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_day_available")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_day_available")]
                        public bool? IsSecondDayAvailable { get; set; }

                        /// <summary>
                        /// 获取或设置领取后有效时间（单位：分钟）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("available_time_after_receive")]
                        [System.Text.Json.Serialization.JsonPropertyName("available_time_after_receive")]
                        public int? AvailableMinutesAfterReceive { get; set; }
                    }

                    public class NormalCoupon
                    {
                        /// <summary>
                        /// 获取或设置券面额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_amount")]
                        public int CouponAmount { get; set; }

                        /// <summary>
                        /// 获取或设置使用门槛（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_minimum")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_minimum")]
                        public int TransactionMinimum { get; set; }
                    }

                    public class LimitCard
                    {
                        /// <summary>
                        /// 获取或设置银行卡名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置指定卡 BIN 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bin")]
                        [System.Text.Json.Serialization.JsonPropertyName("bin")]
                        public IList<string>? BinList { get; set; }
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
                /// 获取或设置订单优惠标记列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_tag")]
                public IList<string>? GoodsTagList { get; set; }

                /// <summary>
                /// 获取或设置指定付款方式编码列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limit_pay")]
                [System.Text.Json.Serialization.JsonPropertyName("limit_pay")]
                public IList<string>? LimitPayCodeList { get; set; }

                /// <summary>
                /// 获取或设置指定银行卡信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limit_card")]
                [System.Text.Json.Serialization.JsonPropertyName("limit_card")]
                public Types.LimitCard? LimitCard { get; set; }

                /// <summary>
                /// 获取或设置指定支付方式列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_type")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_type")]
                public IList<string>? TradeTypeList { get; set; }

                /// <summary>
                /// 获取或设置是否可叠加其他优惠。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("combine_use")]
                [System.Text.Json.Serialization.JsonPropertyName("combine_use")]
                public bool? AllowCombineUse { get; set; }

                /// <summary>
                /// 获取或设置可核销商品编码列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available_items")]
                [System.Text.Json.Serialization.JsonPropertyName("available_items")]
                public IList<string>? AvailableItems { get; set; }

                /// <summary>
                /// 获取或设置不可核销商品编码列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unavailable_items")]
                [System.Text.Json.Serialization.JsonPropertyName("unavailable_items")]
                public IList<string>? UnavailableItems { get; set; }

                /// <summary>
                /// 获取或设置可用商户号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available_merchants")]
                [System.Text.Json.Serialization.JsonPropertyName("available_merchants")]
                public IList<string>? AvailableMerchantIdList { get; set; }
            }

            public class Pattern
            {
                /// <summary>
                /// 获取或设置使用说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置品牌 Logo 媒体文件地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_logo")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_logo")]
                public string? MerchantLogoMediaUrl { get; set; }

                /// <summary>
                /// 获取或设置品牌名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_name")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
                public string? MerchantName { get; set; }

                /// <summary>
                /// 获取或设置背景颜色。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("background_color")]
                [System.Text.Json.Serialization.JsonPropertyName("background_color")]
                public string? BackgroundColor { get; set; }

                /// <summary>
                /// 获取或设置券详情图片媒体文件地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_image")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_image")]
                public string? CouponImageMediaUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置批次名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_name")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_name")]
        public string StockName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置批次类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_type")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_type")]
        public string StockType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户单据号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置批次归属商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("belong_merchant")]
        [System.Text.Json.Serialization.JsonPropertyName("belong_merchant")]
        public string? BelongMerchantId { get; set; }

        /// <summary>
        /// 获取或设置可用开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_begin_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("available_begin_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset AvailableBeginTime { get; set; }

        /// <summary>
        /// 获取或设置可用结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("available_end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset AvailableEndTime { get; set; }

        /// <summary>
        /// 获取或设置发放规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_use_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_use_rule")]
        public Types.StockUseRule StockUseRule { get; set; } = new Types.StockUseRule();

        /// <summary>
        /// 获取或设置核销规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_use_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_use_rule")]
        public Types.CouponUseRule CouponUseRule { get; set; } = new Types.CouponUseRule();

        /// <summary>
        /// 获取或设置样式设置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pattern_info")]
        [System.Text.Json.Serialization.JsonPropertyName("pattern_info")]
        public Types.Pattern? Pattern { get; set; }

        /// <summary>
        /// 获取或设置是否无资金流。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("no_cash")]
        [System.Text.Json.Serialization.JsonPropertyName("no_cash")]
        public bool IsNoCash { get; set; }

        /// <summary>
        /// 获取或设置批次备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment")]
        [System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 获取或设置扩展属性。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        [System.Text.Json.Serialization.JsonPropertyName("ext_info")]
        public string? Extdata { get; set; }
    }
}
