namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.unlicensed_notify 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/95716 </para>
    /// </summary>
    public class UnlicensedNotifyEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }
    }
}
