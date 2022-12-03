namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.app_email_change 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/97506 </para>
    /// </summary>
    public class AppEmailChangeEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置变更类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ChangeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置新邮件数。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Amount")]
        public int MailCount { get; set; }
    }
}
