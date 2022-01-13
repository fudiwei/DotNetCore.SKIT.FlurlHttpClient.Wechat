namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.living_status_change 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/94145 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/94308 </para>
    /// </summary>
    public class LivingStatusChangeEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置直播 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("LivingId")]
        public string LivingId { get; set; } = default!;

        /// <summary>
        /// 获取或设置直播状态。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Status")]
        public int Status { get; set; }
    }
}
