namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示回复 EVENT.transport_add_tips 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-provider/immediateDelivery.onPreAuthCodeGet.html </para>
    /// </summary>
    public class TransportAddTipsReply : WechatApiEvent
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

        public TransportAddTipsReply()
        {
            MessageType = "event";
            Event = "transport_add_tips";
        }
    }
}
