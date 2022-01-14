namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.qualification_verify_fail 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Account_Management/Wechat_Accreditation_Event_Push.html#1 </para>
    /// </summary>
    public class QualificationVerifyFailEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
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
        public string FailReason { get; set; } = default!;
    }
}
