namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/createchapter 接口的响应。</para>
    /// </summary>
    public class WxaBookCreateChapterResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置章节 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chapter_id")]
        [System.Text.Json.Serialization.JsonPropertyName("chapter_id")]
        public string ChapterId { get; set; } = default!;
    }
}
