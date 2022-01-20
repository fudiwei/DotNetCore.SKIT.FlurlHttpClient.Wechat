namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/get_booking_info 接口的响应。</para>
    /// </summary>
    public class CgibinOAMeetingRoomGetBookingInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Booking
            {
                public static class Types
                {
                    public class Schedule
                    {
                        /// <summary>
                        /// 获取或设置预定开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                        public long StartTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置预定开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long EndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置会议 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("meeting_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("meeting_id")]
                        public string? MeetingId { get; set; }

                        /// <summary>
                        /// 获取或设置关联日程 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("schedule_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
                        public string? ScheduleId { get; set; }

                        /// <summary>
                        /// 获取或设置预定者的成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("booker")]
                        [System.Text.Json.Serialization.JsonPropertyName("booker")]
                        public string? BookerUserId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置会议室 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meetingroom_id")]
                [System.Text.Json.Serialization.JsonPropertyName("meetingroom_id")]
                public int MeetingRoomId { get; set; }

                /// <summary>
                /// 获取或设置排期列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("schedule")]
                [System.Text.Json.Serialization.JsonPropertyName("schedule")]
                public Types.Schedule[] ScheduleList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置会议室预定列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("booking_list")]
        [System.Text.Json.Serialization.JsonPropertyName("booking_list")]
        public Types.Booking[] BookingList { get; set; } = default!;
    }
}
