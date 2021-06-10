using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 LINK 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90239 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90375 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90855 </para>
    /// </summary>
    public class LinkMessageEvent : WechatWorkEvent, WechatWorkEvent.Types.IXmlSerializable
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
        /// 获取或设置标题。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置描述。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 获取或设置跳转链接 URL。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 获取或设置封面图片 URL。
        /// </summary>
        [System.Xml.Serialization.XmlElement("PicUrl")]
        public string PictureUrl { get; set; } = default!;
    }
}
