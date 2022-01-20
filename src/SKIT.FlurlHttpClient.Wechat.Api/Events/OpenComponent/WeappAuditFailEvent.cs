namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.weapp_audit_fail 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/code/audit_event.html </para>
    /// </summary>
    public class WeappAuditFailEvent : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置审核失败时间戳。
        /// </summary>
        [System.Xml.Serialization.XmlElement("FailTime")]
        public long FailTimestamp { get; set; }

        /// <summary>
        /// 获取或设置审核失败的原因。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Reason", IsNullable = true)]
        public string? FailReason { get; set; }

        /// <summary>
        /// 获取或设置截图 MediaId 列表，使用竖线分隔。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ScreenShot", IsNullable = true)]
        public string? ScreenshotMediaIds { get; set; }
    }
}
