namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/submit_audit 接口的响应。</para>
    /// </summary>
    public class WxaSubmitAuditResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auditid")]
        [System.Text.Json.Serialization.JsonPropertyName("auditid")]
        public long AuditId { get; set; }
    }
}
