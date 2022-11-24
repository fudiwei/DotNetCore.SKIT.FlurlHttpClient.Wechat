using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /discount-card/cards/{out_card_code}/add-user-records 接口的请求。</para>
    /// </summary>
    public class AddDiscountCardUserRecordRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class CompletionRecord
            {
                /// <summary>
                /// 获取或设置目标完成流水号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("objective_completion_serial_no")]
                [System.Text.Json.Serialization.JsonPropertyName("objective_completion_serial_no")]
                public string SerialNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置目标 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("objective_id")]
                [System.Text.Json.Serialization.JsonPropertyName("objective_id")]
                public string ObjectiveId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置目标完成时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("completion_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("completion_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset CompletionTime { get; set; }

                /// <summary>
                /// 获取或设置目标完成类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("completion_type")]
                [System.Text.Json.Serialization.JsonPropertyName("completion_type")]
                public string CompletionType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置目标完成数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("completion_count")]
                [System.Text.Json.Serialization.JsonPropertyName("completion_count")]
                public int CompletionCount { get; set; }

                /// <summary>
                /// 获取或设置目标完成描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置备注说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }
            }


            public class UsageRecord
            {
                /// <summary>
                /// 获取或设置优惠使用记录流水号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reward_usage_serial_no")]
                [System.Text.Json.Serialization.JsonPropertyName("reward_usage_serial_no")]
                public string SerialNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置优惠 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reward_id")]
                [System.Text.Json.Serialization.JsonPropertyName("reward_id")]
                public string RewardId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置优惠使用时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("usage_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("usage_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset UsageTime { get; set; }

                /// <summary>
                /// 获取或设置优惠使用类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("usage_type")]
                [System.Text.Json.Serialization.JsonPropertyName("usage_type")]
                public string UsageType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置优惠使用数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("usage_count")]
                [System.Text.Json.Serialization.JsonPropertyName("usage_count")]
                public int UsageCount { get; set; }

                /// <summary>
                /// 获取或设置优惠金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置优惠使用描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置备注说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商户领卡号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutCardCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置先享卡模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_template_id")]
        public string CardTemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置目标完成记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("objective_completion_records")]
        [System.Text.Json.Serialization.JsonPropertyName("objective_completion_records")]
        public IList<Types.CompletionRecord> CompletionRecordList { get; set; } = new List<Types.CompletionRecord>();

        /// <summary>
        /// 获取或设置优惠使用记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reward_usage_records")]
        [System.Text.Json.Serialization.JsonPropertyName("reward_usage_records")]
        public IList<Types.UsageRecord> UsageRecordList { get; set; } = new List<Types.UsageRecord>();
    }
}
