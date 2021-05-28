using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.SCAN 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Receiving_event_pushes.html#%E6%89%AB%E6%8F%8F%E5%B8%A6%E5%8F%82%E6%95%B0%E4%BA%8C%E7%BB%B4%E7%A0%81%E4%BA%8B%E4%BB%B6 </para>
    /// </summary>
    public class ScanPushEvent : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置事件 Key，即创建二维码时的 SceneId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("EventKey")]
        public string EventKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置二维码的 Ticket。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Ticket")]
        public string Ticket { get; set; } = default!;
    }
}
