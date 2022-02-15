﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 IMAGE 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Receiving_standard_messages.html#%E5%9B%BE%E7%89%87%E6%B6%88%E6%81%AF </para>
    /// </summary>
    public class ImageMessageEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgId")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgId")]
        [System.Xml.Serialization.XmlElement("MsgId")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PicUrl")]
        [System.Text.Json.Serialization.JsonPropertyName("PicUrl")]
        [System.Xml.Serialization.XmlElement("PicUrl")]
        public string PictureUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置图片消息 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MediaId")]
        [System.Text.Json.Serialization.JsonPropertyName("MediaId")]
        [System.Xml.Serialization.XmlElement("MediaId")]
        public string MediaId { get; set; } = default!;
    }
}
