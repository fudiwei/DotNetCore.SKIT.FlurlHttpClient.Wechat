namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/replacechapter 接口的响应。</para>
    /// </summary>
    public class WxaBookReplaceChapterResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置新章节 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_chapter_id")]
        [System.Text.Json.Serialization.JsonPropertyName("new_chapter_id")]
        public string ChapterId { get; set; } = default!;
    }
}
