namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "LINK" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/guide/product/message/Receiving_standard_messages.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/message/Receiving_standard_messages.html ]]>
    /// </para>
    /// </summary>
    public class LinkMessageEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgId")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgId")]
        [System.Xml.Serialization.XmlElement("MsgId")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置消息标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Title")]
        [System.Text.Json.Serialization.JsonPropertyName("Title")]
        [System.Xml.Serialization.XmlElement("Title")]
        public string? Title { get; set; }

        /// <summary>
        /// 获取或设置消息描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Description")]
        [System.Text.Json.Serialization.JsonPropertyName("Description")]
        [System.Xml.Serialization.XmlElement("Description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置消息链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Url")]
        [System.Text.Json.Serialization.JsonPropertyName("Url")]
        [System.Xml.Serialization.XmlElement("Url")]
        public string? Url { get; set; }

        /// <summary>
        /// 获取或设置消息数据 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgDataId")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgDataId")]
        [System.Xml.Serialization.XmlElement("MsgDataId", IsNullable = true)]
        public string? MessageDataId { get; set; }

        /// <summary>
        /// 获取或设置图文顺序索引（从 1 开始）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Idx")]
        [System.Text.Json.Serialization.JsonPropertyName("Idx")]
        [System.Xml.Serialization.XmlElement("Idx", IsNullable = true)]
        public int? Index { get; set; }

        /// <summary>
        /// 获取或设置客服子商户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("BusinessId")]
        [System.Text.Json.Serialization.JsonPropertyName("BusinessId")]
        [System.Xml.Serialization.XmlElement("BusinessId", IsNullable = true)]
        public long? BusinessId { get; set; }
    }
}
