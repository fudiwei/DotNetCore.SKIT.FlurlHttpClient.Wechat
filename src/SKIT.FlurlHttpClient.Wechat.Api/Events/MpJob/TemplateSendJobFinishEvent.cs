namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.TEMPLATESENDJOBFINISH 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Template_Message_Interface.html#%E4%BA%8B%E4%BB%B6%E6%8E%A8%E9%80%81 </para>
    /// </summary>
    public class TemplateSendJobFinishEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgId")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgId")]
        [System.Xml.Serialization.XmlElement("MsgID")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置发送状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Status")]
        [System.Text.Json.Serialization.JsonPropertyName("Status")]
        [System.Xml.Serialization.XmlElement("Status")]
        public string Status { get; set; } = default!;
    }
}
