namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [POST] /customs/orders 接口的请求。</para>
    /// </summary>
    public class CreateCustomsOrderRequest : WechatTenpayGlobalRequest
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
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户子订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_order_no")]
        public string? SubOrderNumber { get; set; }

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

        /// <summary>
        /// 获取或设置关税（单位：指定货币的最小单位）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duty")]
        [System.Text.Json.Serialization.JsonPropertyName("duty")]
        public int? Duty { get; set; }

        /// <summary>
        /// 获取或设置币种。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee_type")]
        [System.Text.Json.Serialization.JsonPropertyName("fee_type")]
        public string? FeeType { get; set; }

        /// <summary>
        /// 获取或设置应付金额（单位：指定货币的最小单位）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("order_fee")]
        public int? OrderFee { get; set; }

        /// <summary>
        /// 获取或设置物流费（单位：指定货币的最小单位）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transport_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("transport_fee")]
        public int? TransportFee { get; set; }

        /// <summary>
        /// 获取或设置商品价格（单位：指定货币的最小单位）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("product_fee")]
        public int? ProductFee { get; set; }
    }
}
