namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.doc_change 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/97833 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/97834 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/97835 </para>
    /// </summary>
    public class DocumentChangeEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置变更类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ChangeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置文档 ID 列表。
        /// </summary>
        [System.Xml.Serialization.XmlElement("DocId", Type = typeof(string))]
        public string[] DocumentIdList { get; set; } = default!;
    }
}
