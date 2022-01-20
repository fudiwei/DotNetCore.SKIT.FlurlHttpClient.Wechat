namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.change_school_contact 或 INFO.change_school_contact 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/92032 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/92052 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/92051 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/92050 </para>
    /// </summary>
    public class ChangeSchoolContactEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
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
        /// 获取或设置操作类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ActionType { get; set; } = default!;

        /// <summary>
        /// 获取或设置学生/家长账号或部门 ID（即班级）。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Id", IsNullable = true)]
        public string? StudentOrParentOrDepartmentId { get; set; }
    }
}
