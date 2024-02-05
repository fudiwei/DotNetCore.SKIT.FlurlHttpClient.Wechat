namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.subscribe 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Receiving_event_pushes.html#%E5%85%B3%E6%B3%A8-%E5%8F%96%E6%B6%88%E5%85%B3%E6%B3%A8%E4%BA%8B%E4%BB%B6 ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Receiving_event_pushes.html#%E6%89%AB%E6%8F%8F%E5%B8%A6%E5%8F%82%E6%95%B0%E4%BA%8C%E7%BB%B4%E7%A0%81%E4%BA%8B%E4%BB%B6 ]]>
    /// </para>
    /// </summary>
    public class SubscribePushEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置事件 Key，即创建二维码时的 SceneId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EventKey")]
        [System.Text.Json.Serialization.JsonPropertyName("EventKey")]
        [System.Xml.Serialization.XmlElement("EventKey", IsNullable = true)]
        public string? EventKey { get; set; }

        /// <summary>
        /// 获取或设置二维码的 Ticket。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("Ticket")]
        [System.Xml.Serialization.XmlElement("Ticket", IsNullable = true)]
        public string? Ticket { get; set; }
    }
}
