namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/batchcreatechapter 接口的响应。</para>
    /// </summary>
    public class WxaBookBatchCreateChapterResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置章节 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chapter_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("chapter_id_list")]
        public string[] ChapterIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置冲突的提供方章节唯一标识列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conflict_original_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("conflict_original_id_list")]
        public string[]? ConflictOriginalIdList { get; set; }
    }
}
