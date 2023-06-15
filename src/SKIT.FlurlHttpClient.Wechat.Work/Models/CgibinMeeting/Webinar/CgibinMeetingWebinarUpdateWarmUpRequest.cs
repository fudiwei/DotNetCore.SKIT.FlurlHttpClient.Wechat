namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/webinar/update_warm_up 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingWebinarUpdateWarmUpRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置暖场图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warm_up_picture")]
        [System.Text.Json.Serialization.JsonPropertyName("warm_up_picture")]
        public string? WarmUpPictureUrl { get; set; }

        /// <summary>
        /// 获取或设置暖场视频 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warm_up_video")]
        [System.Text.Json.Serialization.JsonPropertyName("warm_up_video")]
        public string? WarmUpVideoUrl { get; set; }

        /// <summary>
        /// 获取或设置是否允许参会者在暖场中邀请成员。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_attendees_invite_others")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_attendees_invite_others")]
        public bool? AllowAttendeesInviteOthers { get; set; }
    }
}
