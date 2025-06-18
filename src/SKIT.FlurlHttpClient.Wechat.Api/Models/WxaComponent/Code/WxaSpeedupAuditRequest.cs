namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/speedupaudit 接口的请求。</para>
    /// </summary>
    public class WxaSpeedupAuditRequest : WechatApiRequest, IInferable<WxaSpeedupAuditRequest, WxaSpeedupAuditResponse>
    {
        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auditid")]
        [System.Text.Json.Serialization.JsonPropertyName("auditid")]
        public long AuditId { get; set; }
    }
}
