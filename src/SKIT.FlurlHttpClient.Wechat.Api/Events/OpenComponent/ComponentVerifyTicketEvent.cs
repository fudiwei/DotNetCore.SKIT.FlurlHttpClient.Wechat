namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 INFO.component_verify_ticket 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/Before_Develop/component_verify_ticket.html </para>
    /// </summary>
    public class ComponentVerifyTicketEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置验证票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ComponentVerifyTicket")]
        [System.Text.Json.Serialization.JsonPropertyName("ComponentVerifyTicket")]
        [System.Xml.Serialization.XmlElement("ComponentVerifyTicket")]
        public string ComponentVerifyTicket { get; set; } = default!;
    }
}
