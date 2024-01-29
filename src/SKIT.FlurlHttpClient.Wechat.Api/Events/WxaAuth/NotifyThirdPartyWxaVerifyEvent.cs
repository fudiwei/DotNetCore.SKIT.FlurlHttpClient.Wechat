namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 INFO.notify_3rd_wxa_wxverify 事件的数据。</para>
    /// <para>https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/weapp-wxverify/secwxaapi_wxaauth.html </para>
    /// </summary>
    public class NotifyThirdPartyWxaVerifyEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        [System.Xml.Serialization.XmlElement("appid")]
        public string AuthorizerAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置认证过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expired")]
        [System.Text.Json.Serialization.JsonPropertyName("expired")]
        [System.Xml.Serialization.XmlElement("expired")]
        public long ExpireTimestamp { get; set; }

        /// <summary>
        /// 获取或设置提醒消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        [System.Xml.Serialization.XmlElement("message", IsNullable = true)]
        public string? Message { get; set; }
    }
}
