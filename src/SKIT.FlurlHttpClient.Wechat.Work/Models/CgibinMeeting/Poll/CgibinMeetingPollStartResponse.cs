namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/poll/start 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingPollStartResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置投票 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poll_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poll_id")]
        public string PollId { get; set; } = default!;
    }
}
