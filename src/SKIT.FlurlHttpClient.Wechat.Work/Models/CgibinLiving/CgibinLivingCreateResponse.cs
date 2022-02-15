namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/living/create 接口的响应。</para>
    /// </summary>
    public class CgibinLivingCreateResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置直播 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("livingid")]
        [System.Text.Json.Serialization.JsonPropertyName("livingid")]
        public string LivingId { get; set; } = default!;
    }
}
