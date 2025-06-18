namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/getchapter 接口的响应。</para>
    /// </summary>
    public class WxaBookGetChapterResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Chapter : WxaBookListChapterResponse.Types.Chapter
            {
                /// <summary>
                /// 获取或设置作品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("book_id")]
                [System.Text.Json.Serialization.JsonPropertyName("book_id")]
                public string BookId { get; set; } = default!;

                /// <summary>
                /// 获取或设置章节内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置章节信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chapter")]
        [System.Text.Json.Serialization.JsonPropertyName("chapter")]
        public Types.Chapter Chapter { get; set; } = default!;
    }
}
