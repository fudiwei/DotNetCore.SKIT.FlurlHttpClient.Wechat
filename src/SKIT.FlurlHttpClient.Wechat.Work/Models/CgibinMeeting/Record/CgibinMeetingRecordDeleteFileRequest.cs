namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/record/delete_file 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRecordDeleteFileRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会议录制文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_file_id")]
        [System.Text.Json.Serialization.JsonPropertyName("record_file_id")]
        public string RecordFileId { get; set; } = string.Empty;
    }
}
