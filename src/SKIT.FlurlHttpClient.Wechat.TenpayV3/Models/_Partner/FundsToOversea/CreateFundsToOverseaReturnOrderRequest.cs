namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /funds-to-oversea/return/return-orders 接口的请求。</para>
    /// </summary>
    public class CreateFundsToOverseaReturnOrderRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户出境退回单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_return_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_return_no")]
        public string OutReturnNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户出境单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_id")]
        public string OutOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
        public string RefundId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置退回金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }
    }
}
