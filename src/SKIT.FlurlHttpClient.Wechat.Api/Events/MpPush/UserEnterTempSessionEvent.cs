namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.user_enter_tempsession 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/customer-message/receive.html ]]>
    /// </para>
    /// </summary>
    public class UserEnterTempSessionEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置会话来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SessionFrom")]
        [System.Text.Json.Serialization.JsonPropertyName("SessionFrom")]
        [System.Xml.Serialization.XmlElement("SessionFrom")]
        public string SessionFrom { get; set; } = default!;
    }
}
