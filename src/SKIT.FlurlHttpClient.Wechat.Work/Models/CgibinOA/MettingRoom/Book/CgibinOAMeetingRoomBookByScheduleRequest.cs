namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/book_by_schedule 接口的请求。</para>
    /// </summary>
    public class CgibinOAMeetingRoomBookByScheduleRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议室 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingroom_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingroom_id")]
        public int MeetingRoomId { get; set; }

        /// <summary>
        /// 获取或设置日程 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
        public string ScheduleId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置预定者的成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("booker")]
        [System.Text.Json.Serialization.JsonPropertyName("booker")]
        public string BookerUserId { get; set; } = string.Empty;
    }
}
