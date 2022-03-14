namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/get_booking_info_by_meeting_id 接口的响应。</para>
    /// </summary>
    public class CgibinOAMeetingRoomGetBookingInfoByMeetingIdResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Schedule : CgibinOAMeetingRoomGetBookingInfoResponse.Types.Booking.Types.Schedule
            {
            }
        }

        /// <summary>
        /// 获取或设置指定会议室 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingroom_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingroom_id")]
        public int MeetingRoomId { get; set; }

        /// <summary>
        /// 获取或设置排期信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule")]
        public Types.Schedule Schedule { get; set; } = default!;
    }
}
