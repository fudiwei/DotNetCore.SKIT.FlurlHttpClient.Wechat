namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /smartguide/guides 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateSmartGuideRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置企业 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
        public string CorpId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("store_id")]
        public int StoreId { get; set; }

        /// <summary>
        /// 获取或设置企业微信的员工 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业微信的员工姓名（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string UserName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业微信的员工手机号码（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string UserMobile { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业微信的员工个人二维码地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qr_code")]
        [System.Text.Json.Serialization.JsonPropertyName("qr_code")]
        public string UserQrcodeUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业微信的员工头像地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avatar")]
        [System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string UserAvatarUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置群二维码地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_qrcode")]
        [System.Text.Json.Serialization.JsonPropertyName("group_qrcode")]
        public string? GroupQrcodeUrl { get; set; }
    }
}
