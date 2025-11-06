namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/instal/exposure 接口的请求。</para>
    /// </summary>
    public class CreatePayInstallmentExposureRequest : WechatTenpayRequest
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
        /// 获取或设置用户 ID 类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id_type")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id_type")]
        public string UserIdType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置手机号哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_number_hash")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_number_hash")]
        public string? PhoneNumberHash { get; set; }
    }
}
