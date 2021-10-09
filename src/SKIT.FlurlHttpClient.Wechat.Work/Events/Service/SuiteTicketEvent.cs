using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.suite_ticket 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90628 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90794 </para>
    /// </summary>
    public class SuiteTicketEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SuiteId")]
        public string SuiteId { get; set; } = default!;

        /// <summary>
        /// 获取或设置第三方应用的 SuiteTicket。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SuiteTicket")]
        public string SuiteTicket { get; set; } = default!;
    }
}
