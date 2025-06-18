namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/deletechapter 接口的请求。</para>
    /// </summary>
    public class WxaBookDeleteChapterRequest : WechatApiRequest, IInferable<WxaBookDeleteChapterRequest, WxaBookDeleteChapterResponse>
    {
        /// <summary>
        /// 获取或设置作品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_id")]
        [System.Text.Json.Serialization.JsonPropertyName("book_id")]
        public string BookId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置章节 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chapter_id")]
        [System.Text.Json.Serialization.JsonPropertyName("chapter_id")]
        public string ChapterId { get; set; } = string.Empty;
    }
}
