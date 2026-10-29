namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "VOICE" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/guide/product/message/Receiving_standard_messages.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/message/Receiving_standard_messages.html ]]>
    /// </para>
    /// </summary>
    public class VoiceMessageEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgId")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgId")]
        [System.Xml.Serialization.XmlElement("MsgId")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置语音格式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Format")]
        [System.Text.Json.Serialization.JsonPropertyName("Format")]
        [System.Xml.Serialization.XmlElement("Format")]
        public string? Format { get; set; }

        /// <summary>
        /// 获取或设置语音消息 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MediaId")]
        [System.Text.Json.Serialization.JsonPropertyName("MediaId")]
        [System.Xml.Serialization.XmlElement("MediaId")]
        public string? MediaId { get; set; }

        /// <summary>
        /// 获取或设置 16K 采样率的语音消息 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MediaId16K")]
        [System.Text.Json.Serialization.JsonPropertyName("MediaId16K")]
        [System.Xml.Serialization.XmlElement("MediaId16K", IsNullable = true)]
        public string? MediaId16K { get; set; }

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
