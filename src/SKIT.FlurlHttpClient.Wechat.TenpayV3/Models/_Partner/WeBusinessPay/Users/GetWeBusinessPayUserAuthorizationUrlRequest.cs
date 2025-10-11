namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /webizpay/users/{user_id}/authorization-url 接口的请求。</para>
    /// </summary>
    public class GetWeBusinessPayUserAuthorizationUrlRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信商户号。如果不指定将使用构造 <see cref="WechatTenpayGlobalClient"/> 时的 <see cref="WechatTenpayGlobalClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户企业员工 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业支付额度卡卡号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CardNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业应用类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_type")]
        [System.Text.Json.Serialization.JsonPropertyName("application_type")]
        public string ApplicationType { get; set; } = string.Empty;
    }
}
