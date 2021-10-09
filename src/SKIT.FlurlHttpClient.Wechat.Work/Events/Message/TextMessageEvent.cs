using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 TEXT 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90239 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90375 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90855 </para>
    /// </summary>
    public class TextMessageEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("MsgId")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置消息内容。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Content")]
        public string Content { get; set; } = default!;
    }
}
