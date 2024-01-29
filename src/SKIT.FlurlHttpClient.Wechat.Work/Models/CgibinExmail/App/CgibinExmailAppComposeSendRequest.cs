using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/app/compose_send 接口的请求。</para>
    /// </summary>
    public class CgibinExmailAppComposeSendRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Recipient
            {
                /// <summary>
                /// 获取或设置邮箱地址列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("emails")]
                [System.Text.Json.Serialization.JsonPropertyName("emails")]
                public IList<string>? EmailList { get; set; }

                /// <summary>
                /// 获取或设置企业成员的 UserId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userids")]
                [System.Text.Json.Serialization.JsonPropertyName("userids")]
                public IList<string>? UserIdList { get; set; }
            }

            public class Attachment
            {
                /// <summary>
                /// 获取或设置内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_name")]
                [System.Text.Json.Serialization.JsonPropertyName("file_name")]
                public string FileName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置经过 Base64 编码的文件内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string EncodingContent { get; set; } = string.Empty;
            }

            public class Schedule
            {
                public static class Types
                {
                    public class Reminder : CgibinOAScheduleAddRequest.Types.Schedule.Types.Reminder
                    {
                        /// <summary>
                        /// 获取或设置日程开始前多久提醒（单位：分钟）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remind_before_event_mins")]
                        [System.Text.Json.Serialization.JsonPropertyName("remind_before_event_mins")]
                        public new int? RemindBeforeEventTime { get; set; }

                        /// <summary>
                        /// 获取或设置每月哪几周重复。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("repeat_week_of_month")]
                        [System.Text.Json.Serialization.JsonPropertyName("repeat_week_of_month")]
                        public IList<int>? RepeatWeekOfMonthList { get; set; }

                        /// <summary>
                        /// 获取或设置每年哪几月重复。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("repeat_month_of_year")]
                        [System.Text.Json.Serialization.JsonPropertyName("repeat_month_of_year")]
                        public IList<int>? RepeatMonthOfYearList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置日程 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("schedule_id")]
                [System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
                public string? ScheduleId { get; set; }

                /// <summary>
                /// 获取或设置日程方法。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("method")]
                [System.Text.Json.Serialization.JsonPropertyName("method")]
                public string? Method { get; set; }

                /// <summary>
                /// 获取或设置日程开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置日程结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置日程地点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location")]
                [System.Text.Json.Serialization.JsonPropertyName("location")]
                public string? Location { get; set; }

                /// <summary>
                /// 获取或设置日程提醒信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reminders")]
                [System.Text.Json.Serialization.JsonPropertyName("reminders")]
                public Types.Reminder? Reminder { get; set; }
            }

            public class Meeting
            {
                public static class Types
                {
                    public class Settings
                    {
                        /// <summary>
                        /// 获取或设置入会密码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("password")]
                        [System.Text.Json.Serialization.JsonPropertyName("password")]
                        public string? Password { get; set; }

                        /// <summary>
                        /// 获取或设置自动录制模式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("auto_record")]
                        [System.Text.Json.Serialization.JsonPropertyName("auto_record")]
                        public int? AutoRecordMode { get; set; }

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
                        /// 获取或设置是否开启屏幕水印。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enable_screen_watermark")]
                        [System.Text.Json.Serialization.JsonPropertyName("enable_screen_watermark")]
                        public bool? EnableScreenWatermark { get; set; }

                        /// <summary>
                        /// 获取或设置限制成员入会模式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enter_restraint")]
                        [System.Text.Json.Serialization.JsonPropertyName("enter_restraint")]
                        public int? EnterRestraintMode { get; set; }

                        /// <summary>
                        /// 获取或设置成员入会时静音模式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enable_enter_mute")]
                        [System.Text.Json.Serialization.JsonPropertyName("enable_enter_mute")]
                        public int? EnterMuteMode { get; set; }

                        /// <summary>
                        /// 获取或设置会议开始提醒范围。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remind_scope")]
                        [System.Text.Json.Serialization.JsonPropertyName("remind_scope")]
                        public int? RemindScope { get; set; }

                        /// <summary>
                        /// 获取或设置水印类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("water_mark_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("water_mark_type")]
                        public int? WaterMarkType { get; set; }
                    }

                    public class Host
                    {
                        /// <summary>
                        /// 获取或设置企业成员的 UserId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userids")]
                        [System.Text.Json.Serialization.JsonPropertyName("userids")]
                        public IList<string>? UserIdList { get; set; }
                    }

                    public class Administrator
                    {
                        /// <summary>
                        /// 获取或设置企业成员的 UserId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userids")]
                        [System.Text.Json.Serialization.JsonPropertyName("userids")]
                        public IList<string>? UserIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置会议设置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("option")]
                [System.Text.Json.Serialization.JsonPropertyName("option")]
                public Types.Settings? Settings { get; set; }

                /// <summary>
                /// 获取或设置会议主持人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hosts")]
                [System.Text.Json.Serialization.JsonPropertyName("hosts")]
                public Types.Host? Host { get; set; }

                /// <summary>
                /// 获取或设置会议管理员信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_admins")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_admins")]
                public Types.Administrator Administrator { get; set; } = new Types.Administrator();
            }
        }

        /// <summary>
        /// 获取或设置收件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to")]
        [System.Text.Json.Serialization.JsonPropertyName("to")]
        public Types.Recipient To { get; set; } = new Types.Recipient();

        /// <summary>
        /// 获取或设置抄送信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cc")]
        [System.Text.Json.Serialization.JsonPropertyName("cc")]
        public Types.Recipient? CC { get; set; }

        /// <summary>
        /// 获取或设置密送信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bcc")]
        [System.Text.Json.Serialization.JsonPropertyName("bcc")]
        public Types.Recipient? BCC { get; set; }

        /// <summary>
        /// 获取或设置标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subject")]
        [System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string Subject { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置内容类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content_type")]
        [System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// 获取或设置附件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attachment_list")]
        [System.Text.Json.Serialization.JsonPropertyName("attachment_list")]
        public IList<Types.Attachment>? AttachmentList { get; set; }

        /// <summary>
        /// 获取或设置日程信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule")]
        public Types.Schedule? Schedule { get; set; }

        /// <summary>
        /// 获取或设置会议信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting")]
        public Types.Meeting? Meeting { get; set; }

        /// <summary>
        /// 获取或设置是否开启 ID 转译。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_id_trans")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("enable_id_trans")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? EnableIdTransform { get; set; }
    }
}
