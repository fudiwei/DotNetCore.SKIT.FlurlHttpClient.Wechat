using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 VIDEO 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Receiving_standard_messages.html#%E8%A7%86%E9%A2%91%E6%B6%88%E6%81%AF </para>
    /// </summary>
    public class VideoMessageEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable, WechatApiEvent.Types.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgId")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgId")]
        [System.Xml.Serialization.XmlElement("MsgId")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置视频消息 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MediaId")]
        [System.Text.Json.Serialization.JsonPropertyName("MediaId")]
        [System.Xml.Serialization.XmlElement("MediaId")]
        public string MediaId { get; set; } = default!;

        /// <summary>
        /// 获取或设置视频消息缩略图 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ThumbMediaId")]
        [System.Text.Json.Serialization.JsonPropertyName("ThumbMediaId")]
        [System.Xml.Serialization.XmlElement("ThumbMediaId")]
        public string ThumbnailMediaId { get; set; } = default!;
    }
}
