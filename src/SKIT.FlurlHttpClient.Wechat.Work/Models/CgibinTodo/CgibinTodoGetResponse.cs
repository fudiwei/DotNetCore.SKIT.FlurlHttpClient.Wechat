namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/todo/get 接口的响应。</para>
    /// </summary>
    public class CgibinTodoGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Attendee
            {
                /// <summary>
                /// 获取或设置参与人成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置参与人待办状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }

            public class Reminder
            {
                /// <summary>
                /// 获取或设置提醒时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remind_time")]
                [System.Text.Json.Serialization.JsonPropertyName("remind_time")]
                public long RemindTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置待办内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = default!;

        /// <summary>
        /// 获取或设置创建人成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creator")]
        [System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string CreatorUserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置待办状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public long CreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置参与人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attendees")]
        [System.Text.Json.Serialization.JsonPropertyName("attendees")]
        public Types.Attendee[]? AttendeeList { get; set; }

        /// <summary>
        /// 获取或设置提醒列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reminders")]
        [System.Text.Json.Serialization.JsonPropertyName("reminders")]
        public Types.Reminder[]? ReminderList { get; set; }
    }
}
