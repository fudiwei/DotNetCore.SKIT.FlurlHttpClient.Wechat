namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/get_booking_info_by_meeting_id 接口的请求。</para>
    /// </summary>
    public class CgibinOAMeetingRoomGetBookingInfoByMeetingIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置指定会议室 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingroom_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingroom_id")]
        public int MeetingRoomId { get; set; }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_id")]
        public string MeetingId { get; set; } = string.Empty;
    }
}
