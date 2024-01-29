namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.add_schedule 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/93651 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/93704 </para>
    /// </summary>
    public class AddScheduleEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置日程 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ScheduleId")]
        [System.Text.Json.Serialization.JsonPropertyName("ScheduleId")]
        [System.Xml.Serialization.XmlElement("ScheduleId")]
        public string ScheduleId { get; set; } = default!;

        /// <summary>
        /// 获取或设置日历 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CalId")]
        [System.Text.Json.Serialization.JsonPropertyName("CalId")]
        [System.Xml.Serialization.XmlElement("CalId")]
        public string CalendarId { get; set; } = default!;
    }
}
