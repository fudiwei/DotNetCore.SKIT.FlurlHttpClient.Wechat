namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.connect_info 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90751 </para>
    /// </summary>
    public class ConnectInfoEvent : WechatWorkEvent
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
        /// 获取或设置设备成功连接企业微信后台时的时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ConnectTime")]
        [System.Text.Json.Serialization.JsonPropertyName("ConnectTime")]
        [System.Xml.Serialization.XmlElement("ConnectTime")]
        public long ConnectTimestamp { get; set; }
    }
}
