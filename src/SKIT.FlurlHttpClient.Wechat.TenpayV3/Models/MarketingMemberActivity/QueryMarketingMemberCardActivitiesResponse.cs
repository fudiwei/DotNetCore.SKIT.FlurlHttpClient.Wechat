using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/membercard-activity/activities 接口的响应。</para>
    /// </summary>
    public class QueryMarketingMemberCardActivitiesResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Activity
            {
                public static class Types
                {
                    public class AwardSendPeriod : GetMarketingMemberCardActivityByActivityIdResponse.Types.AwardSendPeriod
                    {
                    }

                    public class Stock : GetMarketingMemberCardActivityByActivityIdResponse.Types.Stock
                    {
                    }

                    public class PayActivitySetting : GetMarketingMemberCardActivityByActivityIdResponse.Types.PayActivitySetting
                    {
                    }

                    public class MiniProgramActivitySetting : GetMarketingMemberCardActivityByActivityIdResponse.Types.MiniProgramActivitySetting
                    {
                    }
                }

                /// <summary>
                /// 获取或设置会员卡 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_id")]
                [System.Text.Json.Serialization.JsonPropertyName("card_id")]
                public string CardId { get; set; } = default!;

                /// <summary>
                /// 获取或设置活动 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_id")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                public string ActivityId { get; set; } = default!;

                /// <summary>
                /// 获取或设置活动名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_name")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_name")]
                public string ActivityName { get; set; } = default!;

                /// <summary>
                /// 获取或设置活动类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_type")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_type")]
                public string ActivityType { get; set; } = default!;

                /// <summary>
                /// 获取或设置活动状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_status")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_status")]
                public string ActivityStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置活动开始时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                public DateTimeOffset? BeginTime { get; set; }

                /// <summary>
                /// 获取或设置活动结束时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
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
                public Types.Stock[]? StockList { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户请求单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_request_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
                public string OutRequestNumber { get; set; } = default!;

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
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset UpdateTime { get; set; }

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }
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
