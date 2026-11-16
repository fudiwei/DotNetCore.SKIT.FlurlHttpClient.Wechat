namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/getauditquota 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductGetAuditQuotaRequest : WechatApiRequest, IInferable<ChannelsECProductGetAuditQuotaRequest, ChannelsECProductGetAuditQuotaResponse>
    {
        /// <summary>
        /// 获取或设置商品类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
        public long? CategoryId { get; set; }
    }
}
