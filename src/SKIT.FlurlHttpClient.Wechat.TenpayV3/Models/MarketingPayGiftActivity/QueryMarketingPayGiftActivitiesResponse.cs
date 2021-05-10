using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/paygiftactivity/activities 接口的响应。</para>
    /// </summary>
    public class QueryMarketingPayGiftActivitiesResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Activity
            {
                public static class Types
                {
                    public class ActivityBaseInformation : GetMarketingPayGiftActivityByActivityIdResponse.Types.ActivityBaseInformation
                    {
                    }

                    public class AwardSendRule : GetMarketingPayGiftActivityByActivityIdResponse.Types.AwardSendRule
                    {
                    }

                    public class AdvancedSetting : GetMarketingPayGiftActivityByActivityIdResponse.Types.AdvancedSetting
                    {
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
                public Types.ActivityBaseInformation ActivityBaseInformation { get; set; } = default!;

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

        /// <summary>
        /// 获取或设置活动列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Activity[] ActivityList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置活动总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
