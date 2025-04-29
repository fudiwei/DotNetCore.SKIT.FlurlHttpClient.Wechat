namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/createchapter 接口的请求。</para>
    /// </summary>
    public class WxaBookCreateChapterRequest : WechatApiRequest, IInferable<WxaBookCreateChapterRequest, WxaBookCreateChapterResponse>
    {
        public static class Types
        {
            public class Chapter
            {
                /// <summary>
                /// 获取或设置章节标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chapter_title")]
                [System.Text.Json.Serialization.JsonPropertyName("chapter_title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置章节内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置提供方章节唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("original_id")]
                [System.Text.Json.Serialization.JsonPropertyName("original_id")]
                public string? OriginalId { get; set; }

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
            }
        }

        /// <summary>
        /// 获取或设置作品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_id")]
        [System.Text.Json.Serialization.JsonPropertyName("book_id")]
        public string BookId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置章节信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chapter")]
        [System.Text.Json.Serialization.JsonPropertyName("chapter")]
        public Types.Chapter Chapter { get; set; } = new Types.Chapter();
    }
}
