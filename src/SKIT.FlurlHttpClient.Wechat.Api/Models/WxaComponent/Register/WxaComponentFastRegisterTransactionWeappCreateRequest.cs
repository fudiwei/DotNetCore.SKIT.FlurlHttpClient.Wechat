namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/component/fastregistertransactionweapp?action=create 接口的请求。</para>
    /// </summary>
    public class WxaComponentFastRegisterTransactionWeappCreateRequest : WechatApiRequest, IInferable<WxaComponentFastRegisterTransactionWeappCreateRequest, WxaComponentFastRegisterTransactionWeappCreateResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAccessToken { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置第三方联系电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("component_phone")]
        public string? ComponentPhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置是否使用新接口。
        /// <para>默认值：true</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_version")]
        [System.Text.Json.Serialization.JsonPropertyName("new_version")]
        public bool? IsNewVersion { get; set; } = true;
    }
}
