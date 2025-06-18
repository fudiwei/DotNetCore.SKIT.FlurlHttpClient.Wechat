namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/refund_order 接口的请求。</para>
    /// </summary>
    public class XPayRefundOrderRequest : XPayRequestBase, IInferable<XPayRefundOrderRequest, XPayRefundOrderResponse>
    {
        /// <summary>
        /// 获取或设置订单号。与字段 <see cref="PayWxOrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? PayOrderId { get; set; }

        /// <summary>
        /// 获取或设置微信内部订单号。与字段 <see cref="PayOrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_order_id")]
        public string? PayWxOrderId { get; set; }

        /// <summary>
        /// 获取或设置退款订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_order_id")]
        public string RefundOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_fee")]
        public int RefundFee { get; set; }

        /// <summary>
        /// 获取或设置剩余金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("left_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("left_fee")]
        public int LeftFee { get; set; }

        /// <summary>
        /// 获取或设置自定义信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_meta")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_meta")]
        public string? BusinessMeta { get; set; }

        /// <summary>
        /// 获取或设置退款原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_reason")]
        public string? RefundReason { get; set; }

        /// <summary>
        /// 获取或设置退款来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("req_from")]
        [System.Text.Json.Serialization.JsonPropertyName("req_from")]
        public string? RefundFrom { get; set; }

        protected internal override string GetRequestPath()
        {
            return "/xpay/refund_order";
        }
    }
}
