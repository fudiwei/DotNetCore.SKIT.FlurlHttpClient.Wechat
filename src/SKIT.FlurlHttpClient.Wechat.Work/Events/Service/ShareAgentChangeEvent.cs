namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.share_agent_change 或 INFO.share_agent_change 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90240 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/93373 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90376 </para>
    /// </summary>
    public class ShareAgentChangeEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SuiteId", IsNullable = true)]
        public string? SuiteId { get; set; }

        /// <summary>
        /// 获取或设置上级企业 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("CorpId", IsNullable = true)]
        public string? ParentCorpId { get; set; }

        /// <summary>
        /// 获取或设置上级企业应用 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AgentId")]
        public int ParentAgentId { get; set; }

        /// <summary>
        /// 获取或设置下级企业应用 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AppId", IsNullable = true)]
        public int? AgentId { get; set; }
    }
}
