namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/template/api_add_template 接口的响应。</para>
    /// </summary>
    public class CgibinTemplateAddTemplateResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = default!;
    }
}
