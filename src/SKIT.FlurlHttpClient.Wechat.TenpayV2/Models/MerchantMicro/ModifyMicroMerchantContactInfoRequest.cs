namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /applyment/micro/modifycontactinfo 接口的请求。</para>
    /// </summary>
    public class ModifyMicroMerchantContactInfoRequest : WechatTenpaySignableRequest
    {
        /// <summary>
        /// 获取或设置接口版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <i>（冗余字段，请忽略）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// <inheritdoc/>
        /// <para>默认值：<see cref="Constants.SignTypes.HMAC_SHA256"/></para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_type")]
#pragma warning disable CS8765
        public override string SignType { get; set; } = Constants.SignTypes.HMAC_SHA256;
#pragma warning restore CS8765

        /// <summary>
        /// 获取或设置商户简称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_name")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
        public string? MerchantName { get; set; }

        /// <summary>
        /// 获取或设置手机号码（需使用平台提供的 RSA 公钥加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("mobile_phone")]
        public string? MobileNumber { get; set; }

        /// <summary>
        /// 获取或设置邮箱地址（需使用平台提供的 RSA 公钥加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email")]
        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 获取或设置平台证书序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_sn")]
        [System.Text.Json.Serialization.JsonPropertyName("cert_sn")]
        public string CertificateSerialNumber { get; set; } = string.Empty;
    }
}
