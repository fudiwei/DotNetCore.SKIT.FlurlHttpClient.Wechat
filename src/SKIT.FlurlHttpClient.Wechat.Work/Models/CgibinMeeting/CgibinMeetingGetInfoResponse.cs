namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/get_info 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingGetInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Attendee
            {
                public static class Types
                {
                    public class User
                    {
                        /// <summary>
                        /// 获取或设置参与者成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string UserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置参与者与会状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }

                    public class ExternalUser
                    {
                        /// <summary>
                        /// 获取或设置外部联系人临时 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tmp_external_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("tmp_external_userid")]
                        public string TempExternalUserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置外部联系人与会状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }

                    public class Device
                    {
                        /// <summary>
                        /// 获取或设置设备序列号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("device_sn")]
                        [System.Text.Json.Serialization.JsonPropertyName("device_sn")]
                        public string DeviceSerialNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置设备与会状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置参与者成员列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("member")]
                [System.Text.Json.Serialization.JsonPropertyName("member")]
                public Types.User[] UserList { get; set; } = default!;

                /// <summary>
                /// 获取或设置外部联系人列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tmp_external_user")]
                [System.Text.Json.Serialization.JsonPropertyName("tmp_external_user")]
                public Types.ExternalUser[] ExternalUserList { get; set; } = default!;

                /// <summary>
                /// 获取或设置设备列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device")]
                [System.Text.Json.Serialization.JsonPropertyName("device")]
                public Types.Device[] DeviceList { get; set; } = default!;
            }

            public class Settings
            {
                public static class Types
                {
                    public class Host
                    {
                        /// <summary>
                        /// 获取或设置企业成员的 UserId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string[]? UserIdList { get; set; }
                    }

                    public class RingUser
                    {
                        /// <summary>
                        /// 获取或设置企业成员的 UserId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userids")]
                        public string[]? UserIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置入会密码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("password")]
                [System.Text.Json.Serialization.JsonPropertyName("password")]
                public string? Password { get; set; }

                /// <summary>
                /// 获取或设置是否开启等候室。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_waiting_room")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_waiting_room")]
                public bool EnableWaitingRoom { get; set; }

                /// <summary>
                /// 获取或设置是否允许成员在主持人进会前加入。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allow_enter_before_host")]
                [System.Text.Json.Serialization.JsonPropertyName("allow_enter_before_host")]
                public bool AllowEnterBeforeHost { get; set; }

                /// <summary>
                /// 获取或设置是否允许外部成员入会。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allow_external_user")]
                [System.Text.Json.Serialization.JsonPropertyName("allow_external_user")]
                public bool AllowExternalUser { get; set; }

                /// <summary>
                /// 获取或设置是否开启屏幕水印。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_screen_watermark")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_screen_watermark")]
                public bool EnableScreenWatermark { get; set; }

                /// <summary>
                /// 获取或设置成员入会时静音模式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_enter_mute")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_enter_mute")]
                public int EnterMuteMode { get; set; }

                /// <summary>
                /// 获取或设置会议开始提醒范围。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remind_scope")]
                [System.Text.Json.Serialization.JsonPropertyName("remind_scope")]
                public int? RemindScope { get; set; }

                /// <summary>
                /// 获取或设置会议主持人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hosts")]
                [System.Text.Json.Serialization.JsonPropertyName("hosts")]
                public Types.Host? Host { get; set; }

                /// <summary>
                /// 获取或设置响铃用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ring_users")]
                [System.Text.Json.Serialization.JsonPropertyName("ring_users")]
                public Types.RingUser? RingUser { get; set; }
            }

            public class Reminder
            {
                /// <summary>
                /// 获取或设置是否重复会议。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_repeat")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_repeat")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsRepeat { get; set; }

                /// <summary>
                /// 获取或设置重复类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("repeat_type")]
                [System.Text.Json.Serialization.JsonPropertyName("repeat_type")]
                public int? RepeatType { get; set; }

                /// <summary>
                /// 获取或设置重复结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("repeat_until")]
                [System.Text.Json.Serialization.JsonPropertyName("repeat_until")]
                public long? RepeatUntilTimestamp { get; set; }

                /// <summary>
                /// 获取或设置重复间隔。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("repeat_interval")]
                [System.Text.Json.Serialization.JsonPropertyName("repeat_interval")]
                public int? RepeatInterval { get; set; }

                /// <summary>
                /// 获取或设置会议开始前多久提醒（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remind_before")]
                [System.Text.Json.Serialization.JsonPropertyName("remind_before")]
                public int[]? RemindBeforeEventTimeList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = default!;

        /// <summary>
        /// 获取或设置管理员成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admin_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("admin_userid")]
        public string AdminUserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置发起者所在主部门 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_department")]
        [System.Text.Json.Serialization.JsonPropertyName("main_department")]
        public long? AdminMainDepartmentId { get; set; }

        /// <summary>
        /// 获取或设置会议标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置会议开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_start")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_start")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置会议持续时长（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_duration")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_duration")]
        public int Duration { get; set; }

        /// <summary>
        /// 获取或设置会议状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置会议描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = default!;

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
        public Types.Attendee Attendee { get; set; } = default!;

        /// <summary>
        /// 获取或设置会议设置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settings")]
        [System.Text.Json.Serialization.JsonPropertyName("settings")]
        public Types.Settings Settings { get; set; } = default!;

        /// <summary>
        /// 获取或设置会议提醒信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reminders")]
        [System.Text.Json.Serialization.JsonPropertyName("reminders")]
        public Types.Reminder? Reminder { get; set; }
    }
}
