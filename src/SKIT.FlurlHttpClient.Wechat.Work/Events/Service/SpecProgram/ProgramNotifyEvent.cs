namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.program_notify 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/100048 ]]>
    /// </para>
    /// </summary>
    public class ProgramNotifyEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置通知 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("NotifyId")]
        [System.Text.Json.Serialization.JsonPropertyName("NotifyId")]
        [System.Xml.Serialization.XmlElement("NotifyId")]
        public string NotifyId { get; set; } = default!;

        /// <summary>
        /// 获取或设置通知场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("NotifyScene")]
        [System.Text.Json.Serialization.JsonPropertyName("NotifyScene")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        [System.Xml.Serialization.XmlElement("NotifyScene")]
        public int NotifyScene { get; set; }
    }
}
