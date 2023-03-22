namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/book_by_meeting 接口的响应。</para>
    /// </summary>
    public class CgibinOAMeetingRoomBookByMeetingResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置预定 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("booking_id")]
        [System.Text.Json.Serialization.JsonPropertyName("booking_id")]
        public string BookingId { get; set; } = default!;

        /// <summary>
        /// 获取或设置冲突日期的时间戳列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conflict_date")]
        [System.Text.Json.Serialization.JsonPropertyName("conflict_date")]
        public long[]? ConflictDateTimestampList { get; set; }
    }
}
