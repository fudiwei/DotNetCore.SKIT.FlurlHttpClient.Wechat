namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.refund 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/91932 </para>
    /// </summary>
    public class RefundEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SuiteId")]
        public string SuiteId { get; set; } = default!;

        /// <summary>
        /// 获取或设置购买方 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("PaidCorpId")]
        public string PayerCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("OrderId")]
        public string OrderId { get; set; } = default!;
    }
}
