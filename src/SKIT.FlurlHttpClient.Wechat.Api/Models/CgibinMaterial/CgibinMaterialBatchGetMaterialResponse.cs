namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/material/batchget_material 接口的响应。</para>
    /// </summary>
    public class CgibinMaterialBatchGetMaterialResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Material
            {
                public static class Types
                {
                    public class Content
                    {
                        public static class Types
                        {
                            public class Article
                            {
                                /// <summary>
                                /// 获取或设置图文消息缩略图媒体文件标识。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("thumb_media_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("thumb_media_id")]
                                public string ThumbnailMediaId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置图文消息缩略图 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("thumb_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("thumb_url")]
                                public string ThumbnailUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置图文消息标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置图文消息作者。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("author")]
                                [System.Text.Json.Serialization.JsonPropertyName("author")]
                                public string Author { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置图文消息摘要。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("digest")]
                                [System.Text.Json.Serialization.JsonPropertyName("digest")]
                                public string Digest { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置图文消息阅读原文 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("content_source_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("content_source_url")]
                                public string ContentSourceUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置图文消息页面的内容。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("content")]
                                [System.Text.Json.Serialization.JsonPropertyName("content")]
                                public string Content { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置图文消息页面的 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("url")]
                                [System.Text.Json.Serialization.JsonPropertyName("url")]
                                public string Url { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置是否显示封面。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("show_cover_pic")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("show_cover_pic")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                                public bool IsShowCover { get; set; }

                                /// <summary>
                                /// 获取或设置是否打开评论。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("need_open_comment")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("need_open_comment")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                                public bool? IsOpenComment { get; set; }

                                /// <summary>
                                /// 获取或设置是否粉丝才可评论。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("only_fans_can_comment")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("only_fans_can_comment")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                                public bool? IsOnlyFansCanComment { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置图文消息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("news_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("news_item")]
                        public Types.Article[]? ArticleList { get; set; }

                        /// <summary>
                        /// 获取或设置修改时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置媒体文件标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string MediaId { get; set; } = default!;

                /// <summary>
                /// 获取或设置素材名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置素材 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? Url { get; set; }

                /// <summary>
                /// 获取或设置图文消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public Types.Content? Content { get; set; }

                /// <summary>
                /// 获取或设置修改时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置素材数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int Total { get; set; }

        /// <summary>
        /// 获取或设置本次调用获取的素材数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_count")]
        [System.Text.Json.Serialization.JsonPropertyName("item_count")]
        public int Count { get; set; }

        /// <summary>
        /// 获取或设置图文消息素材列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item")]
        [System.Text.Json.Serialization.JsonPropertyName("item")]
        public Types.Material[] MaterialList { get; set; } = default!;
    }
}
