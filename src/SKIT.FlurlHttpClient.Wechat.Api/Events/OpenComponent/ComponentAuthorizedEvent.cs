namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 INFO.authorized 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/Before_Develop/authorize_event.html ]]>
    /// </para>
    /// </summary>
    public class ComponentAuthorizedEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置授权方 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthorizerAppid")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthorizerAppid")]
        [System.Xml.Serialization.XmlElement("AuthorizerAppid")]
        public string AuthorizerAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置预授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PreAuthCode")]
        [System.Text.Json.Serialization.JsonPropertyName("PreAuthCode")]
        [System.Xml.Serialization.XmlElement("PreAuthCode")]
        public string PreAuthCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthorizationCode")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthorizationCode")]
        [System.Xml.Serialization.XmlElement("AuthorizationCode")]
        public string AuthCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权码过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthorizationCodeExpiredTime")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthorizationCodeExpiredTime")]
        [System.Xml.Serialization.XmlElement("AuthorizationCodeExpiredTime")]
        public long AuthCodeExpireTimestamp { get; set; }
    }
}
