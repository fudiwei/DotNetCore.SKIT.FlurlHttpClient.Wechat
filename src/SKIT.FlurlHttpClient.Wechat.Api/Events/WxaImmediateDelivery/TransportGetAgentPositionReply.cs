namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示回复 EVENT.transport_get_agent_pos 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-provider/immediateDelivery.onPreAuthCodeGet.html ]]>
    /// </para>
    /// </summary>
    public class TransportGetAgentPositionReply : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resultcode")]
        [System.Text.Json.Serialization.JsonPropertyName("resultcode")]
        [System.Xml.Serialization.XmlElement("resultcode")]
        public int ResultCode { get; set; }

        /// <summary>
        /// 获取或设置错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resultmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("resultmsg")]
        [System.Xml.Serialization.XmlElement("resultmsg", IsNullable = true)]
        public string? ResultMessage { get; set; }

        /// <summary>
        /// 获取或设置经度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lng")]
        [System.Text.Json.Serialization.JsonPropertyName("lng")]
        [System.Xml.Serialization.XmlElement("lng")]
        public decimal Longitude { get; set; }

        /// <summary>
        /// 获取或设置错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lat")]
        [System.Text.Json.Serialization.JsonPropertyName("lat")]
        [System.Xml.Serialization.XmlElement("lat")]
        public decimal Latitude { get; set; }

        /// <summary>
        /// 获取或设置和目的地距离（单位：米）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distance")]
        [System.Text.Json.Serialization.JsonPropertyName("distance")]
        [System.Xml.Serialization.XmlElement("distance")]
        public int? Distance { get; set; }

        /// <summary>
        /// 获取或设置预计还剩多久送达时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reach_time")]
        [System.Text.Json.Serialization.JsonPropertyName("reach_time")]
        [System.Xml.Serialization.XmlElement("reach_time")]
        public int? EstimatedReachTime { get; set; }

        public TransportGetAgentPositionReply()
        {
            MessageType = "event";
            Event = "transport_get_agent_pos";
        }
    }
}
