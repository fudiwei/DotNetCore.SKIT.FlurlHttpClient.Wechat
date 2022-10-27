namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.wxa_nickname_audit 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/basic-info-management/setNickName.html </para>
    /// </summary>
    public class WxaNicknameAuditEvent : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置昵称。
        /// </summary>
        [System.Xml.Serialization.XmlElement("nickname")]
        public string Nickname { get; set; } = default!;

        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ret")]
        public int AuditStatus { get; set; }

        /// <summary>
        /// 获取或设置审核拒绝原因。
        /// </summary>
        [System.Xml.Serialization.XmlElement("reason", IsNullable = true)]
        public string? AuditRejectReason { get; set; }
    }
}
