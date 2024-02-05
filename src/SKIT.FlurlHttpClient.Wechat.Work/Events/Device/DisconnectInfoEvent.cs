namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.disconnect_info 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90751 ]]>
    /// </para>
    /// </summary>
    public class DisconnectInfoEvent : WechatWorkEvent
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
        /// 获取或设置设备与企业微信后台网络连接断开时的时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DisconnectTime")]
        [System.Text.Json.Serialization.JsonPropertyName("DisconnectTime")]
        [System.Xml.Serialization.XmlElement("DisconnectTime")]
        public long DiconnectTimestamp { get; set; }

        /// <summary>
        /// 获取或设置设备连接断开原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Reason")]
        [System.Text.Json.Serialization.JsonPropertyName("Reason")]
        [System.Xml.Serialization.XmlElement("Reason")]
        public string DisconnectReason { get; set; } = default!;
    }
}
