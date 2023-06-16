namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/layout/set_default 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingLayoutSetDefaultRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会议应用的布局 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("selected_layout_id")]
        [System.Text.Json.Serialization.JsonPropertyName("selected_layout_id")]
        public string SelectedLayoutId { get; set; } = string.Empty;
    }
}
