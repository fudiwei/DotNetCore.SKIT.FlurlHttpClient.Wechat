namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示被动回复图文消息的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Passive_user_reply_message.html#5 ]]>
    /// </para>
    /// </summary>
    public class NewsMessageReply : WechatApiEvent
    {
        public static class Types
        {
            public class ArticleItem
            {
                /// <summary>
                /// 获取或设置图文链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Url")]
                [System.Text.Json.Serialization.JsonPropertyName("Url")]
                [System.Xml.Serialization.XmlElement("Url")]
                public string Url { get; set; } = default!;

                /// <summary>
                /// 获取或设置图文封面图片链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("PicUrl")]
                [System.Text.Json.Serialization.JsonPropertyName("PicUrl")]
                [System.Xml.Serialization.XmlElement("PicUrl")]
                public string PictureUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置图文标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Title")]
                [System.Text.Json.Serialization.JsonPropertyName("Title")]
                [System.Xml.Serialization.XmlElement("Title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置图文描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Description")]
                [System.Text.Json.Serialization.JsonPropertyName("Description")]
                [System.Xml.Serialization.XmlElement("Description")]
                public string Description { get; set; } = default!;
            }

            public class ArticleList
            {
                /// <summary>
                /// 获取或设置图文列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item")]
                [System.Text.Json.Serialization.JsonPropertyName("item")]
                [System.Xml.Serialization.XmlElement("item", Type = typeof(ArticleItem))]
                public ArticleItem[] Items { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置图文数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ArticleCount")]
        [System.Text.Json.Serialization.JsonPropertyName("ArticleCount")]
        [System.Xml.Serialization.XmlElement("ArticleCount")]
        public int ArticleCount { get; set; }

        /// <summary>
        /// 获取或设置图文列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Articles")]
        [System.Text.Json.Serialization.JsonPropertyName("Articles")]
        [System.Xml.Serialization.XmlElement("Articles")]
        public Types.ArticleList ArticleList { get; set; } = default!;

        public NewsMessageReply()
        {
            MessageType = "news";
            Event = null;
        }
    }
}
