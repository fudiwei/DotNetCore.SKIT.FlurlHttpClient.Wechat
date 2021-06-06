using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.MASSSENDJOBFINISH 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Batch_Sends_and_Originality_Checks.html#7 </para>
    /// </summary>
    public class MassSendJobFinishEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable, WechatApiEvent.Types.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgID")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgID")]
        [System.Xml.Serialization.XmlElement("MsgID")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置发送状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Status")]
        [System.Text.Json.Serialization.JsonPropertyName("Status")]
        [System.Xml.Serialization.XmlElement("Status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置总人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TotalCount")]
        [System.Text.Json.Serialization.JsonPropertyName("TotalCount")]
        [System.Xml.Serialization.XmlElement("TotalCount")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置过滤人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FilterCount")]
        [System.Text.Json.Serialization.JsonPropertyName("FilterCount")]
        [System.Xml.Serialization.XmlElement("FilterCount")]
        public int FilterCount { get; set; }

        /// <summary>
        /// 获取或设置发送成功人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SentCount")]
        [System.Text.Json.Serialization.JsonPropertyName("SentCount")]
        [System.Xml.Serialization.XmlElement("SentCount")]
        public int SentCount { get; set; }

        /// <summary>
        /// 获取或设置发送失败人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ErrorCount")]
        [System.Text.Json.Serialization.JsonPropertyName("ErrorCount")]
        [System.Xml.Serialization.XmlElement("ErrorCount")]
        public int ErrorCount { get; set; }
    }
}
