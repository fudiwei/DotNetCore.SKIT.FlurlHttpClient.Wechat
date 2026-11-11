namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/membercard-activity/activities/{activity_id} 接口的响应。</para>
    /// </summary>
    public class GetMarketingMemberCardActivityByActivityIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class AwardSendPeriod
            {
                public static class Types
                {
                    public class AwardSendTime : CreateMarketingMemberCardActivityRequest.Types.AwardSendPeriod.Types.AwardSendTime
                    {
                    }

                    public class AwardSendDayTime
                    {
                        public static class Types
                        {
                            public class DayTime : CreateMarketingMemberCardActivityRequest.Types.AwardSendPeriod.Types.AwardSendDayTime.Types.DayTime
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置每日可用开始时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("begin_day_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("begin_day_time")]
                        public Types.DayTime? BeginDayTime { get; set; }

                        /// <summary>
                        /// 获取或设置每日可用结束时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_day_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_day_time")]
                        public Types.DayTime? EndDayTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置有效期内指定部分活动时间段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("award_send_time")]
                [System.Text.Json.Serialization.JsonPropertyName("award_send_time")]
                public List<Types.AwardSendTime>? AwardSendTimeList { get; set; }

                /// <summary>
                /// 获取或设置指定时间段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("award_send_day_time")]
                [System.Text.Json.Serialization.JsonPropertyName("award_send_day_time")]
                public List<Types.AwardSendDayTime>? AwardSendDayTimeList { get; set; }
            }

            public class Stock : CreateMarketingMemberCardActivityRequest.Types.Stock
            {
            }

            public class PayActivitySetting : CreateMarketingMemberCardActivityRequest.Types.__zz__PayActivitySetting
            {
                public static class Types
                {
                    public class ActivateSetting : CreateMarketingMemberCardActivityRequest.Types.PayActivitySetting.Types.__zz__ActivateSetting
                    {
                        public static class Types
                        {
                            public class MiniProgram : CreateMarketingMemberCardActivityRequest.Types.PayActivitySetting.Types.ActivateSetting.Types.MiniProgram
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置激活跳转的小程序信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activate_miniprogram")]
                        [System.Text.Json.Serialization.JsonPropertyName("activate_miniprogram")]
                        public Types.MiniProgram? ActivateMiniProgram { get; set; }
                    }

                    public class PaymentSetting : CreateMarketingMemberCardActivityRequest.Types.PayActivitySetting.Types.__zz__PaymentSetting
                    {
                        public static class Types
                        {
                            public class PaymentMode : CreateMarketingMemberCardActivityRequest.Types.PayActivitySetting.Types.PaymentSetting.Types.PaymentMode
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置限定支付模式信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payment_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("payment_mode")]
                        public Types.PaymentMode? LimitPaymentMode { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置激活方式设置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activate_setting")]
                [System.Text.Json.Serialization.JsonPropertyName("activate_setting")]
                public Types.ActivateSetting? ActivateSetting { get; set; }

                /// <summary>
                /// 获取或设置支付设置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payment_setting")]
                [System.Text.Json.Serialization.JsonPropertyName("payment_setting")]
                public Types.PaymentSetting? PaymentSetting { get; set; }
            }

            public class MiniProgramActivitySetting : CreateMarketingMemberCardActivityRequest.Types.__zz__MiniProgramActivitySetting
            {
                public static class Types
                {
                    public class AwardSetting : CreateMarketingMemberCardActivityRequest.Types.MiniProgramActivitySetting.Types.AwardSetting
                    {
                    }
                }

                /// <summary>
                /// 获取或设置领奖页面跳转配置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("award_jump_deploy")]
                [System.Text.Json.Serialization.JsonPropertyName("award_jump_deploy")]
                public Types.AwardSetting? AwardSetting { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会员卡 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string? CardId { get; set; }

        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public string? ActivityId { get; set; }

        /// <summary>
        /// 获取或设置活动名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_name")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_name")]
        public string? ActivityName { get; set; }

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
        public string? ActivityStatus { get; set; }

        /// <summary>
        /// 获取或设置活动开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? BeginTime { get; set; }

        /// <summary>
        /// 获取或设置活动结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// 获取或设置发放时间段信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("award_send_period")]
        [System.Text.Json.Serialization.JsonPropertyName("award_send_period")]
        public Types.AwardSendPeriod? AwardSendPeriod { get; set; }

        /// <summary>
        /// 获取或设置优惠券批次列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_list")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_list")]
        public List<Types.Stock>? StockList { get; set; }

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string? OutRequestNumber { get; set; }

        /// <summary>
        /// 获取或设置支付后活动设置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_activity_setting")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_activity_setting")]
        public Types.PayActivitySetting? PayActivitySetting { get; set; }

        /// <summary>
        /// 获取或设置支付前会员活动设置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram_activity_setting")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram_activity_setting")]
        public Types.MiniProgramActivitySetting? MiniProgramActivitySetting { get; set; }

        /// <summary>
        /// 获取或设置更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset UpdateTime { get; set; }

        /// <summary>
        /// 获取或设置创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }
    }
}
