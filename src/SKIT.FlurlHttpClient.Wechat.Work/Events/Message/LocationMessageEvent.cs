namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 LOCATION 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90239 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90375 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90855 </para>
    /// </summary>
    public class LocationMessageEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置应用类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AppType", IsNullable = true)]
        public string? AppType { get; set; }

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("MsgId")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置纬度坐标。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Location_X")]
        public double Latitude { get; set; }

        /// <summary>
        /// 获取或设置经度坐标。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Location_Y")]
        public double Longitude { get; set; }

        /// <summary>
        /// 获取或设置地图缩放大小。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Scale")]
        public double Scale { get; set; }

        /// <summary>
        /// 获取或设置地理位置信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Label")]
        public string Label { get; set; } = default!;
    }
}
