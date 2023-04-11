using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Events
{
    /// <summary>
    /// <para>表示 mse_refund.succeeded 通知的数据。</para>
    /// </summary>
    public class RefundEvent : WechatTenpayBusinessEvent<RefundEvent.Types.EventContent>
    {
        public static class Types
        {
            public class EventContent
            {
                /// <summary>
                /// 获取或设置平台退款单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_refund_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_refund_id")]
                public string OutRefundId { get; set; } = default!;

                /// <summary>
                /// 获取或设置微企付退款单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_id")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
                public string RefundId { get; set; } = default!;

                /// <summary>
                /// 获取或设置平台支付单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_payment_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_payment_id")]
                public string OutPaymentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置微企付支付单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payment_id")]
                [System.Text.Json.Serialization.JsonPropertyName("payment_id")]
                public string PaymentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置原支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                public int TotalAmount { get; set; }

                /// <summary>
                /// 获取或设置退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                public int RefundAmount { get; set; }

                /// <summary>
                /// 获取或设置退款原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_reason")]
                public string? RefundReason { get; set; }

                /// <summary>
                /// 获取或设置退款状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款成功时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("succeeded_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("succeeded_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                public DateTimeOffset? SucceedTime { get; set; }

                /// <summary>
                /// 获取或设置退款创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("created_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("created_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }
            }
        }
    }
}
