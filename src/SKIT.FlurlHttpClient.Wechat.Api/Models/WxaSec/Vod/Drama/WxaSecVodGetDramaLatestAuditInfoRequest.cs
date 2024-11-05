namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/getdramalatestauditinfo 接口的请求。</para>
    /// </summary>
    public class WxaSecVodGetDramaLatestAuditInfoRequest : WechatApiRequest, IInferable<WxaSecVodGetDramaLatestAuditInfoRequest, WxaSecVodGetDramaLatestAuditInfoResponse>
    {
        /// <summary>
        /// 获取或设置剧目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("drama_id")]
        [System.Text.Json.Serialization.JsonPropertyName("drama_id")]
        public long DramaId { get; set; }

        /// <summary>
        /// 获取或设置审核类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_type")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_type")]
        public int AuditType { get; set; }
    }
}
