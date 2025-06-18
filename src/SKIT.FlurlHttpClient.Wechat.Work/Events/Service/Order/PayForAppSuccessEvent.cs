namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.pay_for_app_success 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91931 ]]>
    /// </para>
    /// </summary>
    public class PayForAppSuccessEvent : WechatWorkEvent
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
