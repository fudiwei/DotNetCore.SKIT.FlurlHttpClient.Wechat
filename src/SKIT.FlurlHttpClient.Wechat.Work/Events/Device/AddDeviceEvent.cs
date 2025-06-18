namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.add_device 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90751 ]]>
    /// </para>
    /// </summary>
    public class AddDeviceEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置服务商 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ServiceCorpId")]
        [System.Text.Json.Serialization.JsonPropertyName("ServiceCorpId")]
        [System.Xml.Serialization.XmlElement("ServiceCorpId")]
        public string ServiceCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthCorpId")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthCorpId")]
        [System.Xml.Serialization.XmlElement("AuthCorpId", IsNullable = true)]
        public string? AuthorizerCorpId { get; set; }

        /// <summary>
        /// 获取或设置设备序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DeviceSn")]
        [System.Text.Json.Serialization.JsonPropertyName("DeviceSn")]
        [System.Xml.Serialization.XmlElement("DeviceSn")]
        public string DeviceSerialNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置设备型号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ModelId")]
        [System.Text.Json.Serialization.JsonPropertyName("ModelId")]
        [System.Xml.Serialization.XmlElement("ModelId")]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// 获取或设置设备备注名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("RemarkName")]
        [System.Text.Json.Serialization.JsonPropertyName("RemarkName")]
        [System.Xml.Serialization.XmlElement("RemarkName")]
        public string? RemarkName { get; set; }
    }
}
