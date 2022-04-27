using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/payments/{payment_id}/close 接口的响应。</para>
    /// </summary>
    public class CloseMSEPayPaymentResponse : WechatTenpayBusinessResponse
    {
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
        /// 获取或设置关单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置关单时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("close_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("close_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CloseTime { get; set; }
    }
}
