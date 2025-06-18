namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/order/get_order 接口的请求。</para>
    /// </summary>
    public class WxaSecOrderGetOrderRequest : WechatApiRequest, IInferable<WxaSecOrderGetOrderRequest, WxaSecOrderGetOrderResponse>
    {
        /// <summary>
        /// 获取或设置支付下单商户的商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置支付下单商户的二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_merchant_id")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置原支付交易的商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_trade_no")]
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置原支付交易的微信订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }
    }
}
