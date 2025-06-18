namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/record/delete 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRecordDeleteRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会议录制 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_record_id")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_record_id")]
        public string RecordId { get; set; } = string.Empty;
    }
}
