namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.qualification_verify_fail" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/guide/product/message/Receiving_event_pushes.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/message/Receiving_event_pushes.html ]]>
    /// </para>
    /// </summary>
    public class QualificationVerifyFailEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置失败时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FailTime")]
        [System.Text.Json.Serialization.JsonPropertyName("FailTime")]
        [System.Xml.Serialization.XmlElement("FailTime")]
        public long FailTimestamp { get; set; }

        /// <summary>
        /// 获取或设置失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FailReason")]
        [System.Text.Json.Serialization.JsonPropertyName("FailReason")]
        [System.Xml.Serialization.XmlElement("FailReason")]
        public string? FailReason { get; set; }
    }
}
