using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.click 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90240 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90376 </para>
    /// </summary>
    public class ClickPushEvent : WechatWorkEvent, WechatWorkEvent.Types.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置事件 Key，即自定义菜单接口中的 Key 值。
        /// </summary>
        [System.Xml.Serialization.XmlElement("EventKey")]
        public string EventKey { get; set; } = default!;
    }
}
