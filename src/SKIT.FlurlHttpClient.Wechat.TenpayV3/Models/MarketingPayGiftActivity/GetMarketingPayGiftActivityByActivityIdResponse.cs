namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/paygiftactivity/activities/{activity_id} 接口的响应。</para>
    /// </summary>
    public class GetMarketingPayGiftActivityByActivityIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class ActivityBase : CreateMarketingPayGiftActivityUniqueThresholdActivityRequest.Types.__zz__ActivityBase
            {
                public static class Types
                {
                    public class AvailablePeriods
                    {
                        public static class Types
                        {
                            public class AvailableTime : CreateMarketingPayGiftActivityUniqueThresholdActivityRequest.Types.ActivityBase.Types.AvailablePeriods.Types.AvailableTime
                            {
                            }

                            public class AvailableDayTime : CreateMarketingPayGiftActivityUniqueThresholdActivityRequest.Types.ActivityBase.Types.AvailablePeriods.Types.AvailableDayTime
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置可用时间列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("available_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("available_time")]
                        public List<Types.AvailableTime>? AvailableTimeList { get; set; }

                        /// <summary>
                        /// 获取或设置每日可用时间列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("available_day_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("available_day_time")]
                        public List<Types.AvailableDayTime>? AvailableDayTimeList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置可用时间段信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available_periods")]
                [System.Text.Json.Serialization.JsonPropertyName("available_periods")]
                public Types.AvailablePeriods? AvailablePeriods { get; set; }
            }

            public class AwardSendRule
            {
                public static class Types
                {
                    public class FullSendRule : CreateMarketingPayGiftActivityUniqueThresholdActivityRequest.Types.__zz__AwardSendRule
                    {
                        public static class Types
                        {
                            public class Award : CreateMarketingPayGiftActivityUniqueThresholdActivityRequest.Types.AwardSendRule.Types.Award
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置奖品基本信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("award_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("award_list")]
                        public List<Types.Award>? AwardList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置满送活动奖品发放规则选项。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("full_send_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("full_send_rule")]
                public Types.FullSendRule? FullSendRule { get; set; }
            }

            public class AdvancedSetting : CreateMarketingPayGiftActivityUniqueThresholdActivityRequest.Types.AdvancedSetting
            {
            }
        }

        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public string? ActivityId { get; set; }

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
        /// 获取或设置创建商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creator_merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("creator_merchant_id")]
        public string? CreatorMerchantId { get; set; }

        /// <summary>
        /// 获取或设置所属商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("belong_merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("belong_merchant_id")]
        public string? BelongMerchantId { get; set; }

        /// <summary>
        /// 获取或设置活动基本信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_base_info")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_base_info")]
        public Types.ActivityBase? ActivityBase { get; set; }

        /// <summary>
        /// 获取或设置活动奖品发放规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("award_send_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("award_send_rule")]
        public Types.AwardSendRule? AwardSendRule { get; set; }

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
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pause_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? PauseTime { get; set; }

        /// <summary>
        /// 获取或设置活动恢复时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recovery_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("recovery_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? RecoveryTime { get; set; }

        /// <summary>
        /// 获取或设置活动创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置活动更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset UpdateTime { get; set; }
    }
}
