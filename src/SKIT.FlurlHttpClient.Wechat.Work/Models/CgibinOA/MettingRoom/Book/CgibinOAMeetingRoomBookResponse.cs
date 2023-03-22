namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/book 接口的响应。</para>
    /// </summary>
    public class CgibinOAMeetingRoomBookResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置预定 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("booking_id")]
        [System.Text.Json.Serialization.JsonPropertyName("booking_id")]
        public string BookingId { get; set; } = default!;

        /// <summary>
        /// 获取或设置关联日程 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
        public string? ScheduleId { get; set; }
    }
}
