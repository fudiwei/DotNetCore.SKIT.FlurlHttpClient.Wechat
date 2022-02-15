namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.fetch_log_finish 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90751 </para>
    /// </summary>
    public class FetchLogFinishEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置服务商 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ServiceCorpId")]
        public string ServiceCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AuthCorpId", IsNullable = true)]
        public string? AuthorizerCorpId { get; set; }

        /// <summary>
        /// 获取或设置设备序列号。
        /// </summary>
        [System.Xml.Serialization.XmlElement("DeviceSn")]
        public string DeviceSerialNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置日志文件的 MediaId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("MediaId")]
        public string MediaId { get; set; } = default!;
    }
}
