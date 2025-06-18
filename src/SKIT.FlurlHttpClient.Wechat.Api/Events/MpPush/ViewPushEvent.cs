namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.VIEW 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Receiving_event_pushes.html#%E8%87%AA%E5%AE%9A%E4%B9%89%E8%8F%9C%E5%8D%95%E4%BA%8B%E4%BB%B6 ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Custom_Menus/Custom_Menu_Push_Events.html#1 ]]>
    /// </para>
    /// </summary>
    public class ViewPushEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置个性化菜单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MenuId")]
        [System.Text.Json.Serialization.JsonPropertyName("MenuId")]
        [System.Xml.Serialization.XmlElement("MenuId", IsNullable = true)]
        public string? MenuId { get; set; }

        /// <summary>
        /// 获取或设置事件 Key，即跳转的 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EventKey")]
        [System.Text.Json.Serialization.JsonPropertyName("EventKey")]
        [System.Xml.Serialization.XmlElement("EventKey")]
        public string EventKey { get; set; } = default!;
    }
}
