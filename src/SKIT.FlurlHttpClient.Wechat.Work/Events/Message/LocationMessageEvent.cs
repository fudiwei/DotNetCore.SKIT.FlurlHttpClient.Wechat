namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 LOCATION 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90239 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90375 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90855 </para>
    /// </summary>
    public class LocationMessageEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AgentID")]
        [System.Text.Json.Serialization.JsonPropertyName("AgentID")]
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置应用类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AppType")]
        [System.Text.Json.Serialization.JsonPropertyName("AppType")]
        [System.Xml.Serialization.XmlElement("AppType", IsNullable = true)]
        public string? AppType { get; set; }

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
        public decimal Latitude { get; set; }

        /// <summary>
        /// 获取或设置经度坐标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Location_Y")]
        [System.Text.Json.Serialization.JsonPropertyName("Location_Y")]
        [System.Xml.Serialization.XmlElement("Location_Y")]
        public decimal Longitude { get; set; }

        /// <summary>
        /// 获取或设置地图缩放大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Scale")]
        [System.Text.Json.Serialization.JsonPropertyName("Scale")]
        [System.Xml.Serialization.XmlElement("Scale")]
        public decimal Scale { get; set; }

        /// <summary>
        /// 获取或设置地理位置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Label")]
        [System.Text.Json.Serialization.JsonPropertyName("Label")]
        [System.Xml.Serialization.XmlElement("Label")]
        public string Label { get; set; } = default!;
    }
}
