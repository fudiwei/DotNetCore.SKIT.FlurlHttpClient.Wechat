using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    /// <summary>
    /// 表示微信 API 回调通知事件的基类。
    /// </summary>
    [Serializable]
    public class WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置企业 CorpId。
        /// </summary>
        [XmlElement("ToUserName", IsNullable = true)]
        public string? ToUserName { get; set; }

        /// <summary>
        /// 获取或设置发送方账号。
        /// </summary>
        [XmlElement("FromUserName", IsNullable = true)]
        public string? FromUserName { get; set; }

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [XmlElement("MsgType", IsNullable = true)]
        public string? MessageType { get; set; }

        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [XmlElement("Event", IsNullable = true)]
        public string? Event { get; set; }

        /// <summary>
        /// 获取或设置消息创建时间。
        /// </summary>
        [XmlElement("CreateTime")]
        public long CreateTimestamp { get; set; }
    }
}
