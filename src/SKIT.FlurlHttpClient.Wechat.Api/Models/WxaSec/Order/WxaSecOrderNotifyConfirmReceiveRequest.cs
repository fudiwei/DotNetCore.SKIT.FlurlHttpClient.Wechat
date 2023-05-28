namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/order/notify_confirm_receive 接口的请求。</para>
    /// </summary>
    public class WxaSecOrderNotifyConfirmReceiveRequest : WechatApiRequest, IInferable<WxaSecOrderNotifyConfirmReceiveRequest, WxaSecOrderNotifyConfirmReceiveResponse>
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

        /// <summary>
        /// 获取或设置快递签收时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("received_time")]
        [System.Text.Json.Serialization.JsonPropertyName("received_time")]
        public long ReceiveTimestamp { get; set; }
    }
}
