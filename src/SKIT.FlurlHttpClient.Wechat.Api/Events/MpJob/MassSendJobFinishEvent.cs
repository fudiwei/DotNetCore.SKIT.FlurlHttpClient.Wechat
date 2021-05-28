using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.MASSSENDJOBFINISH 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Batch_Sends_and_Originality_Checks.html#7 </para>
    /// </summary>
    public class MassSendJobFinishEvent : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("MsgID")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置发送状态。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置总人数。
        /// </summary>
        [System.Xml.Serialization.XmlElement("TotalCount")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置过滤人数。
        /// </summary>
        [System.Xml.Serialization.XmlElement("FilterCount")]
        public int FilterCount { get; set; }

        /// <summary>
        /// 获取或设置发送成功人数。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SentCount")]
        public int SentCount { get; set; }

        /// <summary>
        /// 获取或设置发送失败人数。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ErrorCount")]
        public int ErrorCount { get; set; }
    }
}
