namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/realcontrol/close_screen_share 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingRealControlCloseScreenShareRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class OperatedUser : CgibinMeetingRealControlSetCoHostRequest.Types.OperatedUser
            {
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置被操作成员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operated_user")]
        [System.Text.Json.Serialization.JsonPropertyName("operated_user")]
        public Types.OperatedUser OperatedUser { get; set; } = new Types.OperatedUser();
    }
}
