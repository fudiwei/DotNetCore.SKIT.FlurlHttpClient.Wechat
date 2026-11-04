namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/get_realtime_attendee_list 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingGetRealtimeAttendeeListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Attendee : CgibinMeetingGetAttendeeListResponse.Types.Attendee
            {
            }
        }

        /// <summary>
        /// 获取或设置参与者列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attendees")]
        [System.Text.Json.Serialization.JsonPropertyName("attendees")]
        public List<Types.Attendee>? AttendeeList { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
