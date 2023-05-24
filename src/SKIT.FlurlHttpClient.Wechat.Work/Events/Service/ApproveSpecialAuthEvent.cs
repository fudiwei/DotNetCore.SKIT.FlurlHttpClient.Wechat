namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.approve_special_auth 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/98959 </para>
    /// </summary>
    public class ApproveSpecialAuthEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SuiteId")]
        public string SuiteId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AuthCorpId")]
        public string AuthorizerCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置权限类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AuthType")]
        public string AuthType { get; set; } = default!;
    }
}
