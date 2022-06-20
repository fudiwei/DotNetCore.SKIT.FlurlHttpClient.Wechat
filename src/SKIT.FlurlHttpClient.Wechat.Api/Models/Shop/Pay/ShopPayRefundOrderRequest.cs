namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/pay/refundorder 接口的请求。</para>
    /// </summary>
    public class ShopPayRefundOrderRequest : WechatApiRequest, IInferable<ShopPayRefundOrderRequest, ShopPayRefundOrderResponse>
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_no")]
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置微信支付交易单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置商户退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_no")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_no")]
        public string OutRefundNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单总金额（单位：分）。
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
    }
}
