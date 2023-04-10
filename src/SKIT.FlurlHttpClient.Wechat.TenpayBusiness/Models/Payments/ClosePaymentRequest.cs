namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/payments/{payment_id}/close 接口的请求。</para>
    /// </summary>
    public class ClosePaymentRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置微企付支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PaymentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置关闭原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("close_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("close_reason")]
        public string CloseReason { get; set; } = string.Empty;
    }
}
