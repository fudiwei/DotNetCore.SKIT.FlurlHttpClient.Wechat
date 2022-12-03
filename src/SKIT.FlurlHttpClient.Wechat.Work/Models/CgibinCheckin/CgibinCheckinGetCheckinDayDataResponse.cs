namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/getcheckin_daydata 接口的响应。</para>
    /// </summary>
    public class CgibinCheckinGetCheckinDayDataResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Base
                    {
                        public static class Types
                        {
                            public class CheckinGroup
                            {
                                public static class Types
                                {
                                    public class CheckinTime
                                    {
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
                                    }
                                }

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
                                /// 获取或设置排班 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("scheduleid")]
                                [System.Text.Json.Serialization.JsonPropertyName("scheduleid")]
                                public int? ScheduleId { get; set; }

                                /// <summary>
                                /// 获取或设置排班名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("schedulename")]
                                [System.Text.Json.Serialization.JsonPropertyName("schedulename")]
                                public string? ScheduleName { get; set; }

                                /// <summary>
                                /// 获取或设置当日打卡时间列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("checkintime")]
                                [System.Text.Json.Serialization.JsonPropertyName("checkintime")]
                                public Types.CheckinTime[] CheckinTimeList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置日报日期时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date")]
                        [System.Text.Json.Serialization.JsonPropertyName("date")]
                        public long DateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置日报类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("day_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("day_type")]
                        public int DayType { get; set; }

                        /// <summary>
                        /// 获取或设置记录类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("record_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("record_type")]
                        public int RecordType { get; set; }

                        /// <summary>
                        /// 获取或设置打卡人成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("acctid")]
                        [System.Text.Json.Serialization.JsonPropertyName("acctid")]
                        public string UserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置打卡人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置打卡人别名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name_ex")]
                        [System.Text.Json.Serialization.JsonPropertyName("name_ex")]
                        public string Alias { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置打卡人所在部门。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("departs_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("departs_name")]
                        public string DepartmentsName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置打卡规则信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rule_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("rule_info")]
                        public Types.CheckinGroup CheckinGroup { get; set; } = default!;
                    }

                    public class Summary
                    {
                        /// <summary>
                        /// 获取或设置打卡次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("checkin_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("checkin_count")]
                        public int CheckinCount { get; set; }

                        /// <summary>
                        /// 获取或设置实际工作时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("regular_work_sec")]
                        [System.Text.Json.Serialization.JsonPropertyName("regular_work_sec")]
                        public int RegularWorkTime { get; set; }

                        /// <summary>
                        /// 获取或设置标准工作时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("standard_work_sec")]
                        [System.Text.Json.Serialization.JsonPropertyName("standard_work_sec")]
                        public int StandardWorkTime { get; set; }

                        /// <summary>
                        /// 获取或设置最早打卡时间据当天零点的秒数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("earliest_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("earliest_time")]
                        public int EarliestCheckinTime { get; set; }

                        /// <summary>
                        /// 获取或设置最晚打卡时间据当天零点的秒数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lastest_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("lastest_time")]
                        public int LatestCheckinTime { get; set; }
                    }

                    public class Holiday
                    {
                        public static class Types
                        {
                            public class MultiLangText : CgibinOAApplyEventRequest.Types.MultiLangText
                            {
                            }

                            public class ApprovalData
                            {
                                /// <summary>
                                /// 获取或设置数据列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("data")]
                                [System.Text.Json.Serialization.JsonPropertyName("data")]
                                public MultiLangText[] Data { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置假勤审批 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sp_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("sp_number")]
                        public string ApprovalNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置假勤摘要标题数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sp_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("sp_title")]
                        public Types.ApprovalData ApprovalTitleData { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置假勤摘要描述数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sp_description")]
                        [System.Text.Json.Serialization.JsonPropertyName("sp_description")]
                        public Types.ApprovalData ApprovalDescriptionData { get; set; } = default!;
                    }

                    public class Vacation
                    {
                        /// <summary>
                        /// 获取或设置统计项名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置假勤类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置假期类型标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("vacation_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("vacation_id")]
                        public int? VacationId { get; set; }

                        /// <summary>
                        /// 获取或设置时长单位。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("time_type")]
                        public int TimeType { get; set; }

                        /// <summary>
                        /// 获取或设置当日假勤时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("duration")]
                        public int Duration { get; set; }

                        /// <summary>
                        /// 获取或设置当日假勤次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        public int Count { get; set; }
                    }

                    public class Exception
                    {
                        /// <summary>
                        /// 获取或设置异常状态类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exception")]
                        [System.Text.Json.Serialization.JsonPropertyName("exception")]
                        public int ExceptionType { get; set; }

                        /// <summary>
                        /// 获取或设置此异常的累计时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("duration")]
                        public int? Duration { get; set; }

                        /// <summary>
                        /// 获取或设置此异常的次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        public int Count { get; set; }
                    }

                    public class Overtime
                    {
                        /// <summary>
                        /// 获取或设置加班状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ot_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("ot_status")]
                        public int OvertimeStatus { get; set; }

                        /// <summary>
                        /// 获取或设置加班时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ot_duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("ot_duration")]
                        public int OvertimeDuration { get; set; }

                        /// <summary>
                        /// 获取或设置加班不足的时长列表（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exception_duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("exception_duration")]
                        public int[]? ExceptionDurationList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置基础信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇总信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("summary_info")]
                [System.Text.Json.Serialization.JsonPropertyName("summary_info")]
                public Types.Summary Summary { get; set; } = default!;

                /// <summary>
                /// 获取或设置假勤信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("holiday_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("holiday_infos")]
                public Types.Holiday[]? HolidayList { get; set; }

                /// <summary>
                /// 获取或设置假勤信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sp_items")]
                [System.Text.Json.Serialization.JsonPropertyName("sp_items")]
                public Types.Vacation[]? VacationList { get; set; }

                /// <summary>
                /// 获取或设置异常信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exception_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("exception_infos")]
                public Types.Exception[]? ExceptionList { get; set; }

                /// <summary>
                /// 获取或设置加班信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ot_info")]
                [System.Text.Json.Serialization.JsonPropertyName("ot_info")]
                public Types.Overtime? Overtime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置打卡日报列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("datas")]
        [System.Text.Json.Serialization.JsonPropertyName("datas")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
