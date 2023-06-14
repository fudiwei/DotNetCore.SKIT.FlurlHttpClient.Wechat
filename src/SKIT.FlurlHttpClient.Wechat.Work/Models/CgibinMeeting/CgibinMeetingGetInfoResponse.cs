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

                        /// <summary>
                        /// 获取或设置首次加入会议时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_join_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_join_time")]
                        public long? FirstJoinTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置最后一次离开会议时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("last_quit_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("last_quit_time")]
                        public long? LastQuitTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置入会次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_join_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_join_count")]
                        public int TotalJoinCount { get; set; }

                        /// <summary>
                        /// 获取或设置累计参会时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cumulative_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("cumulative_time")]
                        public int CumulativeTime { get; set; }
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

                        /// <summary>
                        /// 获取或设置首次加入会议时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_join_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_join_time")]
                        public long? FirstJoinTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置最后一次离开会议时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("last_quit_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("last_quit_time")]
                        public long? LastQuitTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置入会次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_join_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_join_count")]
                        public int TotalJoinCount { get; set; }

                        /// <summary>
                        /// 获取或设置累计参会时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cumulative_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("cumulative_time")]
                        public int CumulativeTime { get; set; }
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

            public class Guest
            {
                /// <summary>
                /// 获取或设置国家地区代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("area")]
                [System.Text.Json.Serialization.JsonPropertyName("area")]
                public string AreaCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置电话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone_number")]
                [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
                public string PhoneNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置会议嘉宾姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("guest_name")]
                [System.Text.Json.Serialization.JsonPropertyName("guest_name")]
                public string? GuestName { get; set; }
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
                /// 获取或设置是否开启入会密码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_password")]
                [System.Text.Json.Serialization.JsonPropertyName("need_password")]
                public bool EnablePassword { get; set; }

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
                /// 获取或设置成员入会时静音模式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_enter_mute")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_enter_mute")]
                public int EnterMuteMode { get; set; }

                /// <summary>
                /// 获取或设置允许参会者取消静音。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allow_unmute_self")]
                [System.Text.Json.Serialization.JsonPropertyName("allow_unmute_self")]
                public bool AllowUnmuteSelf { get; set; }

                /// <summary>
                /// 获取或设置是否设置全体静音。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mute_all")]
                [System.Text.Json.Serialization.JsonPropertyName("mute_all")]
                public bool IsMuteAll { get; set; }

                /// <summary>
                /// 获取或设置是否开启屏幕水印。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_screen_watermark")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_screen_watermark")]
                public bool EnableScreenWatermark { get; set; }

                /// <summary>
                /// 获取或设置水印样式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("watermark_type")]
                [System.Text.Json.Serialization.JsonPropertyName("watermark_type")]
                public int WatermarkType { get; set; }

                /// <summary>
                /// 获取或设置自动会议录制类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auto_record_type")]
                [System.Text.Json.Serialization.JsonPropertyName("auto_record_type")]
                public string AutoRecordType { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否当有参会成员入会时立即开启云录制。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("participant_join_auto_record")]
                [System.Text.Json.Serialization.JsonPropertyName("participant_join_auto_record")]
                public bool IsAttendeeJoinAutoRecord { get; set; }

                /// <summary>
                /// 获取或设置是否允许主持人暂停或者停止云录制。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_host_pause_auto_record")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_host_pause_auto_record")]
                public bool EnableHostPauseAutoRecord { get; set; }

                /// <summary>
                /// 获取或设置是否开启同声传译。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_interpreter")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_interpreter")]
                public bool EnableInterpreter { get; set; }

                /// <summary>
                /// 获取或设置是否允许成员上传文档。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_doc_upload_permission")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_doc_upload_permission")]
                public bool EnableDocumentUploadPermission { get; set; }

                /// <summary>
                /// 获取或设置是否激活报名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_enroll")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_enroll")]
                public bool EnableEnroll { get; set; }

                /// <summary>
                /// 获取或设置是否开启主持人密钥。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_host_key")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_host_key")]
                public bool EnableHostKey { get; set; }

                /// <summary>
                /// 获取或设置主持人密钥。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("host_key")]
                [System.Text.Json.Serialization.JsonPropertyName("host_key")]
                public string? HostKey { get; set; }

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
                /// 获取或设置会议当前主持人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("current_hosts")]
                [System.Text.Json.Serialization.JsonPropertyName("current_hosts")]
                public Types.Host? CurrentHost { get; set; }

                /// <summary>
                /// 获取或设置会议联席主持人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("co_hosts")]
                [System.Text.Json.Serialization.JsonPropertyName("co_hosts")]
                public Types.Host? CoHost { get; set; }

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
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_repeat")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsRepeat { get; set; }

                /// <summary>
                /// 获取或设置重复类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("repeat_type")]
                [System.Text.Json.Serialization.JsonPropertyName("repeat_type")]
                public int? RepeatType { get; set; }

                /// <summary>
                /// 获取或设置是否自定义重复设置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_custom_repeat")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_custom_repeat")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsCustomRepeat { get; set; }

                /// <summary>
                /// 获取或设置结束重复类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("repeat_until_type")]
                [System.Text.Json.Serialization.JsonPropertyName("repeat_until_type")]
                public int? RepeatUntilType { get; set; }

                /// <summary>
                /// 获取或设置周期会议限定次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("repeat_until_count")]
                [System.Text.Json.Serialization.JsonPropertyName("repeat_until_count")]
                public int? RepeatUntilCount { get; set; }

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
                /// 获取或设置每周周几重复。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("repeat_day_of_week")]
                [System.Text.Json.Serialization.JsonPropertyName("repeat_day_of_week")]
                public int[]? RepeatDaysOfWeek { get; set; }

                /// <summary>
                /// 获取或设置每月哪几天重复。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("repeat_day_of_month")]
                [System.Text.Json.Serialization.JsonPropertyName("repeat_day_of_month")]
                public int[]? RepeatDaysOfMonth { get; set; }

                /// <summary>
                /// 获取或设置会议开始前多久提醒（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remind_before")]
                [System.Text.Json.Serialization.JsonPropertyName("remind_before")]
                public int[]? RemindBeforeEventTimeList { get; set; }
            }

            public class SubMeeting
            {
                /// <summary>
                /// 获取或设置子会议 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_meetingid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_meetingid")]
                public string SubMeetingId { get; set; } = default!;

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }
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
        /// 获取或设置会议类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_type")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_type")]
        public int MeetingType { get; set; }

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
        /// 获取或设置会议嘉宾列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guests")]
        [System.Text.Json.Serialization.JsonPropertyName("guests")]
        public Types.Guest[]? GuestList { get; set; }

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

        /// <summary>
        /// 获取或设置会议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_code")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_code")]
        public string MeetingCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置会议链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_link")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_link")]
        public string MeetingLink { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否有投票。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_vote")]
        [System.Text.Json.Serialization.JsonPropertyName("has_vote")]
        public bool HasVote { get; set; }

        /// <summary>
        /// 获取或设置子会议列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_meetings")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_meetings")]
        public Types.SubMeeting[]? SubMeetingList { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多子会议特例。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more_sub_meeting")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("has_more_sub_meeting")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool HasMoreSubMeeting { get; set; }

        /// <summary>
        /// 获取或设置剩余子会议场数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remain_sub_meetings")]
        [System.Text.Json.Serialization.JsonPropertyName("remain_sub_meetings")]
        public int? RemainSubMeetingCount { get; set; }

        /// <summary>
        /// 获取或设置当前子会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("current_sub_meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("current_sub_meetingid")]
        public string? CurrentSubMeetingId { get; set; }
    }
}
