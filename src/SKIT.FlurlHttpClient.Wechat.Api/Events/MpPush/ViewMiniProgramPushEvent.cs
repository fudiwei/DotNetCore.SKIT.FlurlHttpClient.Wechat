namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.view_miniprogram 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Custom_Menus/Custom_Menu_Push_Events.html#8 </para>
    /// </summary>
    public class ViewMiniProgramPushEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置个性化菜单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MenuId")]
        [System.Text.Json.Serialization.JsonPropertyName("MenuId")]
        [System.Xml.Serialization.XmlElement("MenuId", IsNullable = true)]
        public string? MenuId { get; set; }

        /// <summary>
        /// 获取或设置事件 Key，即跳转的小程序路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EventKey")]
        [System.Text.Json.Serialization.JsonPropertyName("EventKey")]
        [System.Xml.Serialization.XmlElement("EventKey")]
        public string EventKey { get; set; } = default!;
    }
}
