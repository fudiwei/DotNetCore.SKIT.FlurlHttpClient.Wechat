namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /realname/verify 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class GetRealNameVerificationRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置下单用户证件类型。
        /// <para>默认值："1"</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? CredentialType { get; set; } = "1";

        /// <summary>
        /// 获取或设置下单用户证件号。
        /// </summary>
        /// <remarks>
        /// 该属性是敏感数据字段，需要使用平台公钥或证书加密。
        /// </remarks>
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? CredentialId { get; set; }

        /// <summary>
        /// 获取或设置下单用户姓名。
        /// </summary>
        /// <remarks>
        /// 该属性是敏感数据字段，需要使用平台公钥或证书加密。
        /// </remarks>
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? CredentialName { get; set; }

        /// <summary>
        /// 获取或设置微信支付交易单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? TransactionId { get; set; }
    }
}
