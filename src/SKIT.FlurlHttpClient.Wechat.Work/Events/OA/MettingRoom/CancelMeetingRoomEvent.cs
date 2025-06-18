namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.cancel_meeting_room 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/95333 ]]>
    /// </para>
    /// </summary>
    public class CancelMeetingRoomEvent : WechatWorkEvent
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
