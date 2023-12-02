namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/bookinfo/get 接口的响应。</para>
    /// </summary>
    public class CgibinOAMeetingRoomBookInfoGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Schedule : CgibinOAMeetingRoomGetBookingInfoResponse.Types.Booking.Types.Schedule
            {
                /// <summary>
                /// 获取或设置预定 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("booking_id")]
                [System.Text.Json.Serialization.JsonPropertyName("booking_id")]
                public string BookingId { get; set; } = default!;

                /// <summary>
                /// 获取或设置主预定 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("master_booking_id")]
                [System.Text.Json.Serialization.JsonPropertyName("master_booking_id")]
                public string? MasterBookingId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会议室 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingroom_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingroom_id")]
        public int MeetingRoomId { get; set; }

        /// <summary>
        /// 获取或设置预定信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule")]
        public Types.Schedule Schedule { get; set; } = default!;
    }
}
