namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/listchapter 接口的响应。</para>
    /// </summary>
    public class WxaBookListChapterResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Chapter
            {
                public static class Types
                {
                    public class AuditInfo : WxaBookListBookResponse.Types.Book.Types.AuditInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置章节 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chapter_id")]
                [System.Text.Json.Serialization.JsonPropertyName("chapter_id")]
                public string ChapterId { get; set; } = default!;

                /// <summary>
                /// 获取或设置章节标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chapter_title")]
                [System.Text.Json.Serialization.JsonPropertyName("chapter_title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置所属分卷下标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("volume_index")]
                [System.Text.Json.Serialization.JsonPropertyName("volume_index")]
                public int VolumeIndex { get; set; }

                /// <summary>
                /// 获取或设置提供方章节唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("original_id")]
                [System.Text.Json.Serialization.JsonPropertyName("original_id")]
                public string? OriginalId { get; set; }

                /// <summary>
                /// 获取或设置字数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("word_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("word_cnt")]
                public int WordCount { get; set; }

                /// <summary>
                /// 获取或设置章节相对顺序。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seq")]
                [System.Text.Json.Serialization.JsonPropertyName("seq")]
                public int? Sequence { get; set; }

                /// <summary>
                /// 获取或设置自定义信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_info")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_info")]
                public string? CustomInfo { get; set; }

                /// <summary>
                /// 获取或设置审核信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_info")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_info")]
                public Types.AuditInfo? AuditInfo { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置章节列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chapter_list")]
        [System.Text.Json.Serialization.JsonPropertyName("chapter_list")]
        public Types.Chapter[] ChapterList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("total_cnt")]
        public int TotalCount { get; set; }
    }
}
