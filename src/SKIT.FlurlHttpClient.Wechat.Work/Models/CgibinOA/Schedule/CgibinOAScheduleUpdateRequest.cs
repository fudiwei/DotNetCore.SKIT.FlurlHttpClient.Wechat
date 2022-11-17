using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/schedule/update 接口的请求。</para>
    /// </summary>
    public class CgibinOAScheduleUpdateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Schedule
            {
                public static class Types
                {
                    public class Attendee : CgibinOAScheduleAddRequest.Types.Schedule.Types.Attendee
                    {
                    }

                    public class Reminder : CgibinOAScheduleAddRequest.Types.Schedule.Types.Reminder
                    {
                    }
                }

                /// <summary>
                /// 获取或设置日程 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("schedule_id")]
                [System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
                public string ScheduleId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置组织者成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("organizer")]
                [System.Text.Json.Serialization.JsonPropertyName("organizer")]
                public string? OrganizerUserId { get; set; }

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

                /// <summary>
                /// 获取或设置是否允许非参与人主动加入日程。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allow_active_join")]
                [System.Text.Json.Serialization.JsonPropertyName("allow_active_join")]
                public bool? IsAllowActiveJoin { get; set; }

                /// <summary>
                /// 获取或设置是否只允许组织者发起群聊。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("only_organizer_create_chat")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("only_organizer_create_chat")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsOnlyOrganizerCreateChat { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置是否忽略参与者字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skip_attendees")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("skip_attendees")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsSkipAttendees { get; set; }

        /// <summary>
        /// 获取或设置操作模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("op_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("op_mode")]
        public int? OperateMode { get; set; }

        /// <summary>
        /// 获取或设置操作起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("op_start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("op_start_time")]
        public long? OperateStartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置日程信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule")]
        public Types.Schedule Schedule { get; set; } = new Types.Schedule();
    }
}
