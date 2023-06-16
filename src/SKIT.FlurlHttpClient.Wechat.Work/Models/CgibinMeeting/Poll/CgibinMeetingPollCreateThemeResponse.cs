namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/poll/create_theme 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingPollCreateThemeResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置投票主题 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poll_theme_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poll_theme_id")]
        public string PollThemeId { get; set; } = default!;
    }
}
