namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.add_calendar 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/93651 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/93704 </para>
    /// </summary>
    public class AddCalendarEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IJsonSerializable, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置日历 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CalId")]
        [System.Text.Json.Serialization.JsonPropertyName("CalId")]
        [System.Xml.Serialization.XmlElement("CalId")]
        public string CalendarId { get; set; } = default!;
    }
}
