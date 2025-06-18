namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.suite_ticket 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90628 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90794 ]]>
    /// </para>
    /// </summary>
    public class SuiteTicketEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SuiteId")]
        [System.Text.Json.Serialization.JsonPropertyName("SuiteId")]
        [System.Xml.Serialization.XmlElement("SuiteId")]
        public string SuiteId { get; set; } = default!;

        /// <summary>
        /// 获取或设置第三方应用的 SuiteTicket。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SuiteTicket")]
        [System.Text.Json.Serialization.JsonPropertyName("SuiteTicket")]
        [System.Xml.Serialization.XmlElement("SuiteTicket")]
        public string SuiteTicket { get; set; } = default!;
    }
}
