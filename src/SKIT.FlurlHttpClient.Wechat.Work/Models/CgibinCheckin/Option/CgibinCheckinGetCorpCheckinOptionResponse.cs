namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/getcorpcheckinoption 接口的响应。</para>
    /// </summary>
    public class CgibinCheckinGetCorpCheckinOptionResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class CheckinGroup : CgibinCheckinGetCheckinOptionResponse.Types.CheckinOption.Types.__zz__CheckinGroup
            {
                public static class Types
                {
                    public class CheckinDate : CgibinCheckinGetCheckinOptionResponse.Types.CheckinOption.Types.CheckinGroup.Types.__zz__CheckinDate
                    {
                        public static class Types
                        {
                            public class BiWeekly : CgibinCheckinGetCheckinOptionResponse.Types.CheckinOption.Types.CheckinGroup.Types.CheckinDate.Types.BiWeekly
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置工作日上下班打卡时间列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("checkintime")]
                        [System.Text.Json.Serialization.JsonPropertyName("checkintime")]
                        public List<CheckinTime>? CheckinTimeList { get; set; }

                        /// <summary>
                        /// 获取或设置大小周信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("biweekly")]
                        [System.Text.Json.Serialization.JsonPropertyName("biweekly")]
                        public Types.BiWeekly? BiWeekly { get; set; }
                    }

                    public class CheckinTime : CgibinCheckinGetCheckinOptionResponse.Types.CheckinOption.Types.CheckinGroup.Types.__zz__CheckinTime
                    {
                        public static class Types
                        {
                            public class RestTime : CgibinCheckinGetCheckinOptionResponse.Types.CheckinOption.Types.CheckinGroup.Types.CheckinTime.Types.RestTime
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置多组休息时间列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rest_times")]
                        [System.Text.Json.Serialization.JsonPropertyName("rest_times")]
                        public List<Types.RestTime>? RestTimeList { get; set; }
                    }

                    public class SpecialCheckinDate : CgibinCheckinGetCheckinOptionResponse.Types.CheckinOption.Types.CheckinGroup.Types.__zz__SpecialCheckinDate
                    {
                        /// <summary>
                        /// 获取或设置特殊日期上下班打卡时间列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("checkintime")]
                        [System.Text.Json.Serialization.JsonPropertyName("checkintime")]
                        public List<CheckinTime>? CheckinTimeList { get; set; }
                    }

                    public class WiFiMac : CgibinCheckinGetCheckinOptionResponse.Types.CheckinOption.Types.CheckinGroup.Types.WiFiMac
                    {
                    }

                    public class Location : CgibinCheckinGetCheckinOptionResponse.Types.CheckinOption.Types.CheckinGroup.Types.Location
                    {
                    }

                    public class Schedule : CgibinCheckinGetCheckinOptionResponse.Types.CheckinOption.Types.CheckinGroup.Types.__zz__Schedule
                    {
                        public static class Types
                        {
                            public class TimeSection : CheckinTime
                            {
                            }

                            public class LateRule : CgibinCheckinGetCheckinOptionResponse.Types.CheckinOption.Types.CheckinGroup.Types.Schedule.Types.__zz__LateRule
                            {
                                public static class Types
                                {
                                    public class TimeRule : CgibinCheckinGetCheckinOptionResponse.Types.CheckinOption.Types.CheckinGroup.Types.Schedule.Types.LateRule.Types.TimeRule
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置迟到规则列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("timerules")]
                                [System.Text.Json.Serialization.JsonPropertyName("timerules")]
                                public List<Types.TimeRule>? TimeRuleList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置班次上下班时段列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time_section")]
                        [System.Text.Json.Serialization.JsonPropertyName("time_section")]
                        public List<Types.TimeSection>? TimeSectionList { get; set; }

                        /// <summary>
                        /// 获取或设置晚走晚到时间规则信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("late_rule")]
                        [System.Text.Json.Serialization.JsonPropertyName("late_rule")]
                        public Types.LateRule? LateRule { get; set; }
                    }

                    public class Range : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.Range
                    {
                    }

                    public class Reporter
                    {
                        public static class Types
                        {
                            public class ReportUser : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.Reporter.Types.ReportUser
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置汇报人列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reporters")]
                        [System.Text.Json.Serialization.JsonPropertyName("reporters")]
                        public List<Types.ReportUser>? ReportUserList { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("updatetime")]
                        [System.Text.Json.Serialization.JsonPropertyName("updatetime")]
                        public long? UpdateTimestamp { get; set; }
                    }

                    public class Overtime
                    {
                        public static class Types
                        {
                            public class OvertimeCheckin
                            {
                                /// <summary>
                                /// 获取或设置工作日加班开始时间距最晚下班时间的秒数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ot_workingday_time_start")]
                                [System.Text.Json.Serialization.JsonPropertyName("ot_workingday_time_start")]
                                public int OvertimeWorkdayTimeStart { get; set; }

                                /// <summary>
                                /// 获取或设置工作日最短加班时长（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ot_workingday_time_min")]
                                [System.Text.Json.Serialization.JsonPropertyName("ot_workingday_time_min")]
                                public int OvertimeWorkdayTimeMin { get; set; }

                                /// <summary>
                                /// 获取或设置工作日最长加班时长（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ot_workingday_time_max")]
                                [System.Text.Json.Serialization.JsonPropertyName("ot_workingday_time_max")]
                                public int OvertimeWorkdayTimeMax { get; set; }

                                /// <summary>
                                /// 获取或设置工作日休息时间配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ot_workingday_restinfo")]
                                [System.Text.Json.Serialization.JsonPropertyName("ot_workingday_restinfo")]
                                public OvertimeRest? OvertimeWorkdayRest { get; set; }

                                /// <summary>
                                /// 获取或设置非工作日最短加班时长（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ot_nonworkingday_time_min")]
                                [System.Text.Json.Serialization.JsonPropertyName("ot_nonworkingday_time_min")]
                                public int OvertimeNonWorkdayTimeMin { get; set; }

                                /// <summary>
                                /// 获取或设置非工作日最长加班时长（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ot_nonworkingday_time_max")]
                                [System.Text.Json.Serialization.JsonPropertyName("ot_nonworkingday_time_max")]
                                public int OvertimeNonWorkdayTimeMax { get; set; }

                                /// <summary>
                                /// 获取或设置非工作日加班，跨天时间距当天零点的秒数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ot_nonworkingday_spanday_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("ot_nonworkingday_spanday_time")]
                                public int OvertimeNonWorkdaySpanDayTime { get; set; }

                                /// <summary>
                                /// 获取或设置非工作日休息时间配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ot_nonworkingday_restinfo")]
                                [System.Text.Json.Serialization.JsonPropertyName("ot_nonworkingday_restinfo")]
                                public OvertimeRest? OvertimeNonWorkdayRest { get; set; }
                            }

                            public class OvertimeRest
                            {
                                public static class Types
                                {
                                    public class FixedTimeRule
                                    {
                                        /// <summary>
                                        /// 获取或设置休息时间的开始时间距当天零点的秒数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("fix_time_begin_sec")]
                                        [System.Text.Json.Serialization.JsonPropertyName("fix_time_begin_sec")]
                                        public int FixedTimeBeginTime { get; set; }

                                        /// <summary>
                                        /// 获取或设置休息时间的结束时间距当天零点的秒数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("fix_time_end_sec")]
                                        [System.Text.Json.Serialization.JsonPropertyName("fix_time_end_sec")]
                                        public int FixedTimeEndTime { get; set; }
                                    }

                                    public class CalendarTimeRuleList
                                    {
                                        /// <summary>
                                        /// 获取或设置按加班时长扣除配置列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("items")]
                                        [System.Text.Json.Serialization.JsonPropertyName("items")]
                                        public List<CalendarTimeRuleItem>? Items { get; set; }
                                    }

                                    public class CalendarTimeRuleItem
                                    {
                                        /// <summary>
                                        /// 获取或设置加班单位时长（单位：秒）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ot_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ot_time")]
                                        public int OvertimeTime { get; set; }

                                        /// <summary>
                                        /// 获取或设置对应扣除时长（单位：秒）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("rest_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("rest_time")]
                                        public int RestTime { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置休息扣除类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public int Type { get; set; }

                                /// <summary>
                                /// 获取或设置休息时间配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fix_time_rule")]
                                [System.Text.Json.Serialization.JsonPropertyName("fix_time_rule")]
                                public Types.FixedTimeRule? FixedTimeRule { get; set; }

                                /// <summary>
                                /// 获取或设置按加班时长扣除配置列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("cal_ottime_rule")]
                                [System.Text.Json.Serialization.JsonPropertyName("cal_ottime_rule")]
                                public Types.CalendarTimeRuleList? CalendarTimeRuleList { get; set; }
                            }

                            public class OvertimeApply
                            {
                                /// <summary>
                                /// 获取或设置是否允许工作日加班。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("allow_ot_workingday")]
                                [System.Text.Json.Serialization.JsonPropertyName("allow_ot_workingday")]
                                public bool AllowOvertimeWorkday { get; set; }

                                /// <summary>
                                /// 获取或设置是否允许非工作日加班。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("allow_ot_nonworkingday")]
                                [System.Text.Json.Serialization.JsonPropertyName("allow_ot_nonworkingday")]
                                public bool AllowOvertimeNonWorkday { get; set; }

                                /// <summary>
                                /// 获取或设置工作日休息时间配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ot_workingday_restinfo")]
                                [System.Text.Json.Serialization.JsonPropertyName("ot_workingday_restinfo")]
                                public OvertimeRest? OvertimeWorkdayRest { get; set; }

                                /// <summary>
                                /// 获取或设置非工作日加班，跨天时间距当天零点的秒数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ot_nonworkingday_spanday_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("ot_nonworkingday_spanday_time")]
                                public int OvertimeNonWorkdaySpanDayTime { get; set; }

                                /// <summary>
                                /// 获取或设置非工作日休息时间配置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ot_nonworkingday_restinfo")]
                                [System.Text.Json.Serialization.JsonPropertyName("ot_nonworkingday_restinfo")]
                                public OvertimeRest? OvertimeNonWorkdayRest { get; set; }

                                /// <summary>
                                /// 获取或设置更新时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("uptime")]
                                [System.Text.Json.Serialization.JsonPropertyName("uptime")]
                                public long UpdateTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置加班类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置允许工作日加班。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("allow_ot_workingday")]
                        [System.Text.Json.Serialization.JsonPropertyName("allow_ot_workingday")]
                        public bool AllowOvertimeWorkday { get; set; }

                        /// <summary>
                        /// 获取或设置允许非工作日加班。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("allow_ot_nonworkingday")]
                        [System.Text.Json.Serialization.JsonPropertyName("allow_ot_nonworkingday")]
                        public bool AllowOvertimeNonWorkday { get; set; }

                        /// <summary>
                        /// 获取或设置加班时长计算规则信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("otcheckinfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("otcheckinfo")]
                        public Types.OvertimeCheckin? OvertimeCheckin { get; set; }

                        /// <summary>
                        /// 获取或设置加班申请信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("otapplyinfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("otapplyinfo")]
                        public Types.OvertimeApply? OvertimeApply { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("uptime")]
                        [System.Text.Json.Serialization.JsonPropertyName("uptime")]
                        public long UpdateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置打卡时间配置列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("checkindate")]
                [System.Text.Json.Serialization.JsonPropertyName("checkindate")]
                public List<Types.CheckinDate>? CheckinDateList { get; set; }

                /// <summary>
                /// 获取或设置特殊日期必须打卡日期列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spe_workdays")]
                [System.Text.Json.Serialization.JsonPropertyName("spe_workdays")]
                public List<Types.SpecialCheckinDate>? SpecialCheckinDateList { get; set; }

                /// <summary>
                /// 获取或设置特殊日期不用打卡日期列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spe_offdays")]
                [System.Text.Json.Serialization.JsonPropertyName("spe_offdays")]
                public List<Types.SpecialCheckinDate>? SpecialNonCheckinDateList { get; set; }

                /// <summary>
                /// 获取或设置 Wi-Fi 打卡地点列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wifimac_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("wifimac_infos")]
                public List<Types.WiFiMac>? WiFiMacList { get; set; }

                /// <summary>
                /// 获取或设置位置打卡地点列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("loc_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("loc_infos")]
                public List<Types.Location>? LocationList { get; set; }

                /// <summary>
                /// 获取或设置排班列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("schedulelist")]
                [System.Text.Json.Serialization.JsonPropertyName("schedulelist")]
                public List<Types.Schedule>? ScheduleList { get; set; }

                /// <summary>
                /// 获取或设置打卡人员信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("range")]
                [System.Text.Json.Serialization.JsonPropertyName("range")]
                public Types.Range? Range { get; set; }

                /// <summary>
                /// 获取或设置汇报对象信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reporterinfo")]
                [System.Text.Json.Serialization.JsonPropertyName("reporterinfo")]
                public Types.Reporter? Reporter { get; set; }

                /// <summary>
                /// 获取或设置加班信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ot_info")]
                [System.Text.Json.Serialization.JsonPropertyName("ot_info")]
                public Types.Overtime? Overtime { get; set; }

                /// <summary>
                /// 获取或设置创建人成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("create_userid")]
                public string? CreatorUserId { get; set; }

                /// <summary>
                /// 获取或设置最近编辑人成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("update_userid")]
                public string? UpdaterUserId { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置打卡规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group")]
        [System.Text.Json.Serialization.JsonPropertyName("group")]
        public List<Types.CheckinGroup>? CheckinGroupList { get; set; }
    }
}
