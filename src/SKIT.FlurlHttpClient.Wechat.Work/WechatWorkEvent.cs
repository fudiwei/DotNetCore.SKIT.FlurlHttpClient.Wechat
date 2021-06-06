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
        /// 获取或设置企业 CorpId 或第三方应用的 SuiteId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ToUserName")]
        [System.Text.Json.Serialization.JsonPropertyName("ToUserName")]
        [XmlElement("ToUserName", IsNullable = true)]
        public string? ToUserName { get; set; }

        /// <summary>
        /// 获取或设置发送方账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FromUserName")]
        [System.Text.Json.Serialization.JsonPropertyName("FromUserName")]
        [XmlElement("FromUserName", IsNullable = true)]
        public string? FromUserName { get; set; }

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgType")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgType")]
        [XmlElement("MsgType", IsNullable = true)]
        public string? MessageType { get; set; }

        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Event")]
        [System.Text.Json.Serialization.JsonPropertyName("Event")]
        [XmlElement("Event", IsNullable = true)]
        public string? Event { get; set; }

        /// <summary>
        /// 获取或设置消息创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CreateTime")]
        [System.Text.Json.Serialization.JsonPropertyName("CreateTime")]
        [XmlElement("CreateTime", IsNullable = true)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [XmlElement("InfoType", IsNullable = true)]
        public string? InfoType { get; set; }

        /// <summary>
        /// 获取或设置消息时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [XmlElement("TimeStamp", IsNullable = true)]
        public long? InfoTimestamp { get; set; }
    }
}
