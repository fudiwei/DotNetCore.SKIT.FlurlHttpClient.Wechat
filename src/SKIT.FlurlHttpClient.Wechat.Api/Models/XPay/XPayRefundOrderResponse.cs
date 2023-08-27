namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/refund_order 接口的响应。</para>
    /// </summary>
    public class XPayRefundOrderResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_order_id")]
        public string PayOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信内部订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_wx_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_wx_order_id")]
        public string PayWxOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_order_id")]
        public string RefundOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信内部退款订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_wx_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_wx_order_id")]
        public string RefundWxOrderId { get; set; } = default!;
    }
}
