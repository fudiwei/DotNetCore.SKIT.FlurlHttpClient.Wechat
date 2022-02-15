using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/paygiftactivity/activities/{activity_id} 接口的响应。</para>
    /// </summary>
    public class GetMarketingPayGiftActivityByActivityIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class ActivityBase
            {
                public static class Types
                {
                    public class AvailablePeriods
                    {
                        public static class Types
                        {
                            public class AvailableTime
                            {
                                /// <summary>
                                /// 获取或设置开始时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("begin_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                                public DateTimeOffset BeginTime { get; set; }

                                /// <summary>
                                /// 获取或设置结束时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                                public DateTimeOffset EndTime { get; set; }
                            }

                            public class AvailableDayTime
                            {
                                /// <summary>
                                /// 获取或设置每日可用开始时间（格式：HHmmss）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("begin_day_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("begin_day_time")]
                                public string BeginDayTimeString { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置每日可用结束时间（格式：HHmmss）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_day_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("end_day_time")]
                                public string EndDayTimeString { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置可用时间列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("available_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("available_time")]
                        public Types.AvailableTime[]? AvailableTimeList { get; set; }

                        /// <summary>
                        /// 获取或设置每日可用时间列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("available_day_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("available_day_time")]
                        public Types.AvailableDayTime[]? AvailableDayTimeList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置活动名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_name")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_name")]
                public string ActivityName { get; set; } = default!;

                /// <summary>
                /// 获取或设置活动副标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_second_title")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_second_title")]
                public string ActivitySecondTitle { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户请求单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_request_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
                public string OutRequestNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置品牌 Logo 媒体文件地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_logo_url")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_logo_url")]
                public string MerchantLogoMediaUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置背景颜色。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("background_color")]
                [System.Text.Json.Serialization.JsonPropertyName("background_color")]
                public string? BackgroundColor { get; set; }

                /// <summary>
                /// 获取或设置活动开始时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset BeginTime { get; set; }

                /// <summary>
                /// 获取或设置活动结束时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset EndTime { get; set; }

                /// <summary>
                /// 获取或设置可用时间段信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available_periods")]
                [System.Text.Json.Serialization.JsonPropertyName("available_periods")]
                public Types.AvailablePeriods? AvailablePeriods { get; set; }

                /// <summary>
                /// 获取或设置投放目的。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_purpose")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_purpose")]
                public string DeliveryPurpose { get; set; } = default!;

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

            public class AwardSendRule
            {
                public static class Types
                {
                    public class FullSendRule
                    {
                        public static class Types
                        {
                            public class Award
                            {
                                /// <summary>
                                /// 获取或设置批次号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("stock_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
                                public string StockId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置奖品原始图媒体文件地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("original_image_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("original_image_url")]
                                public string OriginalImageMediaUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置奖品缩略图媒体文件地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("thumbnail_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
                                public string? ThumbnailMediaUrl { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置消费金额门槛（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_amount_minimum")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_amount_minimum")]
                        public int TransactionAmountMinimum { get; set; }

                        /// <summary>
                        /// 获取或设置发放内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("send_content")]
                        [System.Text.Json.Serialization.JsonPropertyName("send_content")]
                        public string SendContent { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置奖品类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("award_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("award_type")]
                        public string AwardType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置奖品基本信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("award_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("award_list")]
                        public Types.Award[]? AwardList { get; set; }

                        /// <summary>
                        /// 获取或设置发券商户号选项。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_option")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_option")]
                        public string MerchantOption { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置发券商户号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_id_list")]
                        public string[]? MerchantIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置满送活动奖品发放规则选项。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("full_send_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("full_send_rule")]
                public Types.FullSendRule FullSendRule { get; set; } = default!;
            }

            public class AdvancedSetting
            {
                /// <summary>
                /// 获取或设置投放用户类别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_user_category")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_user_category")]
                public string? DeliveryUserCategory { get; set; }

                /// <summary>
                /// 获取或设置商家会员 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_member_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_member_appid")]
                public string? MerchantMemberAppId { get; set; }

                /// <summary>
                /// 获取或设置订单优惠标记。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_tags")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_tags")]
                public string[]? GoodsTagList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public string ActivityId { get; set; } = default!;

        /// <summary>
        /// 获取或设置活动类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_type")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_type")]
        public string? ActivityType { get; set; }

        /// <summary>
        /// 获取或设置活动状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_status")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_status")]
        public string ActivityStatus { get; set; } = default!;

        /// <summary>
        /// 获取或设置创建商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creator_merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("creator_merchant_id")]
        public string CreatorMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置所属商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("belong_merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("belong_merchant_id")]
        public string BelongMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置活动基本信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_base_info")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_base_info")]
        public Types.ActivityBase ActivityBase { get; set; } = default!;

        /// <summary>
        /// 获取或设置活动奖品发放规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("award_send_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("award_send_rule")]
        public Types.AwardSendRule AwardSendRule { get; set; } = default!;

        /// <summary>
        /// 获取或设置活动高级设置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advanced_setting")]
        [System.Text.Json.Serialization.JsonPropertyName("advanced_setting")]
        public Types.AdvancedSetting? AdvancedSetting { get; set; }

        /// <summary>
        /// 获取或设置活动暂停时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pause_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pause_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? PauseTime { get; set; }

        /// <summary>
        /// 获取或设置活动恢复时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recovery_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("recovery_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? RecoveryTime { get; set; }

        /// <summary>
        /// 获取或设置活动创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置活动更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset UpdateTime { get; set; }
    }
}
