namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /customs/redeclare 接口的请求。</para>
    /// </summary>
    public class RedeclareHKCustomsOrderRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置商户子订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_order_no")]
        public string? SubOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置微信子订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_order_id")]
        public string? SubOrderId { get; set; }

        /// <summary>
        /// 获取或设置海关代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customs")]
        [System.Text.Json.Serialization.JsonPropertyName("customs")]
        public string Customs { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户海关备案号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_customs_no")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_customs_no")]
        public string MerchantCustomsNumber { get; set; } = string.Empty;
    }
}
