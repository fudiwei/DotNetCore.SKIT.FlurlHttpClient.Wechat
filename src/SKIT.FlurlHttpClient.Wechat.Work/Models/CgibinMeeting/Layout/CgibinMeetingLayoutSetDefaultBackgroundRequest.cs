namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/layout/set_default_background 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingLayoutSetDefaultBackgroundRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会议应用的背景 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("selected_background_id")]
        [System.Text.Json.Serialization.JsonPropertyName("selected_background_id")]
        public string SelectedBackgroundId { get; set; } = string.Empty;
    }
}
