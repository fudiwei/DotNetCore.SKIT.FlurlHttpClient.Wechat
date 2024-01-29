namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.LOCATION 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90240 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90376 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90858 </para>
    /// </summary>
    public class LocationPushEvent : WechatWorkEvent
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
        /// 获取或设置地理位置纬度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Latitude")]
        [System.Text.Json.Serialization.JsonPropertyName("Latitude")]
        [System.Xml.Serialization.XmlElement("Latitude")]
        public decimal Latitude { get; set; }

        /// <summary>
        /// 获取或设置地理位置经度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Longitude")]
        [System.Text.Json.Serialization.JsonPropertyName("Longitude")]
        [System.Xml.Serialization.XmlElement("Longitude")]
        public decimal Longitude { get; set; }

        /// <summary>
        /// 获取或设置地理位置精度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Precision")]
        [System.Text.Json.Serialization.JsonPropertyName("Precision")]
        [System.Xml.Serialization.XmlElement("Precision")]
        public decimal Precision { get; set; }
    }
}
