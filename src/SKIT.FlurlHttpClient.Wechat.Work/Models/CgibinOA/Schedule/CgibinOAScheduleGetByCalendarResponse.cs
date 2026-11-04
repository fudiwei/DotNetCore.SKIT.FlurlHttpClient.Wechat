namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/schedule/get_by_calendar 接口的响应。</para>
    /// </summary>
    public class CgibinOAScheduleGetByCalendarResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Schedule : CgibinOAScheduleGetResponse.Types.__zz__Schedule
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
                /// 获取或设置日程序号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sequence")]
                [System.Text.Json.Serialization.JsonPropertyName("sequence")]
                public int Sequence { get; set; }

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
