namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /smartguide/guides 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class QuerySmartGuidesRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int StoreId { get; set; }

        /// <summary>
        /// 获取或设置企业微信的员工 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? UserId { get; set; }

        /// <summary>
        /// 获取或设置企业微信的员工手机号码（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
        public string? UserMobile { get; set; }

        /// <summary>
        /// 获取或设置企业微信的员工工号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? UserWorkId { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Offset { get; set; }
    }
}
