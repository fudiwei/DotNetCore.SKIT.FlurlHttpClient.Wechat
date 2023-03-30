using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /hire-power-bank/insurance-orders/{out_order_no} 接口的响应。</para>
    /// </summary>
    public class GetHirePowerBankInsuranceOrderByOutOrderNumberResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置商户保险订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string OutOrderNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置保险订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置最大理赔次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_claim_count")]
        [System.Text.Json.Serialization.JsonPropertyName("max_claim_count")]
        public int MaxClaimCount { get; set; }

        /// <summary>
        /// 获取或设置已理赔次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("claimed_count")]
        [System.Text.Json.Serialization.JsonPropertyName("claimed_count")]
        public int ClaimedCount { get; set; }

        /// <summary>
        /// 获取或设置保险订单领取状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_receive_state")]
        [System.Text.Json.Serialization.JsonPropertyName("order_receive_state")]
        public string ReceiveState { get; set; } = default!;

        /// <summary>
        /// 获取或设置保险订单领取时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_receive_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("order_receive_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset ReceiveTime { get; set; }

        /// <summary>
        /// 获取或设置保险订单开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_begin_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("order_begin_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? BeginTime { get; set; }

        /// <summary>
        /// 获取或设置保险订单结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("order_end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? EndTime { get; set; }
    }
}
