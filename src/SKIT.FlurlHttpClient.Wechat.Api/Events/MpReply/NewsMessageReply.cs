namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "news" 回调通知应答的数据</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/guide/product/message/Passive_user_reply_message.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/message/Passive_user_reply_message.html ]]>
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
                public string? Url { get; set; }

                /// <summary>
                /// 获取或设置图文封面图片链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("PicUrl")]
                [System.Text.Json.Serialization.JsonPropertyName("PicUrl")]
                [System.Xml.Serialization.XmlElement("PicUrl")]
                public string? PictureUrl { get; set; }

                /// <summary>
                /// 获取或设置图文标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Title")]
                [System.Text.Json.Serialization.JsonPropertyName("Title")]
                [System.Xml.Serialization.XmlElement("Title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置图文描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Description")]
                [System.Text.Json.Serialization.JsonPropertyName("Description")]
                [System.Xml.Serialization.XmlElement("Description")]
                public string? Description { get; set; }
            }

            public class ArticleList
            {
                /// <summary>
                /// 获取或设置图文列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item")]
                [System.Text.Json.Serialization.JsonPropertyName("item")]
                [System.Xml.Serialization.XmlElement("item", Type = typeof(ArticleItem))]
                public List<ArticleItem>? Items { get; set; }
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
        public Types.ArticleList? ArticleList { get; set; }

        public NewsMessageReply()
        {
            MessageType = "news";
            Event = null;
        }
    }
}
