namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /smartguide/guides/{guide_id} 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class UpdateSmartGuideRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置服务人员 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string GuideId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置企业微信的员工姓名（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string? UserName { get; set; }

        /// <summary>
        /// 获取或设置企业微信的员工手机号码（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string? UserMobile { get; set; }

        /// <summary>
        /// 获取或设置企业微信的员工个人二维码地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qr_code")]
        [System.Text.Json.Serialization.JsonPropertyName("qr_code")]
        public string? UserQrcodeUrl { get; set; }

        /// <summary>
        /// 获取或设置企业微信的员工头像地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avatar")]
        [System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? UserAvatarUrl { get; set; }

        /// <summary>
        /// 获取或设置群二维码地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_qrcode")]
        [System.Text.Json.Serialization.JsonPropertyName("group_qrcode")]
        public string? GroupQrcodeUrl { get; set; }
    }
}
