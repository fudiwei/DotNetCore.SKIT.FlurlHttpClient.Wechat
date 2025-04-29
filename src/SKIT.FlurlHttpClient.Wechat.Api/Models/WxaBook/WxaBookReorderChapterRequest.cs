namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/reorderchapter 接口的请求。</para>
    /// </summary>
    public class WxaBookReorderChapterRequest : WechatApiRequest, IInferable<WxaBookReorderChapterRequest, WxaBookReorderChapterResponse>
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
        /// 获取或设置目标章节 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target_chapter_id")]
        [System.Text.Json.Serialization.JsonPropertyName("target_chapter_id")]
        public string TargetChapterId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置排序操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operation")]
        [System.Text.Json.Serialization.JsonPropertyName("operation")]
        public int Operation { get; set; }
    }
}
