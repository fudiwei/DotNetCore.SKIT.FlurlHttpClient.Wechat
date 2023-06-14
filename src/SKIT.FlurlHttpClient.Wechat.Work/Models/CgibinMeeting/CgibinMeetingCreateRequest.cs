using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/create 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingCreateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Invitee
            {
                /// <summary>
                /// 获取或设置参与者成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public IList<string>? UserIdList { get; set; }

                /// <summary>
                /// 获取或设置设备序列号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_sn")]
                [System.Text.Json.Serialization.JsonPropertyName("device_sn")]
                public IList<string>? DeviceSerialNumberList { get; set; }
            }

            public class Guest
            {
                /// <summary>
                /// 获取或设置国家地区代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("area")]
                [System.Text.Json.Serialization.JsonPropertyName("area")]
                public string AreaCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone_number")]
                [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
                public string PhoneNumber { get; set; } = string.Empty;

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
                        public IList<string>? UserIdList { get; set; }
                    }

                    public class RingUser
                    {
                        /// <summary>
                        /// 获取或设置企业成员的 UserId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public IList<string>? UserIdList { get; set; }
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
                public bool? EnableWaitingRoom { get; set; }

                /// <summary>
                /// 获取或设置是否允许成员在主持人进会前加入。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allow_enter_before_host")]
                [System.Text.Json.Serialization.JsonPropertyName("allow_enter_before_host")]
                public bool? AllowEnterBeforeHost { get; set; }

                /// <summary>
                /// 获取或设置是否允许外部成员入会。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allow_external_user")]
                [System.Text.Json.Serialization.JsonPropertyName("allow_external_user")]
                public bool? AllowExternalUser { get; set; }

                /// <summary>
                /// 获取或设置成员入会时静音模式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_enter_mute")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_enter_mute")]
                public int? EnterMuteMode { get; set; }

                /// <summary>
                /// 获取或设置允许参会者取消静音。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allow_unmute_self")]
                [System.Text.Json.Serialization.JsonPropertyName("allow_unmute_self")]
                public bool? AllowUnmuteSelf { get; set; }

                /// <summary>
                /// 获取或设置是否设置全体静音。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mute_all")]
                [System.Text.Json.Serialization.JsonPropertyName("mute_all")]
                public bool? IsMuteAll { get; set; }

                /// <summary>
                /// 获取或设置是否开启屏幕水印。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_screen_watermark")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_screen_watermark")]
                public bool? EnableScreenWatermark { get; set; }

                /// <summary>
                /// 获取或设置水印样式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("watermark_type")]
                [System.Text.Json.Serialization.JsonPropertyName("watermark_type")]
                public int? WatermarkType { get; set; }

                /// <summary>
                /// 获取或设置自动会议录制类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auto_record_type")]
                [System.Text.Json.Serialization.JsonPropertyName("auto_record_type")]
                public string? AutoRecordType { get; set; }

                /// <summary>
                /// 获取或设置是否当有参会成员入会时立即开启云录制。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attendee_join_auto_record")]
                [System.Text.Json.Serialization.JsonPropertyName("attendee_join_auto_record")]
                public bool? IsAttendeeJoinAutoRecord { get; set; }

                /// <summary>
                /// 获取或设置是否允许主持人暂停或者停止云录制。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_host_pause_auto_record")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_host_pause_auto_record")]
                public bool? EnableHostPauseAutoRecord { get; set; }

                /// <summary>
                /// 获取或设置是否开启同声传译。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_interpreter")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_interpreter")]
                public bool? EnableInterpreter { get; set; }

                /// <summary>
                /// 获取或设置是否允许成员上传文档。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_doc_upload_permission")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_doc_upload_permission")]
                public bool? EnableDocumentUploadPermission { get; set; }

                /// <summary>
                /// 获取或设置是否激活报名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_enroll")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_enroll")]
                public bool? EnableEnroll { get; set; }

                /// <summary>
                /// 获取或设置是否开启主持人密钥。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_host_key")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_host_key")]
                public bool? EnableHostKey { get; set; }

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
                /// 获取或设置是否自定义重复设置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_custom_repeat")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_custom_repeat")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsCustomRepeat { get; set; }

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
                public IList<int>? RepeatDaysOfWeek { get; set; }

                /// <summary>
                /// 获取或设置每月哪几天重复。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("repeat_day_of_month")]
                [System.Text.Json.Serialization.JsonPropertyName("repeat_day_of_month")]
                public IList<int>? RepeatDaysOfMonth { get; set; }

                /// <summary>
                /// 获取或设置会议开始前多久提醒（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remind_before")]
                [System.Text.Json.Serialization.JsonPropertyName("remind_before")]
                public IList<int>? RemindBeforeEventTimeList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置管理员成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admin_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("admin_userid")]
        public string AdminUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会议标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

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
        [Newtonsoft.Json.JsonProperty("invitees")]
        [System.Text.Json.Serialization.JsonPropertyName("invitees")]
        public Types.Invitee? Invitee { get; set; }

        /// <summary>
        /// 获取或设置会议嘉宾列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guests")]
        [System.Text.Json.Serialization.JsonPropertyName("guests")]
        public IList<Types.Guest>? GuestList { get; set; }

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
