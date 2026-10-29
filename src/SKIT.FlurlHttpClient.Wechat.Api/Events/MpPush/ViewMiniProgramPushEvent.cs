namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.view_miniprogram" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/guide/product/message/Receiving_event_pushes.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/message/Receiving_event_pushes.html ]]>
    /// </para>
    /// </summary>
    public class ViewMiniProgramPushEvent : WechatApiEvent
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
        public string? EventKey { get; set; }
    }
}
