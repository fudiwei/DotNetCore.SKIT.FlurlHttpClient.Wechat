namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ec/category/audit/cancel 接口的请求。</para>
    /// </summary>
    public class ShopECCategoryAuditCancelRequest : WechatApiRequest, IInferable<ShopECCategoryAuditCancelRequest, ShopECCategoryAuditCancelResponse>
    {
        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_id")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
        public long AuditId { get; set; }
    }
}
