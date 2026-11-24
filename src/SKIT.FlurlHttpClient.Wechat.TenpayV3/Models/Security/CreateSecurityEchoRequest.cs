namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /security/echo 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateSecurityEchoRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置回显信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("echo_message")]
        [System.Text.Json.Serialization.JsonPropertyName("echo_message")]
        public string? EchoMessage { get; set; }

        /// <summary>
        /// 获取或设置经过加密的回显信息。
        /// </summary>
        /// <remarks>
        /// 该属性是敏感数据字段，需要使用平台公钥或证书加密。
        /// </remarks>
        [Newtonsoft.Json.JsonProperty("encrypted_echo_message")]
        [System.Text.Json.Serialization.JsonPropertyName("encrypted_echo_message")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string? EncryptedEchoMessage { get; set; }
    }
}
