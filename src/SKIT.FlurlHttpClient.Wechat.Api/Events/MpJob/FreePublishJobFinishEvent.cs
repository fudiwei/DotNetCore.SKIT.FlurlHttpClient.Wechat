namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.FREEPUBLISHJOBFINISH 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Publish/Callback_on_finish.html </para>
    /// </summary>
    public class FreePublishJobFinishEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class EventData
            {
                public static class Types
                {
                    public class ArticleDetail
                    {
                        public static class Types
                        {
                            public class Item
                            {
                                /// <summary>
                                /// 获取或设置文章索引。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("idx")]
                                [System.Text.Json.Serialization.JsonPropertyName("idx")]
                                [System.Xml.Serialization.XmlElement("idx")]
                                public int Index { get; set; }

                                /// <summary>
                                /// 获取或设置文章 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("article_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("article_url")]
                                [System.Xml.Serialization.XmlElement("article_url")]
                                public string ArticleUrl { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置文章数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        [System.Xml.Serialization.XmlElement("count")]
                        public int Count { get; set; }

                        /// <summary>
                        /// 获取或设置文章列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item")]
                        [System.Text.Json.Serialization.JsonPropertyName("item")]
                        [System.Xml.Serialization.XmlElement("item", Type = typeof(Types.Item))]
                        public Types.Item[] List { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("publish_id")]
                [System.Text.Json.Serialization.JsonPropertyName("publish_id")]
                [System.Xml.Serialization.XmlElement("publish_id")]
                public string PublishId { get; set; } = default!;

                /// <summary>
                /// 获取或设置发布状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("publish_status")]
                [System.Text.Json.Serialization.JsonPropertyName("publish_status")]
                [System.Xml.Serialization.XmlElement("publish_status")]
                public int PublishStatus { get; set; }

                /// <summary>
                /// 获取或设置图文消息的 ArticleId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("article_id")]
                [System.Text.Json.Serialization.JsonPropertyName("article_id")]
                [System.Xml.Serialization.XmlElement("article_id")]
                public string? ArticleId { get; set; }

                /// <summary>
                /// 获取或设置图文消息的详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("article_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("article_detail")]
                [System.Xml.Serialization.XmlElement("article_detail")]
                public Types.ArticleDetail? ArticleDetail { get; set; }

                /// <summary>
                /// 获取或设置不通过的文章索引列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_idx")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_idx")]
                [System.Xml.Serialization.XmlElement("fail_idx", Type = typeof(int))]
                public int[]? FailedIndexList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PublishEventInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("PublishEventInfo")]
        [System.Xml.Serialization.XmlElement("PublishEventInfo")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
