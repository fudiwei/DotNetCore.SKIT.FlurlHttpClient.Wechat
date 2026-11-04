namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/webinar/update_guest_list 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingWebinarUpdateGuestListRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Guest : CgibinMeetingCreateRequest.Types.Guest
            {
                /// <summary>
                /// 获取或设置嘉宾类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("guest_type")]
                [System.Text.Json.Serialization.JsonPropertyName("guest_type")]
                public int GuestType { get; set; }

                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置电子邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("email")]
                [System.Text.Json.Serialization.JsonPropertyName("email")]
                public string? Email { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string? MeetingId { get; set; }

        /// <summary>
        /// 获取或设置嘉宾列表。。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guests")]
        [System.Text.Json.Serialization.JsonPropertyName("guests")]
        public List<Types.Guest>? GuestList { get; set; }
    }
}
