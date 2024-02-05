namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.app_email_change 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97506 ]]>
    /// </para>
    /// </summary>
    public class AppEmailChangeEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置变更类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ChangeType")]
        [System.Text.Json.Serialization.JsonPropertyName("ChangeType")]
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ChangeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置新邮件数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Amount")]
        [System.Text.Json.Serialization.JsonPropertyName("Amount")]
        [System.Xml.Serialization.XmlElement("Amount")]
        public int MailCount { get; set; }
    }
}
