namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/category/audit/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECCategoryAuditGetRequest : WechatApiRequest, IInferable<ChannelsECCategoryAuditGetRequest, ChannelsECCategoryAuditGetResponse>
    {
        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_id")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
        public long AuditId { get; set; }
    }
}
