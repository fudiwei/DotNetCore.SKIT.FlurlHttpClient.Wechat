namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/get_guests 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingGetGuestsResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Guest : CgibinMeetingGetInfoResponse.Types.Guest
            {
            }
        }

        /// <summary>
        /// 获取或设置嘉宾列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guests")]
        [System.Text.Json.Serialization.JsonPropertyName("guests")]
        public Types.Guest[] GuestList { get; set; } = default!;

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
    }
}
