using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    /// <summary>
    /// 表示微信 API 回调通知事件的基类。
    /// </summary>
    [Serializable]
    public class WechatApiEvent
    {
        public static class Types
        {
            [Newtonsoft.Json.JsonObject]
            public interface IJsonSerializable
            {
            }

            [System.Xml.Serialization.XmlRoot("xml")]
            public interface IXmlSerializable
            { 
            }
        }

        /// <summary>
        /// 获取或设置开发者账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ToUserName")]
        [System.Text.Json.Serialization.JsonPropertyName("ToUserName")]
        [System.Xml.Serialization.XmlElement("ToUserName", IsNullable = true)]
        public string? ToUserName { get; set; }

        /// <summary>
        /// 获取或设置发送方账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FromUserName")]
        [System.Text.Json.Serialization.JsonPropertyName("FromUserName")]
        [System.Xml.Serialization.XmlElement("FromUserName", IsNullable = true)]
        public string? FromUserName { get; set; }

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgType")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgType")]
        [System.Xml.Serialization.XmlElement("MsgType", IsNullable = true)]
        public string? MessageType { get; set; }

        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Event")]
        [System.Text.Json.Serialization.JsonPropertyName("Event")]
        [System.Xml.Serialization.XmlElement("Event", IsNullable = true)]
        public string? Event { get; set; }

        /// <summary>
        /// 获取或设置消息创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CreateTime")]
        [System.Text.Json.Serialization.JsonPropertyName("CreateTime")]
        [System.Xml.Serialization.XmlElement("CreateTime")]
        public long CreateTimestamp { get; set; }
    }
}
