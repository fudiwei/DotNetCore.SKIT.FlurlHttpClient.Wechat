namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /nlp/news-abstraction/{TOKEN} 接口的请求。</para>
    /// </summary>
    public class NLPNewsAbstractionRequest : WechatOpenAIPlatformRequest, WechatOpenAIPlatformRequest.Serialization.IEncryptedUrlEncoded
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置新闻标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置新闻正文内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置新闻所属的一级类别标签。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                public string? Category { get; set; }

                /// <summary>
                /// 获取或设置是否在提取摘要前先进行新闻分类标志。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("do_news_classify")]
                [System.Text.Json.Serialization.JsonPropertyName("do_news_classify")]
                public bool? RequireDoNewsClassify { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uid")]
        [System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置请求数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = new Types.Data();
    }
}
