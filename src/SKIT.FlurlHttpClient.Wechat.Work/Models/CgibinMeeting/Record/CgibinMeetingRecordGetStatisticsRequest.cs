namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/record/get_statistics 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRecordGetStatisticsRequest : WechatWorkRequest
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

        /// <summary>
        /// 获取或设置查询起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置查询结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }
    }
}
