namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 INFO.unauthorized 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/Before_Develop/authorize_event.html ]]>
    /// </para>
    /// </summary>
    public class ComponentUnauthorizedEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置授权方 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthorizerAppid")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthorizerAppid")]
        [System.Xml.Serialization.XmlElement("AuthorizerAppid")]
        public string AuthorizerAppId { get; set; } = default!;
    }
}
