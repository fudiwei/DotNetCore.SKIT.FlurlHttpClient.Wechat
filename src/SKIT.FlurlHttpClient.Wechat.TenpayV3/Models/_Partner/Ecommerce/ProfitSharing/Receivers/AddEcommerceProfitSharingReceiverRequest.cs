namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/profitsharing/receivers/add 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class AddEcommerceProfitSharingReceiverRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置接收方类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 获取或设置接收方账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account")]
        [System.Text.Json.Serialization.JsonPropertyName("account")]
        public string? Account { get; set; }

        /// <summary>
        /// 获取或设置接收方商户全称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? MerchantName { get; set; }

        /// <summary>
        /// 获取或设置接收方个人姓名。
        /// </summary>
        /// <remarks>
        /// 该属性是敏感数据字段，需要使用平台公钥或证书加密。
        /// </remarks>
        [Newtonsoft.Json.JsonProperty("encrypted_name")]
        [System.Text.Json.Serialization.JsonPropertyName("encrypted_name")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string? UserName { get; set; }

        /// <summary>
        /// 获取或设置与分账方的关系类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relation_type")]
        [System.Text.Json.Serialization.JsonPropertyName("relation_type")]
        public string? RelationType { get; set; }
    }
}
