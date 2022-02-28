namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/template/del_private_template 接口的请求。</para>
    /// </summary>
    public class CgibinTemplateDeletePrivateTemplateRequest : WechatApiRequest, IInferable<CgibinTemplateDeletePrivateTemplateRequest, CgibinTemplateDeletePrivateTemplateResponse>
    {
        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = string.Empty;
    }
}
