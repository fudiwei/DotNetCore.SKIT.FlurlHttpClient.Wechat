namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/approval/copytemplate 接口的请求。</para>
    /// </summary>
    public class CgibinOAApprovalCopyTemplateRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置服务商的审批模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_template_id")]
        public string OpenTemplateId { get; set; } = string.Empty;
    }
}
