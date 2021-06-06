using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 VOICE 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Receiving_standard_messages.html#%E8%AF%AD%E9%9F%B3%E6%B6%88%E6%81%AF </para>
    /// </summary>
    public class VoiceMessageEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable, WechatApiEvent.Types.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgId")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgId")]
        [System.Xml.Serialization.XmlElement("MsgId")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置语音格式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Format")]
        [System.Text.Json.Serialization.JsonPropertyName("Format")]
        [System.Xml.Serialization.XmlElement("Format")]
        public string Format { get; set; } = default!;

        /// <summary>
        /// 获取或设置语音消息 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MediaId")]
        [System.Text.Json.Serialization.JsonPropertyName("MediaId")]
        [System.Xml.Serialization.XmlElement("MediaId")]
        public string MediaId { get; set; } = default!;
    }
}
