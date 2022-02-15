/* @codestyle-disable no-jsonable-property-in-request-get */
namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [GET] /papay/partner/h5entrustweb 接口的请求。</para>
    /// </summary>
    public class CreatePAPPayPartnerH5EntrustWebRequest : CreatePAPPayH5EntrustWebRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置设备 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deviceid")]
        [System.Text.Json.Serialization.JsonPropertyName("deviceid")]
        public string? DeviceId { get; set; }

        /// <summary>
        /// 获取或设置用户手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
        public string? UserMobile { get; set; }

        /// <summary>
        /// 获取或设置用户邮箱地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email")]
        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// 获取或设置用户 QQ 号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qq")]
        [System.Text.Json.Serialization.JsonPropertyName("qq")]
        public string? UserQQ { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置用户的身份证号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creid")]
        [System.Text.Json.Serialization.JsonPropertyName("creid")]
        public string? IDCardNumber { get; set; }

        /// <summary>
        /// 获取或设置商户侧用户标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("outerid")]
        [System.Text.Json.Serialization.JsonPropertyName("outerid")]
        public string? OuterId { get; set; }
    }
}
