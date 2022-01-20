namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/addtotemplate 接口的请求。</para>
    /// </summary>
    public class WxaAddToTemplateRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置草稿 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("draft_id")]
        [System.Text.Json.Serialization.JsonPropertyName("draft_id")]
        public int DraftId { get; set; }

        /// <summary>
        /// 获取或设置模板类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_type")]
        [System.Text.Json.Serialization.JsonPropertyName("template_type")]
        public int? TemplateType { get; set; }
    }
}
