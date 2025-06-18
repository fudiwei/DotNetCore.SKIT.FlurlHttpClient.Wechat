namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 LINK 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90239 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90375 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90855 ]]>
    /// </para>
    /// </summary>
    public class LinkMessageEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AgentID")]
        [System.Text.Json.Serialization.JsonPropertyName("AgentID")]
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgId")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgId")]
        [System.Xml.Serialization.XmlElement("MsgId")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Title")]
        [System.Text.Json.Serialization.JsonPropertyName("Title")]
        [System.Xml.Serialization.XmlElement("Title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Description")]
        [System.Text.Json.Serialization.JsonPropertyName("Description")]
        [System.Xml.Serialization.XmlElement("Description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 获取或设置跳转链接 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Url")]
        [System.Text.Json.Serialization.JsonPropertyName("Url")]
        [System.Xml.Serialization.XmlElement("Url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 获取或设置封面图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PicUrl")]
        [System.Text.Json.Serialization.JsonPropertyName("PicUrl")]
        [System.Xml.Serialization.XmlElement("PicUrl")]
        public string PictureUrl { get; set; } = default!;
    }
}
