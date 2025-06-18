namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/mch/newcustoms/customdeclareredeclare 接口的请求。</para>
    /// </summary>
    public class RedeclareMerchantCustomsCustomDeclarationRequest : WechatTenpaySignableRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public override string? AppId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? NonceString { get; set; }

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
        /// 获取或设置海关。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customs")]
        [System.Text.Json.Serialization.JsonPropertyName("customs")]
        public string Customs { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户海关备案号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_customs_no")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_customs_no")]
        public string MerchantCustomsNumber { get; set; } = string.Empty;
    }
}
