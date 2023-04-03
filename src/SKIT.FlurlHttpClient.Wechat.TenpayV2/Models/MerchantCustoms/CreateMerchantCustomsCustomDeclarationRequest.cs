namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/mch/customs/customdeclareorder 接口的请求。</para>
    /// </summary>
    public class CreateMerchantCustomsCustomDeclarationRequest : WechatTenpaySignableRequest
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

        /// <summary>
        /// 获取或设置关税（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duty")]
        [System.Text.Json.Serialization.JsonPropertyName("duty")]
        public int? Duty { get; set; }

        /// <summary>
        /// 获取或设置报关类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_type")]
        [System.Text.Json.Serialization.JsonPropertyName("action_type")]
        public string? ActionType { get; set; }

        /// <summary>
        /// 获取或设置币种。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee_type")]
        [System.Text.Json.Serialization.JsonPropertyName("fee_type")]
        public string? FeeType { get; set; }

        /// <summary>
        /// 获取或设置应付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("order_fee")]
        public int? OrderFee { get; set; }

        /// <summary>
        /// 获取或设置物流费（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transport_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("transport_fee")]
        public int? TransportFee { get; set; }

        /// <summary>
        /// 获取或设置商品价格（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("product_fee")]
        public int? ProductFee { get; set; }

        /// <summary>
        /// 获取或设置证件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_type")]
        [System.Text.Json.Serialization.JsonPropertyName("cert_type")]
        public string? CertificateType { get; set; }

        /// <summary>
        /// 获取或设置证件号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cert_id")]
        public string? CertificateId { get; set; }

        /// <summary>
        /// 获取或设置证件姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? CertificateName { get; set; }
    }
}
