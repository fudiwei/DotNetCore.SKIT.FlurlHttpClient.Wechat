namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/category/audit/cancel 接口的请求。</para>
    /// </summary>
    public class ChannelsECCategoryAuditCancelRequest : WechatApiRequest, IInferable<ChannelsECCategoryAuditCancelRequest, ChannelsECCategoryAuditCancelResponse>
    {
        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_id")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
        public long AuditId { get; set; }
    }
}
