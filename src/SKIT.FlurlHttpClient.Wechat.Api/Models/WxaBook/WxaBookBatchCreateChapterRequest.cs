using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/batchcreatechapter 接口的请求。</para>
    /// </summary>
    public class WxaBookBatchCreateChapterRequest : WechatApiRequest, IInferable<WxaBookBatchCreateChapterRequest, WxaBookBatchCreateChapterResponse>
    {
        public static class Types
        {
            public class Chapter : WxaBookCreateChapterRequest.Types.Chapter
            {
            }
        }

        /// <summary>
        /// 获取或设置作品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_id")]
        [System.Text.Json.Serialization.JsonPropertyName("book_id")]
        public string BookId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置章节列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chapter_list")]
        [System.Text.Json.Serialization.JsonPropertyName("chapter_list")]
        public IList<Types.Chapter> ChapterList { get; set; } = new List<Types.Chapter>();
    }
}
