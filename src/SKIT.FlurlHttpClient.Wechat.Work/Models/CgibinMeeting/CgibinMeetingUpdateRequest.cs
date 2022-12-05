namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/update 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingUpdateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Attendee : CgibinMeetingCreateRequest.Types.Attendee
            {
            }

            public class Settings : CgibinMeetingCreateRequest.Types.Settings
            {
                public static new class Types
                {
                    public class Host : CgibinMeetingCreateRequest.Types.Settings.Types.Host
                    {
                    }

                    public class RingUser : CgibinMeetingCreateRequest.Types.Settings.Types.RingUser
                    {
                    }
                }

                /// <summary>
                /// 获取或设置会议主持人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hosts")]
                [System.Text.Json.Serialization.JsonPropertyName("hosts")]
                public new Types.Host? Host { get; set; }

                /// <summary>
                /// 获取或设置响铃用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ring_users")]
                [System.Text.Json.Serialization.JsonPropertyName("ring_users")]
                public new Types.RingUser? RingUser { get; set; }
            }

            public class Reminder : CgibinMeetingCreateRequest.Types.Reminder
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
        /// 获取或设置会议标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 获取或设置会议开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_start")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_start")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置会议持续时长（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_duration")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// 获取或设置会议描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置会议地点。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location")]
        [System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// 获取或设置日历 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cal_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cal_id")]
        public string? CalendarId { get; set; }

        /// <summary>
        /// 获取或设置参与者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attendees")]
        [System.Text.Json.Serialization.JsonPropertyName("attendees")]
        public Types.Attendee? Attendee { get; set; }

        /// <summary>
        /// 获取或设置会议设置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settings")]
        [System.Text.Json.Serialization.JsonPropertyName("settings")]
        public Types.Settings? Settings { get; set; }

        /// <summary>
        /// 获取或设置会议提醒信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reminders")]
        [System.Text.Json.Serialization.JsonPropertyName("reminders")]
        public Types.Reminder? Reminder { get; set; }

        /// <summary>
        /// 获取或设置授权方安装的应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }
    }
}
