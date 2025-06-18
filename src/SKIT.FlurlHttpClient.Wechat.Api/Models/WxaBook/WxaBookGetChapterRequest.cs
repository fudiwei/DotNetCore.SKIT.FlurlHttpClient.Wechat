namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/getchapter 接口的请求。</para>
    /// </summary>
    public class WxaBookGetChapterRequest : WechatApiRequest, IInferable<WxaBookGetChapterRequest, WxaBookGetChapterResponse>
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
        /// 获取或设置是否返回编辑版信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_edited_data")]
        [System.Text.Json.Serialization.JsonPropertyName("need_edited_data")]
        public bool? IsNeedEditedData { get; set; }
    }
}
