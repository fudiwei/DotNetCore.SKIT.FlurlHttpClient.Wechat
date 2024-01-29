namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.user_authorization_revoke 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/OA_Web_Apps/authorization_change.html </para>
    /// </summary>
    public class UserAuthorizationRevokeEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AppID")]
        [System.Text.Json.Serialization.JsonPropertyName("AppID")]
        [System.Xml.Serialization.XmlElement("AppID")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OpenID")]
        [System.Text.Json.Serialization.JsonPropertyName("OpenID")]
        [System.Xml.Serialization.XmlElement("OpenID")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户撤回的授权信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("RevokeInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("RevokeInfo")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
        [System.Xml.Serialization.XmlElement("RevokeInfo", IsNullable = true)]
        public string? RevokeInfo { get; set; }
    }
}
