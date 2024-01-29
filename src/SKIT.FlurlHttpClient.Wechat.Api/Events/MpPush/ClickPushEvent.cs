namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.CLICK 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Receiving_event_pushes.html#%E8%87%AA%E5%AE%9A%E4%B9%89%E8%8F%9C%E5%8D%95%E4%BA%8B%E4%BB%B6 </para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Custom_Menus/Custom_Menu_Push_Events.html#0 </para>
    /// </summary>
    public class ClickPushEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置事件 Key，即自定义菜单接口中的 Key 值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EventKey")]
        [System.Text.Json.Serialization.JsonPropertyName("EventKey")]
        [System.Xml.Serialization.XmlElement("EventKey")]
        public string EventKey { get; set; } = default!;
    }
}
