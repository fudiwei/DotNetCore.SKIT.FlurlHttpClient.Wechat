namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/layout/delete_background 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingLayoutDeleteBackgroundRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置背景 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("background_id")]
        [System.Text.Json.Serialization.JsonPropertyName("background_id")]
        public string BackgroundId { get; set; } = string.Empty;
    }
}
