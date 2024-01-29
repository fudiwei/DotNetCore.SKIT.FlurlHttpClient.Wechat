namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.error_report 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90751 </para>
    /// </summary>
    public class ErrorReportEvent : WechatWorkEvent
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
        /// 获取或设置设备上报的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ErrCode")]
        [System.Text.Json.Serialization.JsonPropertyName("ErrCode")]
        [System.Xml.Serialization.XmlElement("ErrCode")]
        public int ErrorCode { get; set; }

        /// <summary>
        /// 获取或设置设备上报的错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ErrMsg")]
        [System.Text.Json.Serialization.JsonPropertyName("ErrMsg")]
        [System.Xml.Serialization.XmlElement("ErrMsg")]
        public string? ErrorMessage { get; set; }
    }
}
