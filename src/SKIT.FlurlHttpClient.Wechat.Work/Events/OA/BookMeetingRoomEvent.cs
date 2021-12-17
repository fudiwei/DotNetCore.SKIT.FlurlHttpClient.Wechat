namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.book_meeting_room 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/95333 </para>
    /// </summary>
    public class BookMeetingRoomEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IJsonSerializable, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置会议室 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MeetingRoomId")]
        [System.Text.Json.Serialization.JsonPropertyName("MeetingRoomId")]
        [System.Xml.Serialization.XmlElement("MeetingRoomId")]
        public int MeetingRoomId { get; set; } 

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MeetingId")]
        [System.Text.Json.Serialization.JsonPropertyName("MeetingId")]
        [System.Xml.Serialization.XmlElement("MeetingId")]
        public string MeetingId { get; set; } = default!;
    }
}
