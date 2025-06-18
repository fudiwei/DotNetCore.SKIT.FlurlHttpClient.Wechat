namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/bookinfo/get 接口的请求。</para>
    /// </summary>
    public class CgibinOAMeetingRoomBookInfoGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议室 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingroom_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingroom_id")]
        public int MeetingRoomId { get; set; }

        /// <summary>
        /// 获取或设置预定 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("booking_id")]
        [System.Text.Json.Serialization.JsonPropertyName("booking_id")]
        public string BookingId { get; set; } = string.Empty;
    }
}
