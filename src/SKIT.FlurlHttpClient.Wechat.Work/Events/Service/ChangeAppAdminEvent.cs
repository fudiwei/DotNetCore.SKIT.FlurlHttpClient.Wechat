namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.change_app_admin 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/95038 </para>
    /// </summary>
    public class ChangeAppAdminEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }
    }
}
