namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/webinar/create 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingWebinarCreateResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = default!;

        /// <summary>
        /// 获取或设置会议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_code")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_code")]
        public string MeetingCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置会议主题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置会议开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置会议结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置观众观看限制类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admission_type")]
        [System.Text.Json.Serialization.JsonPropertyName("admission_type")]
        public int AdmissionType { get; set; }

        /// <summary>
        /// 获取或设置观众观看密码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("password")]
        [System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 获取或设置观众入会链接 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audience_join_link")]
        [System.Text.Json.Serialization.JsonPropertyName("audience_join_link")]
        public string? AudienceJoinLinkUrl { get; set; }

        /// <summary>
        /// 获取或设置嘉宾入会链接 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guest_join_link")]
        [System.Text.Json.Serialization.JsonPropertyName("guest_join_link")]
        public string? GuestJoinLink { get; set; }

        /// <summary>
        /// 获取或设置人工审核链接 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manual_check_link")]
        [System.Text.Json.Serialization.JsonPropertyName("manual_check_link")]
        public string? ManualCheckLinkUrl { get; set; }

        /// <summary>
        /// 获取或设置人工审核密码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manual_check_password")]
        [System.Text.Json.Serialization.JsonPropertyName("manual_check_password")]
        public string? ManualCheckPassword { get; set; }
    }
}
