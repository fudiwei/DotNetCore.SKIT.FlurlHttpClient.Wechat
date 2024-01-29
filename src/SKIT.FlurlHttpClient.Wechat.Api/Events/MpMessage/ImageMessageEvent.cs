namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 IMAGE 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Receiving_standard_messages.html#%E5%9B%BE%E7%89%87%E6%B6%88%E6%81%AF </para>
    /// </summary>
    public class ImageMessageEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgId")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgId")]
        [System.Xml.Serialization.XmlElement("MsgId")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PicUrl")]
        [System.Text.Json.Serialization.JsonPropertyName("PicUrl")]
        [System.Xml.Serialization.XmlElement("PicUrl")]
        public string PictureUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置图片消息 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MediaId")]
        [System.Text.Json.Serialization.JsonPropertyName("MediaId")]
        [System.Xml.Serialization.XmlElement("MediaId")]
        public string MediaId { get; set; } = default!;

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
