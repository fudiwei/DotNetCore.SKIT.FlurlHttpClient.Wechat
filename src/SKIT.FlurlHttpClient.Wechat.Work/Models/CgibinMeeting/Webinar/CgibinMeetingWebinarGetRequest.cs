namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/webinar/get 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingWebinarGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。与字段 <see cref="MeetingCode"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string? MeetingId { get; set; }

        /// <summary>
        /// 获取或设置入会码。与字段 <see cref="MeetingId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_code")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_code")]
        public string? MeetingCode { get; set; }
    }
}
