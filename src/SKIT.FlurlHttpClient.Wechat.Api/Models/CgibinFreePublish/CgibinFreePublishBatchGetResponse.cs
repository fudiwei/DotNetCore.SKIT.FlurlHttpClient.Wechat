namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/freepublish/batchget 接口的响应。</para>
    /// </summary>
    public class CgibinFreePublishBatchGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Item
            {
                public static class Types
                {
                    public class Content
                    {
                        public static class Types
                        {
                            public class Article : CgibinFreePublishGetArticleResponse.Types.Article
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置草稿图文消息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("news_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("news_item")]
                        public Types.Article[] ArticleList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置图文消息的 ArticleId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("article_id")]
                [System.Text.Json.Serialization.JsonPropertyName("article_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string ArticleId { get; set; } = default!;

                /// <summary>
                /// 获取或设置草稿内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public Types.Content? Content { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置图文消息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item")]
        [System.Text.Json.Serialization.JsonPropertyName("item")]
        public Types.Item[] List { get; set; } = default!;

        /// <summary>
        /// 获取或设置本次数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_count")]
        [System.Text.Json.Serialization.JsonPropertyName("item_count")]
        public int Count { get; set; } = default!;

        /// <summary>
        /// 获取或设置草稿总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; } = default!;
    }
}
