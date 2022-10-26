namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/fastregisterpersonalweapp?action=create 接口的请求。</para>
    /// </summary>
    public class CgibinComponentFastRegisterPersonalWeappCreateRequest : WechatApiRequest, IInferable<CgibinComponentFastRegisterPersonalWeappCreateRequest, CgibinComponentFastRegisterPersonalWeappCreateResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置个人用户名字。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("idname")]
        [System.Text.Json.Serialization.JsonPropertyName("idname")]
        public string IdName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置个人用户微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxuser")]
        [System.Text.Json.Serialization.JsonPropertyName("wxuser")]
        public string Wxname { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置第三方联系电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("component_phone")]
        public string? ComponentPhoneNumber { get; set; }
    }
}
