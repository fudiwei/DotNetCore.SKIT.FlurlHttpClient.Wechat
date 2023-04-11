namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/refunds 接口的请求。</para>
    /// </summary>
    public class CreateRefundRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置企业 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ent_id")]
        public string EnterpriseId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置平台退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_refund_id")]
        public string OutRefundId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置平台支付单号。与字段 <see cref="PaymentId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_payment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_payment_id")]
        public string? OutPaymentId { get; set; }

        /// <summary>
        /// 获取或设置微企付支付单号。与字段 <see cref="OutPaymentId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_id")]
        public string? PaymentId { get; set; }

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
        /// 获取或设置退款结果通知 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("server_notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("server_notify_url")]
        public string ServerNotifyUrl { get; set; } = string.Empty;
    }
}
