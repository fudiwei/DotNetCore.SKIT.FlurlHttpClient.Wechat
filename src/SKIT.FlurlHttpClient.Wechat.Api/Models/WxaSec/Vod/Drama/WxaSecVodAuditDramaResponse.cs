namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/auditdrama 接口的响应。</para>
    /// </summary>
    public class WxaSecVodAuditDramaResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置剧目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("drama_id")]
        [System.Text.Json.Serialization.JsonPropertyName("drama_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long DramaId { get; set; }
    }
}
