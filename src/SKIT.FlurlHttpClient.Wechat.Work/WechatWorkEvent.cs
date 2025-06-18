namespace SKIT.FlurlHttpClient.Wechat.Work
{
    /// <summary>
    /// 表示微信 API 回调通知事件的基类。
    /// </summary>
    [Newtonsoft.Json.JsonObject]
    [System.Xml.Serialization.XmlRoot("xml")]
    public class WechatWorkEvent : ICommonWebhookEvent
    {
        /// <summary>
        /// 获取或设置企业 CorpId 或第三方应用的 SuiteId。
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
        /// 获取或设置消息创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CreateTime")]
        [System.Text.Json.Serialization.JsonPropertyName("CreateTime")]
        [System.Xml.Serialization.XmlElement("CreateTime", IsNullable = true)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("InfoType")]
        [System.Text.Json.Serialization.JsonPropertyName("InfoType")]
        [System.Xml.Serialization.XmlElement("InfoType", IsNullable = true)]
        public string? InfoType { get; set; }

        /// <summary>
        /// 获取或设置消息时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TimeStamp")]
        [System.Text.Json.Serialization.JsonPropertyName("TimeStamp")]
        [System.Xml.Serialization.XmlElement("TimeStamp", IsNullable = true)]
        public long? InfoTimestamp { get; set; }
    }
}
