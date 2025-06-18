namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.channels_ec_sharer_change 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/sharer/bindsharer.html ]]>
    /// </para>
    /// </summary>
    public class ChannelsECSharerChangeEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_status")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_status")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        [System.Xml.Serialization.XmlElement("bind_status")]
        public int BindStatus { get; set; }

        /// <summary>
        /// 获取或设置绑定分享员 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        [System.Xml.Serialization.XmlElement("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置分享员类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_type")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        [System.Xml.Serialization.XmlElement("sharer_type")]
        public int SharerType { get; set; }
    }
}
