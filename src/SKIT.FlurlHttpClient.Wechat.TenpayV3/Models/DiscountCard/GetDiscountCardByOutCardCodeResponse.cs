using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /discount-card/cards/{out_card_code} 接口的响应。</para>
    /// </summary>
    public class GetDiscountCardByOutCardCodeResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class TimeRange
            {
                /// <summary>
                /// 获取或设置约定开始时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset BeginTime { get; set; }

                /// <summary>
                /// 获取或设置约定结束时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset EndTime { get; set; }
            }

            public class Payment
            {
                /// <summary>
                /// 获取或设置付款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                public int PayAmount { get; set; }

                /// <summary>
                /// 获取或设置付款状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_state")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_state")]
                public string PayState { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信支付订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_id")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                public string? TransactionId { get; set; }

                /// <summary>
                /// 获取或设置支付时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                public DateTimeOffset? PayTime { get; set; }
            }

            public class Objective
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
                        public string SerialNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置目标 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("objective_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("objective_id")]
                        public string ObjectiveId { get; set; } = default!;

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
                        public string CompletionType { get; set; } = default!;

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
                        public string? Description { get; set; }

                        /// <summary>
                        /// 获取或设置备注说明。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remark")]
                        [System.Text.Json.Serialization.JsonPropertyName("remark")]
                        public string? Remark { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置目标 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("objective_id")]
                [System.Text.Json.Serialization.JsonPropertyName("objective_id")]
                public string ObjectiveId { get; set; } = default!;

                /// <summary>
                /// 获取或设置目标名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置目标数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int Count { get; set; }

                /// <summary>
                /// 获取或设置目标单位。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unit")]
                [System.Text.Json.Serialization.JsonPropertyName("unit")]
                public string Unit { get; set; } = default!;

                /// <summary>
                /// 获取或设置目标描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置目标完成记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("objective_completion_records")]
                [System.Text.Json.Serialization.JsonPropertyName("objective_completion_records")]
                public Types.CompletionRecord[]? CompletionRecordList { get; set; }
            }

            public class Reward
            {
                public static class Types
                {
                    public class UsageRecord
                    {
                        /// <summary>
                        /// 获取或设置优惠使用记录流水号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reward_usage_serial_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("reward_usage_serial_no")]
                        public string SerialNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置优惠 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reward_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("reward_id")]
                        public string RewardId { get; set; } = default!;

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
                        public string UsageType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置优惠使用数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("usage_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("usage_count")]
                        public int UsageCount { get; set; }

                        /// <summary>
                        /// 获取或设置优惠金额（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int Amount { get; set; }

                        /// <summary>
                        /// 获取或设置优惠使用描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string? Description { get; set; }

                        /// <summary>
                        /// 获取或设置备注说明。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remark")]
                        [System.Text.Json.Serialization.JsonPropertyName("remark")]
                        public string? Remark { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置优惠 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reward_id")]
                [System.Text.Json.Serialization.JsonPropertyName("reward_id")]
                public string RewardId { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠数量类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count_type")]
                [System.Text.Json.Serialization.JsonPropertyName("count_type")]
                public string CountType { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int Count { get; set; }

                /// <summary>
                /// 获取或设置优惠单位。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unit")]
                [System.Text.Json.Serialization.JsonPropertyName("unit")]
                public string Unit { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置优惠描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置优惠使用记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reward_usage_records")]
                [System.Text.Json.Serialization.JsonPropertyName("reward_usage_records")]
                public Types.UsageRecord[]? UsageRecordList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户领卡号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_card_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_card_code")]
        public string OutCardCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置先享卡模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_template_id")]
        public string CardTemplateId { get; set; } = default!;

        /// <summary>
        /// 获取或设置先享卡 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置约定时间期限信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_range")]
        [System.Text.Json.Serialization.JsonPropertyName("time_range")]
        public Types.TimeRange TimeRange { get; set; } = default!;

        /// <summary>
        /// 获取或设置状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置未完成约定原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unfinished_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("unfinished_reason")]
        public string? UnfinishedReason { get; set; }

        /// <summary>
        /// 获取或设置享受优惠总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        public int? TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置用户退回优惠的付款信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_information")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_information")]
        public Types.Payment? Payment { get; set; }

        /// <summary>
        /// 获取或设置目标列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("objectives")]
        [System.Text.Json.Serialization.JsonPropertyName("objectives")]
        public Types.Objective[] Objectives { get; set; } = default!;

        /// <summary>
        /// 获取或设置优惠列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rewards")]
        [System.Text.Json.Serialization.JsonPropertyName("rewards")]
        public Types.Reward[] Rewards { get; set; } = default!;

        /// <summary>
        /// 获取或设置邀请者用户标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_openid")]
        public string? SharerOpenId { get; set; }

        /// <summary>
        /// 获取或设置创卡时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }
    }
}
