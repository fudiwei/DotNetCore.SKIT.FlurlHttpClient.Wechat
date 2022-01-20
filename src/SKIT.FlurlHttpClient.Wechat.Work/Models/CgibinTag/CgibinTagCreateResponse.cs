namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/tag/create 接口的响应。</para>
    /// </summary>
    public class CgibinTagCreateResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置标签 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tagid")]
        [System.Text.Json.Serialization.JsonPropertyName("tagid")]
        public int TagId { get; set; }
    }
}
