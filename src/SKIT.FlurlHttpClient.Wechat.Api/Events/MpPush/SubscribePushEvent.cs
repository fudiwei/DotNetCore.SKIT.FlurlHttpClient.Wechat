namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.subscribe" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/guide/product/message/Receiving_event_pushes.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/message/Receiving_event_pushes.html ]]>
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
