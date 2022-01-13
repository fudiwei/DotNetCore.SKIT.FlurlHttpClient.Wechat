namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/getcheckin_monthdata 接口的响应。</para>
    /// </summary>
    public class CgibinCheckinGetCheckinMonthDataResponse : WechatWorkResponse
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
                            }
                        }

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
                        /// 获取或设置异常天数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("except_days")]
                        [System.Text.Json.Serialization.JsonPropertyName("except_days")]
                        public int ExceptDays { get; set; }

                        /// <summary>
                        /// 获取或设置正常天数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("regular_days")]
                        [System.Text.Json.Serialization.JsonPropertyName("regular_days")]
                        public int RegularyDays { get; set; }

                        /// <summary>
                        /// 获取或设置应打卡天数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("work_days")]
                        [System.Text.Json.Serialization.JsonPropertyName("work_days")]
                        public int StandardDays { get; set; }

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
                    }

                    public class Vacation : CgibinCheckinGetCheckinDayDataResponse.Types.Data.Types.Vacation
                    {
                    }

                    public class Exception : CgibinCheckinGetCheckinDayDataResponse.Types.Data.Types.Exception
                    {
                    }

                    public class Overtime
                    {
                        /// <summary>
                        /// 获取或设置工作日加班时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("workday_over_sec")]
                        [System.Text.Json.Serialization.JsonPropertyName("workday_over_sec")]
                        public int OvertimeWorkdayTime { get; set; }

                        /// <summary>
                        /// 获取或设置节假日加班时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("holidays_over_sec")]
                        [System.Text.Json.Serialization.JsonPropertyName("holidays_over_sec")]
                        public int? OvertimeHolidayTime { get; set; }

                        /// <summary>
                        /// 获取或设置休息日加班时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("restdays_over_sec")]
                        [System.Text.Json.Serialization.JsonPropertyName("restdays_over_sec")]
                        public int? OvertimeRestdayTime { get; set; }
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
                [Newtonsoft.Json.JsonProperty("overwork_info")]
                [System.Text.Json.Serialization.JsonPropertyName("overwork_info")]
                public Types.Overtime? Overtime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置打卡月报列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("datas")]
        [System.Text.Json.Serialization.JsonPropertyName("datas")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
