namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/cancel 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingCancelRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_meetingid")]
        public string? SubMeetingId { get; set; }
    }
}
