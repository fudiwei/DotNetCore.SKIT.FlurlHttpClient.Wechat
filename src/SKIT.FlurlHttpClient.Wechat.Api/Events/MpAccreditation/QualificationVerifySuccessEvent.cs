namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.qualification_verify_success" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/guide/product/message/Receiving_event_pushes.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/message/Receiving_event_pushes.html ]]>
    /// </para>
    /// </summary>
    public class QualificationVerifySuccessEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ExpiredTime")]
        [System.Text.Json.Serialization.JsonPropertyName("ExpiredTime")]
        [System.Xml.Serialization.XmlElement("ExpiredTime")]
        public long ExpireTimestamp { get; set; }
    }
}
