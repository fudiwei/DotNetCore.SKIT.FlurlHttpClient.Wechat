namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/fastregisterweapp?action=search 接口的请求。</para>
    /// </summary>
    public class CgibinComponentFastRegisterWeappSearchRequest : WechatApiRequest, IInferable<CgibinComponentFastRegisterWeappSearchRequest, CgibinComponentFastRegisterWeappSearchResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string EnterpriseName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置法人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_persona_name")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_persona_name")]
        public string LegalPersonName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置法人微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_persona_wechat")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_persona_wechat")]
        public string LegalPersonWxname { get; set; } = string.Empty;
    }
}
