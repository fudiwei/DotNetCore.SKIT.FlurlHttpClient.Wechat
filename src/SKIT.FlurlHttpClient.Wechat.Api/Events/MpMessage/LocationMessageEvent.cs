namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 LOCATION 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Receiving_standard_messages.html#%E5%9C%B0%E7%90%86%E4%BD%8D%E7%BD%AE%E6%B6%88%E6%81%AF </para>
    /// </summary>
    public class LocationMessageEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgId")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgId")]
        [System.Xml.Serialization.XmlElement("MsgId")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置纬度坐标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Location_X")]
        [System.Text.Json.Serialization.JsonPropertyName("Location_X")]
        [System.Xml.Serialization.XmlElement("Location_X")]
        public double Latitude { get; set; }

        /// <summary>
        /// 获取或设置经度坐标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Location_Y")]
        [System.Text.Json.Serialization.JsonPropertyName("Location_Y")]
        [System.Xml.Serialization.XmlElement("Location_Y")]
        public double Longitude { get; set; }

        /// <summary>
        /// 获取或设置地图缩放大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Scale")]
        [System.Text.Json.Serialization.JsonPropertyName("Scale")]
        [System.Xml.Serialization.XmlElement("Scale")]
        public double Scale { get; set; }

        /// <summary>
        /// 获取或设置地理位置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Label")]
        [System.Text.Json.Serialization.JsonPropertyName("Label")]
        [System.Xml.Serialization.XmlElement("Label")]
        public string Label { get; set; } = default!;
    }
}
