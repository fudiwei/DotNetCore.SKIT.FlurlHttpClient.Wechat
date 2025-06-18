namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.miniprogram_sharer_bind_status_change 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent2/callback/sharer_bind_staus_change.html ]]>
    /// </para>
    /// </summary>
    public class MiniProgramSharerBindStatusChangeEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置分享者的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        [System.Xml.Serialization.XmlElement("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置绑定状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_status")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_status")]
        [System.Xml.Serialization.XmlElement("bind_status")]
        public int BindStatus { get; set; }
    }
}
