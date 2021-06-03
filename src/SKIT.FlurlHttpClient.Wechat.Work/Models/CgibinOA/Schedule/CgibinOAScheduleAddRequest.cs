using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/schedule/add 接口的请求。</para>
    /// </summary>
    public class CgibinOAScheduleAddRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Schedule
            {
                public static class Types
                {
                    public class Attendee
                    {
                        /// <summary>
                        /// 获取或设置参与者成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string UserId { get; set; } = string.Empty;
                    }

                    public class Reminder
                    {
                        /// <summary>
                        /// 获取或设置是否需要提醒。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_remind")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_remind")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
                        public bool? IsRemind { get; set; }

                        /// <summary>
                        /// 获取或设置日程开始前多久提醒（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remind_before_event_secs")]
                        [System.Text.Json.Serialization.JsonPropertyName("remind_before_event_secs")]
                        public int? RemindBeforeEventTime { get; set; }

                        /// <summary>
                        /// 获取或设置日程开始时间与提醒时间的差值（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remind_time_diffs")]
                        [System.Text.Json.Serialization.JsonPropertyName("remind_time_diffs")]
                        public IList<int>? RemindTimeDiffs { get; set; }

                        /// <summary>
                        /// 获取或设置是否重复日程。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_repeat")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_repeat")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
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
                        /// 获取或设置是否自定义重复。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_custom_repeat")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_custom_repeat")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
                        public bool? IsCustomRepeat { get; set; }

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
                        public IList<int>? RepeatDayOfWeekList { get; set; }

                        /// <summary>
                        /// 获取或设置每月哪几天重复。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("repeat_day_of_month")]
                        [System.Text.Json.Serialization.JsonPropertyName("repeat_day_of_month")]
                        public IList<int>? RepeatDayOfMonthList { get; set; }

                        /// <summary>
                        /// 获取或设置时区。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("timezone")]
                        [System.Text.Json.Serialization.JsonPropertyName("timezone")]
                        public int? TimeZone { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置组织者成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("organizer")]
                [System.Text.Json.Serialization.JsonPropertyName("organizer")]
                public string OrganizerUserId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置日程开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置日程结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long? EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置所属日历 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cal_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cal_id")]
                public string? CalendarId { get; set; }

                /// <summary>
                /// 获取或设置日程标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("summary")]
                [System.Text.Json.Serialization.JsonPropertyName("summary")]
                public string? Summary { get; set; }

                /// <summary>
                /// 获取或设置日程描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

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

                /// <summary>
                /// 获取或设置日程参与者列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attendees")]
                [System.Text.Json.Serialization.JsonPropertyName("attendees")]
                public IList<Types.Attendee>? AttendeeList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置日程信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule")]
        public Types.Schedule Schedule { get; set; } = new Types.Schedule();

        /// <summary>
        /// 获取或设置授权方安装的应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }
    }
}
