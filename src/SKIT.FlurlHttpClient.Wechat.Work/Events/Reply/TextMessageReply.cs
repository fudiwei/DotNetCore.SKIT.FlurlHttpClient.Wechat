using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示被动回复文本消息的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90241#%E6%96%87%E6%9C%AC%E6%B6%88%E6%81%AF </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90377#%E6%96%87%E6%9C%AC%E6%B6%88%E6%81%AF </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90859#%E6%96%87%E6%9C%AC%E6%B6%88%E6%81%AF </para>
    /// </summary>
    public class TextMessageReply : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置消息内容。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Content")]
        public string Content { get; set; } = string.Empty;

        public TextMessageReply()
        {
            Event = null;
            MessageType = "text";
        }
    }
}
