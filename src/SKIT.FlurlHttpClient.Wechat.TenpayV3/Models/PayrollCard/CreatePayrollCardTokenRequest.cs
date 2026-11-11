namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payroll-card/tokens 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreatePayrollCardTokenRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置子商户微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置用户姓名。
        /// </summary>
        /// <remarks>
        /// 该属性是敏感数据字段，需要使用平台公钥或证书加密。
        /// </remarks>
        [Newtonsoft.Json.JsonProperty("user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("user_name")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string? UserName { get; set; }

        /// <summary>
        /// 获取或设置身份证号码。
        /// </summary>
        /// <remarks>
        /// 该属性是敏感数据字段，需要使用平台公钥或证书加密。
        /// </remarks>
        [Newtonsoft.Json.JsonProperty("id_card_number")]
        [System.Text.Json.Serialization.JsonPropertyName("id_card_number")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string? IdCardNumber { get; set; }

        /// <summary>
        /// 获取或设置用工类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("employment_type")]
        [System.Text.Json.Serialization.JsonPropertyName("employment_type")]
        public string? EmploymentType { get; set; }
    }
}
