using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/updatechapterseq 接口的请求。</para>
    /// </summary>
    public class WxaBookUpdateChapterSequenceRequest : WechatApiRequest, IInferable<WxaBookUpdateChapterSequenceRequest, WxaBookUpdateChapterSequenceResponse>
    {
        public static class Types
        {
            public class Chapter
            {
                /// <summary>
                /// 获取或设置章节 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chapter_id")]
                [System.Text.Json.Serialization.JsonPropertyName("chapter_id")]
                public string ChapterId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置章节相对顺序。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seq")]
                [System.Text.Json.Serialization.JsonPropertyName("seq")]
                public int Sequence { get; set; }
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
        [Newtonsoft.Json.JsonProperty("chapter_seq_list")]
        [System.Text.Json.Serialization.JsonPropertyName("chapter_seq_list")]
        public IList<Types.Chapter> ChapterIdList { get; set; } = new List<Types.Chapter>();
    }
}
