namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/approval/create_template 接口的响应。</para>
    /// </summary>
    public class CgibinOAApprovalCreateTemplateResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置模版 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = default!;
    }
}
