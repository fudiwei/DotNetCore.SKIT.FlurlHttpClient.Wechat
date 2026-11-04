namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/schedule/get 接口的响应。</para>
    /// </summary>
    public class CgibinOAScheduleGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public abstract class __zz__Schedule
            {
                /// <summary>
                /// 获取或设置日程 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("schedule_id")]
                [System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
                public string? ScheduleId { get; set; }

                /// <summary>
                /// 获取或设置管理员成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("admins")]
                [System.Text.Json.Serialization.JsonPropertyName("admins")]
                public List<string>? AdminUserIdList { get; set; }

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
                /// 获取或设置是否设置为全天日程。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_whole_day")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_whole_day")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
                public bool IsWholeDay { get; set; }

                /// <summary>
                /// 获取或设置所属日历 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cal_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cal_id")]
                public string? CalendarId { get; set; }

                /// <summary>
                /// 获取或设置日程状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

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
            }

            public class Schedule : __zz__Schedule
            {
                public static class Types
                {
                    public class Attendee : CgibinOAScheduleAddRequest.Types.Schedule.Types.Attendee
                    {
                        /// <summary>
                        /// 获取或设置参与者接收状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("response_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("response_status")]
                        public int ResponseStatus { get; set; }
                    }

                    public class Reminder : CgibinOAScheduleAddRequest.Types.Schedule.Types.Reminder
                    {
                        public static class Types
                        {
                            public class ExcludeTime
                            {
                                /// <summary>
                                /// 获取或设置不包含的日期时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("start_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                                public long StartTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置重复日程不包含的日期列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exclude_time_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("exclude_time_list")]
                        public List<Types.ExcludeTime>? ExcludeTimeList { get; set; }
                    }
                }

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
                public List<Types.Attendee>? AttendeeList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置日程列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule_list")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule_list")]
        public List<Types.Schedule>? ScheduleList { get; set; }
    }
}
