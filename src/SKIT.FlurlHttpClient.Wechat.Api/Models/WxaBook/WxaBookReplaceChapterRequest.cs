namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/replacechapter 接口的请求。</para>
    /// </summary>
    public class WxaBookReplaceChapterRequest : WechatApiRequest, IInferable<WxaBookReplaceChapterRequest, WxaBookReplaceChapterResponse>
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

        /// <summary>
        /// 获取或设置章节标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_chapter_title")]
        [System.Text.Json.Serialization.JsonPropertyName("new_chapter_title")]
        public string ChapterTitle { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置章节内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_content")]
        [System.Text.Json.Serialization.JsonPropertyName("new_content")]
        public string ChapterContent { get; set; } = string.Empty;
    }
}
