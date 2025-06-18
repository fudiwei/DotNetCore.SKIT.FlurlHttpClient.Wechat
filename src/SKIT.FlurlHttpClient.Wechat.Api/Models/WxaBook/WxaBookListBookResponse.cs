namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/listbook 接口的响应。</para>
    /// </summary>
    public class WxaBookListBookResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Book
            {
                public static class Types
                {
                    public class AuditInfo
                    {
                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                        public int AuditStatus { get; set; }

                        /// <summary>
                        /// 获取或设置提审时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置审核原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? Reason { get; set; }

                        /// <summary>
                        /// 获取或设置修改建议。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("suggestion")]
                        [System.Text.Json.Serialization.JsonPropertyName("suggestion")]
                        public string? Suggestion { get; set; }

                        /// <summary>
                        /// 获取或设置审核时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_time")]
                        public long? AuditTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置作品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("book_id")]
                [System.Text.Json.Serialization.JsonPropertyName("book_id")]
                public string BookId { get; set; } = default!;

                /// <summary>
                /// 获取或设置作品名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置作品简介。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("intro")]
                [System.Text.Json.Serialization.JsonPropertyName("intro")]
                public string Introduction { get; set; } = default!;

                /// <summary>
                /// 获取或设置封面图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cover_url")]
                [System.Text.Json.Serialization.JsonPropertyName("cover_url")]
                public string CoverUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置作者名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("author")]
                [System.Text.Json.Serialization.JsonPropertyName("author")]
                public string Author { get; set; } = default!;

                /// <summary>
                /// 获取或设置一级类型 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("first_category_id")]
                public int FirstCategoryId { get; set; }

                /// <summary>
                /// 获取或设置二级类型 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("second_category_id")]
                public int SecondCategoryId { get; set; }

                /// <summary>
                /// 获取或设置三级类型 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("third_category_id")]
                public int ThirdCategoryId { get; set; }

                /// <summary>
                /// 获取或设置完结状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complete_status")]
                [System.Text.Json.Serialization.JsonPropertyName("complete_status")]
                public int CompleteStatus { get; set; }

                /// <summary>
                /// 获取或设置提供方作品唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("original_id")]
                [System.Text.Json.Serialization.JsonPropertyName("original_id")]
                public string? OriginalId { get; set; }

                /// <summary>
                /// 获取或设置上传场景。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("upload_scene")]
                [System.Text.Json.Serialization.JsonPropertyName("upload_scene")]
                public int UploadScene { get; set; }

                /// <summary>
                /// 获取或设置章节数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chapter_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("chapter_cnt")]
                public int ChapterCount { get; set; }

                /// <summary>
                /// 获取或设置分卷数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("volume_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("volume_cnt")]
                public int VolumeCount { get; set; }

                /// <summary>
                /// 获取或设置作品总字数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_word_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("total_word_cnt")]
                public int TotalWordCount { get; set; }

                /// <summary>
                /// 获取或设置章节排序方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chapter_order_method")]
                [System.Text.Json.Serialization.JsonPropertyName("chapter_order_method")]
                public int ChapterOrderMethod { get; set; }

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
        /// 获取或设置作品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_list")]
        [System.Text.Json.Serialization.JsonPropertyName("book_list")]
        public Types.Book[] BookList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("total_cnt")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置分页 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_id")]
        [System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public long? LastId { get; set; }
    }
}
