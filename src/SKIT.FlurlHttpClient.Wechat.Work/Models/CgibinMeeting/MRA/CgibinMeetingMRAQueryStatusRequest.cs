namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/mra/query_status 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingMRAQueryStatusRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会议的成员临时 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tmp_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("tmp_openid")]
        public string TempOpenId { get; set; } = string.Empty;
    }
}
