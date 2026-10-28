namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/meetingroom/cancel_book 接口的请求。</para>
    /// </summary>
    public class CgibinOAMeetingRoomCancelBookRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_id")]
        public string? MeetingId { get; set; }

        /// <summary>
        /// 获取或设置是否保留关联日程。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keep_schedule")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("keep_schedule")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
        public bool? IsKeepSchedule { get; set; }
    }
}
