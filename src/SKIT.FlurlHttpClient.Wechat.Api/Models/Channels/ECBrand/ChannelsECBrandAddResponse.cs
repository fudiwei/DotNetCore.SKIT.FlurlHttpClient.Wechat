namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/brand/add 接口的响应。</para>
    /// </summary>
    public class ChannelsECBrandAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_id")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long AuditId { get; set; }
    }
}
