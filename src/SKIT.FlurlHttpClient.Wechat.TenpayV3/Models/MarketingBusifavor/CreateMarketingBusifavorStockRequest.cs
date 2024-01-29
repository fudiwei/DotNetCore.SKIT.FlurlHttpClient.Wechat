using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/busifavor/stocks 接口的请求。</para>
    /// </summary>
    public class CreateMarketingBusifavorStockRequest : WechatTenpayRequest
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
                public int? MaxCoupons { get; set; }

                /// <summary>
                /// 获取或设置单个用户可领个数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_coupons_per_user")]
                [System.Text.Json.Serialization.JsonPropertyName("max_coupons_per_user")]
                public int? MaxCouponsPerUser { get; set; }

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

            public class CouponUseRule
            {
                public static class Types
                {
                    public class CouponAvailableTime
                    {
                        public static class Types
                        {
                            public class AvailableWeek
                            {
                                public static class Types
                                {
                                    public class AvailableTimeRange
                                    {
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
                                /// 获取或设置可用星期数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("week_day")]
                                [System.Text.Json.Serialization.JsonPropertyName("week_day")]
                                public IList<int> WeekDayList { get; set; } = new List<int>();

                                /// <summary>
                                /// 获取或设置当天可用时间段。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("available_day_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("available_day_time")]
                                public IList<Types.AvailableTimeRange>? AvailableTimeRangeList { get; set; }
                            }

                            public class AvailableTime
                            {
                                /// <summary>
                                /// 获取或设置开始时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("begin_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                                public DateTimeOffset? BeginTime { get; set; }

                                /// <summary>
                                /// 获取或设置结束时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                                public DateTimeOffset? EndTime { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置批次开始时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("available_begin_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("available_begin_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                        public DateTimeOffset AvailableBeginTime { get; set; }

                        /// <summary>
                        /// 获取或设置批次结束时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("available_end_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("available_end_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                        public DateTimeOffset AvailableEndTime { get; set; }

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
                        public IList<Types.AvailableTime>? IrregularyAvailableTimeList { get; set; }

                        /// <summary>
                        /// 获取或设置生效后 N 天内有效。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("available_day_after_receive")]
                        [System.Text.Json.Serialization.JsonPropertyName("available_day_after_receive")]
                        public int? AvailableDaysAfterReceive { get; set; }

                        /// <summary>
                        /// 获取或设置领取后 N 天开始生效。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wait_days_after_receive")]
                        [System.Text.Json.Serialization.JsonPropertyName("wait_days_after_receive")]
                        public int? WaitDaysAfterReceive { get; set; }
                    }

                    public class NormalCoupon
                    {
                        /// <summary>
                        /// 获取或设置优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
                        public int DiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置消费门槛（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_minimum")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_minimum")]
                        public int TransactionMinimum { get; set; }
                    }

                    public class DiscountCoupon
                    {
                        /// <summary>
                        /// 获取或设置折扣比例（范围：1～99）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_percent")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_percent")]
                        public int DiscountPercent { get; set; }

                        /// <summary>
                        /// 获取或设置消费门槛（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_minimum")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_minimum")]
                        public int TransactionMinimum { get; set; }
                    }

                    public class ExchangeCoupon
                    {
                        /// <summary>
                        /// 获取或单品换购价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exchange_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("exchange_price")]
                        public int ExchangePrice { get; set; }

                        /// <summary>
                        /// 获取或设置消费门槛（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_minimum")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_minimum")]
                        public int TransactionMinimum { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置券生效时间信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_available_time")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_available_time")]
                public Types.CouponAvailableTime? CouponAvailableTime { get; set; }

                /// <summary>
                /// 获取或设置固定面额满减券使用规则信息。与字段 <see cref="DiscountCoupon"/>、<see cref="ExchangeCoupon"/> 三选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fixed_normal_coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("fixed_normal_coupon")]
                public Types.NormalCoupon? NormalCoupon { get; set; }

                /// <summary>
                /// 获取或设置折扣券使用规则信息。与字段 <see cref="NormalCoupon"/>、<see cref="ExchangeCoupon"/> 三选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_coupon")]
                public Types.DiscountCoupon? DiscountCoupon { get; set; }

                /// <summary>
                /// 获取或设置换购券使用规则信息。与字段 <see cref="NormalCoupon"/>、<see cref="DiscountCoupon"/> 三选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exchange_coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("exchange_coupon")]
                public Types.ExchangeCoupon? ExchangeCoupon { get; set; }

                /// <summary>
                /// 获取或设置核销方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("use_method")]
                [System.Text.Json.Serialization.JsonPropertyName("use_method")]
                public string UseMethod { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商家小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mini_programs_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("mini_programs_appid")]
                public string? MiniProgramAppId { get; set; }

                /// <summary>
                /// 获取或设置商家小程序路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mini_programs_path")]
                [System.Text.Json.Serialization.JsonPropertyName("mini_programs_path")]
                public string? MiniProgramPath { get; set; }
            }

            public class CustomEntrance
            {
                public static class Types
                {
                    public class MiniProgram
                    {
                        /// <summary>
                        /// 获取或设置商家小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mini_programs_appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("mini_programs_appid")]
                        public string AppId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商家小程序路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mini_programs_path")]
                        [System.Text.Json.Serialization.JsonPropertyName("mini_programs_path")]
                        public string Path { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置入口文案。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("entrance_words")]
                        [System.Text.Json.Serialization.JsonPropertyName("entrance_words")]
                        public string EntranceWords { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置引导文案。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("guiding_words")]
                        [System.Text.Json.Serialization.JsonPropertyName("guiding_words")]
                        public string? GuidingWords { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商家小程序入口信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mini_programs_info")]
                [System.Text.Json.Serialization.JsonPropertyName("mini_programs_info")]
                public Types.MiniProgram? MiniProgram { get; set; }

                /// <summary>
                /// 获取或设置商家公众号 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string? AppId { get; set; }

                /// <summary>
                /// 获取或设置营销馆 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hall_id")]
                [System.Text.Json.Serialization.JsonPropertyName("hall_id")]
                public string? HallId { get; set; }

                /// <summary>
                /// 获取或设置可用门店 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_id")]
                [System.Text.Json.Serialization.JsonPropertyName("store_id")]
                public string? StoreId { get; set; }

                /// <summary>
                /// 获取或设置展示模式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code_display_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("code_display_mode")]
                public string? CodeDisplayMode { get; set; }
            }

            public class DisplayPattern
            {
                public static class Types
                {
                    public class Finder
                    {
                        /// <summary>
                        /// 获取或设置视频号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("finder_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
                        public string? FinderId { get; set; }

                        /// <summary>
                        /// 获取或设置视频封面图片媒体文件地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("finder_video_cover_image_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("finder_video_cover_image_url")]
                        public string? FinderVideoCoverImageMediaUrl { get; set; }

                        /// <summary>
                        /// 获取或设置视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("finder_video_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("finder_video_id")]
                        public string? FinderVideoId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置使用须知。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置品牌 Logo 媒体文件地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_logo_url")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_logo_url")]
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
                [Newtonsoft.Json.JsonProperty("coupon_image_url")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_image_url")]
                public string? CouponImageMediaUrl { get; set; }

                /// <summary>
                /// 获取或设置视频号信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finder_info")]
                [System.Text.Json.Serialization.JsonPropertyName("finder_info")]
                public Types.Finder? Finder { get; set; }
            }

            public class NotifyConfig
            {
                /// <summary>
                /// 获取或设置事件通知 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notify_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("notify_appid")]
                public string? NotifyAppId { get; set; }
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
        /// 获取或设置发放规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_send_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_send_rule")]
        public Types.StockSendRule StockSendRule { get; set; } = new Types.StockSendRule();

        /// <summary>
        /// 获取或设置核销规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_use_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_use_rule")]
        public Types.CouponUseRule CouponUseRule { get; set; } = new Types.CouponUseRule();

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
        /// 获取或设置适用商品范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_name")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
        public string GoodsName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商家券 Code 模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_code_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_code_mode")]
        public string CouponCodeMode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否允许营销补贴。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subsidy")]
        [System.Text.Json.Serialization.JsonPropertyName("subsidy")]
        public bool? AllowSubsidy { get; set; }

        /// <summary>
        /// 获取或设置批次备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment")]
        [System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
