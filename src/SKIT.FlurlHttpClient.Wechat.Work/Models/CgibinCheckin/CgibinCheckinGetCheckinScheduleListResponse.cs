namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/getcheckinschedulist 接口的响应。</para>
    /// </summary>
    public class CgibinCheckinGetCheckinScheduleListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Schedule
            {
                public static class Types
                {
                    public class ScheduleList
                    {
                        /// <summary>
                        /// 获取或设置个人排班列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scheduleList")]
                        [System.Text.Json.Serialization.JsonPropertyName("scheduleList")]
                        public ScheduleItem[] Items { get; set; } = default!;
                    }

                    public class ScheduleItem
                    {
                        public static class Types
                        {
                            public class Schedule
                            {
                                public static class Types
                                {
                                    public class TimeSection
                                    {
                                        /// <summary>
                                        /// 获取或设置时段 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                                        public int TimeSectionId { get; set; }

                                        /// <summary>
                                        /// 获取或设置上班时间距当天零点的秒数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("work_sec")]
                                        [System.Text.Json.Serialization.JsonPropertyName("work_sec")]
                                        public int OnWorkTime { get; set; }

                                        /// <summary>
                                        /// 获取或设置下班时间距当天零点的秒数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("off_work_sec")]
                                        [System.Text.Json.Serialization.JsonPropertyName("off_work_sec")]
                                        public int OffWorkTime { get; set; }

                                        /// <summary>
                                        /// 获取或设置提醒上班时间距当天零点的秒数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("remind_work_sec")]
                                        [System.Text.Json.Serialization.JsonPropertyName("remind_work_sec")]
                                        public int RemindOnWorkTime { get; set; }

                                        /// <summary>
                                        /// 获取或设置提醒下班时间距当天零点的秒数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("remind_off_work_sec")]
                                        [System.Text.Json.Serialization.JsonPropertyName("remind_off_work_sec")]
                                        public int RemindOffWorkTime { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置排班 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("schedule_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
                                public int ScheduleId { get; set; }

                                /// <summary>
                                /// 获取或设置排班名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("schedule_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("schedule_name")]
                                public string ScheduleName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置时段列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time_section")]
                                [System.Text.Json.Serialization.JsonPropertyName("time_section")]
                                public Types.TimeSection[] TimeSectionList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置排班日期（格式：d）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("day")]
                        [System.Text.Json.Serialization.JsonPropertyName("day")]
                        public int Day { get; set; }

                        /// <summary>
                        /// 获取或设置排班信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("schedule_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("schedule_info")]
                        public Types.Schedule Schedule { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置排班年月（格式：yyyyMM）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("yearmonth")]
                [System.Text.Json.Serialization.JsonPropertyName("yearmonth")]
                public int YearAndMonth { get; set; }

                /// <summary>
                /// 获取或设置打卡规则 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("groupid")]
                [System.Text.Json.Serialization.JsonPropertyName("groupid")]
                public int GroupId { get; set; }

                /// <summary>
                /// 获取或设置打卡规则名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("groupname")]
                [System.Text.Json.Serialization.JsonPropertyName("groupname")]
                public string GroupName { get; set; } = default!;

                /// <summary>
                /// 获取或设置个人排班信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("schedule")]
                [System.Text.Json.Serialization.JsonPropertyName("schedule")]
                public Types.ScheduleList ScheduleList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置排班列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule_list")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule_list")]
        public Types.Schedule[] ScheduleList { get; set; } = default!;
    }
}
