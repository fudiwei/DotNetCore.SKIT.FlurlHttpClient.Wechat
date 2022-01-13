namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.switch_workbench_mode 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/92535 </para>
    /// </summary>
    public class SwitchWorkbenchModeEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置自定义模式。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Mode")]
        public int Mode { get; set; }
    }
}
