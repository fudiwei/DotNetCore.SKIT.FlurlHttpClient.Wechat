namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/approval/copytemplate 接口的响应。</para>
    /// </summary>
    public class CgibinOAApprovalCopyTemplateResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置审批模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = default!;
    }
}
