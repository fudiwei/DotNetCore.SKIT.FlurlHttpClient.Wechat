namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /customs/verify-certificate 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class VerifyHKCustomsCertificateRequest : WechatTenpayRequest
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
        /// 获取或设置证件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_type")]
        [System.Text.Json.Serialization.JsonPropertyName("certificate_type")]
        public string CertificateType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置证件号码（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_id")]
        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
        [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS1)]
        public string CertificateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置证件姓名（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_name")]
        [System.Text.Json.Serialization.JsonPropertyName("certificate_name")]
        [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS1)]
        public string CertificateName { get; set; } = string.Empty;
    }
}
