namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.weapp_audit_delay 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/code-management/submitAudit.html </para>
    /// </summary>
    public class WeappAuditDelayEvent : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置审核延后时间戳。
        /// </summary>
        [System.Xml.Serialization.XmlElement("DelayTime")]
        public long DelayTimestamp { get; set; }

        /// <summary>
        /// 获取或设置审核拒绝原因。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Reason", IsNullable = true)]
        public string? RejectReason { get; set; }
    }
}
