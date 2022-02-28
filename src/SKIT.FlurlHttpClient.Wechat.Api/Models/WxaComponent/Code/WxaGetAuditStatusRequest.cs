namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/get_auditstatus 接口的请求。</para>
    /// </summary>
    public class WxaGetAuditStatusRequest : WechatApiRequest, IInferable<WxaGetAuditStatusRequest, WxaGetAuditStatusResponse>
    {
        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auditid")]
        [System.Text.Json.Serialization.JsonPropertyName("auditid")]
        public int AuditId { get; set; }
    }
}
