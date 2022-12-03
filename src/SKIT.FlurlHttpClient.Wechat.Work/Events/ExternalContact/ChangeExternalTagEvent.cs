namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.change_external_tag 或 INFO.change_external_tag 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/92130 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/92277 </para>
    /// </summary>
    public class ChangeExternalTagEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SuiteId", IsNullable = true)]
        public string? SuiteId { get; set; }

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AuthCorpId", IsNullable = true)]
        public string? AuthorizerCorpId { get; set; }

        /// <summary>
        /// 获取或设置变更类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ChangeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置 ID 类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("TagType", IsNullable = true)]
        public string? IdType { get; set; }

        /// <summary>
        /// 获取或设置企业标签或标签分组 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Id", IsNullable = true)]
        public string? TagOrGroupId { get; set; }

        /// <summary>
        /// 获取或设置规则组 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("StrategyId", IsNullable = true)]
        public string? StrategyId { get; set; }
    }
}
