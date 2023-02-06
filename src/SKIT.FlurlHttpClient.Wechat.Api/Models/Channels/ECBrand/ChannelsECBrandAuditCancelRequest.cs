namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/brand/audit/cancel 接口的请求。</para>
    /// </summary>
    public class ChannelsECBrandAuditCancelRequest : WechatApiRequest, IInferable<ChannelsECBrandAuditCancelRequest, ChannelsECBrandAuditCancelResponse>
    {
        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public long BrandId { get; set; }

        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_id")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
        public long AuditId { get; set; }
    }
}
