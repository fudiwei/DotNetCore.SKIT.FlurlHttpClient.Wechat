namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/update_checkin_option 接口的请求。</para>
    /// </summary>
    public class CgibinCheckinUpdateCheckinOptionRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class CheckinGroup : CgibinCheckinAddCheckinOptionRequest.Types.__zz__CheckinGroup
            {
                public static class Types
                {
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
                    }

                    public class CheckinDate : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.__zz__CheckinDate
                    {
                        public static class Types
                        {
                            public class LateRule : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.CheckinDate.Types.__zz__LateRule
                            {
                                public static class Types
                                {
                                    public class TimeRule : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.CheckinDate.Types.LateRule.Types.TimeRule
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

                            public class BiWeekly : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.CheckinDate.Types.BiWeekly
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
                        /// 获取或设置晚走晚到时间规则信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("late_rule")]
                        [System.Text.Json.Serialization.JsonPropertyName("late_rule")]
                        public Types.LateRule? LateRule { get; set; }

                        /// <summary>
                        /// 获取或设置大小周信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("biweekly")]
                        [System.Text.Json.Serialization.JsonPropertyName("biweekly")]
                        public Types.BiWeekly? BiWeekly { get; set; }
                    }

                    public class CheckinTime : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.__zz__CheckinTime
                    {
                        public static class Types
                        {
                            public class RestTime : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.CheckinTime.Types.RestTime
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

                    public class SpecialCheckinDate : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.__zz__SpecialCheckinDate
                    {
                        /// <summary>
                        /// 获取或设置特殊日期上下班打卡时间列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("checkintime")]
                        [System.Text.Json.Serialization.JsonPropertyName("checkintime")]
                        public List<CheckinTime>? CheckinTimeList { get; set; }
                    }

                    public class WiFiMac : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.WiFiMac
                    {
                    }

                    public class Location : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.Location
                    {
                    }

                    public class Schedule : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.__zz__Schedule
                    {
                        public static class Types
                        {
                            public class TimeSection : CheckinTime
                            {
                            }

                            public class LateRule : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.Schedule.Types.__zz__LateRule
                            {
                                public static class Types
                                {
                                    public class TimeRule : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.Schedule.Types.LateRule.Types.TimeRule
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

                    public class Overtime
                    {
                        public static class Types
                        {
                            public class Configuration : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.Overtime.Types.__zz__Configuration
                            {
                                public static class Types
                                {
                                    public class Apply
                                    {
                                        /// <summary>
                                        /// 获取或设置休息时间配置信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("restinfo")]
                                        [System.Text.Json.Serialization.JsonPropertyName("restinfo")]
                                        public Rest? Rest { get; set; }
                                    }

                                    public class Checkin : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.Overtime.Types.Configuration.Types.__zz__Checkin
                                    {
                                        /// <summary>
                                        /// 获取或设置休息时间配置信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("restinfo")]
                                        [System.Text.Json.Serialization.JsonPropertyName("restinfo")]
                                        public Rest? Rest { get; set; }
                                    }

                                    public class Rest : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.Overtime.Types.Configuration.Types.__zz__Rest
                                    {
                                        public static class Types
                                        {
                                            public class FixedTimeRule : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.Overtime.Types.Configuration.Types.Rest.Types.FixedTimeRule
                                            {
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

                                            public class CalendarTimeRuleItem : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.Overtime.Types.Configuration.Types.Rest.Types.CalendarTimeRuleItem
                                            {
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置休息时间配置列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("fix_time_rule_list")]
                                        [System.Text.Json.Serialization.JsonPropertyName("fix_time_rule_list")]
                                        public List<Types.FixedTimeRule>? FixedTimeRuleList { get; set; }

                                        /// <summary>
                                        /// 获取或设置按加班时长扣除配置列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("cal_ottime_rule")]
                                        [System.Text.Json.Serialization.JsonPropertyName("cal_ottime_rule")]
                                        public Types.CalendarTimeRuleList? CalendarTimeRuleList { get; set; }
                                    }

                                    public class ApplyCheckin
                                    {
                                        /// <summary>
                                        /// 获取或设置休息时间配置信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("restinfo")]
                                        [System.Text.Json.Serialization.JsonPropertyName("restinfo")]
                                        public Rest? Rest { get; set; }
                                    }

                                    public class Vacation : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.Overtime.Types.Configuration.Types.Vacation
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置加班申请信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("apply")]
                                [System.Text.Json.Serialization.JsonPropertyName("apply")]
                                public Types.Apply? Apply { get; set; }

                                /// <summary>
                                /// 获取或设置加班时长计算规则信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("checkin")]
                                [System.Text.Json.Serialization.JsonPropertyName("checkin")]
                                public Types.Checkin? Checkin { get; set; }

                                /// <summary>
                                /// 获取或设置加班申请时长计算规则信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("applycheckin")]
                                [System.Text.Json.Serialization.JsonPropertyName("applycheckin")]
                                public Types.ApplyCheckin? ApplyCheckin { get; set; }

                                /// <summary>
                                /// 获取或设置假期信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("vacation")]
                                [System.Text.Json.Serialization.JsonPropertyName("vacation")]
                                public Types.Vacation? Vacation { get; set; }
                            }

                            public class TimeUnitConfig : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.Overtime.Types.TimeUnitConfig
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置工作日加班配置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("workdayconf")]
                        [System.Text.Json.Serialization.JsonPropertyName("workdayconf")]
                        public Types.Configuration? WorkDayConfiguration { get; set; }

                        /// <summary>
                        /// 获取或设置休息日加班配置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("restdayconf")]
                        [System.Text.Json.Serialization.JsonPropertyName("restdayconf")]
                        public Types.Configuration? RestDayConfiguration { get; set; }

                        /// <summary>
                        /// 获取或设置节假日加班配置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("holidayconf")]
                        [System.Text.Json.Serialization.JsonPropertyName("holidayconf")]
                        public Types.Configuration? HolidayConfiguration { get; set; }

                        /// <summary>
                        /// 获取或设置加班单位配置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time_unit_config")]
                        [System.Text.Json.Serialization.JsonPropertyName("time_unit_config")]
                        public Types.TimeUnitConfig? TimeUnitConfig { get; set; }
                    }

                    public class RecheckinReminder : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.RecheckinReminder
                    {
                    }
                }

                /// <summary>
                /// 获取或设置打卡规则 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("groupid")]
                [System.Text.Json.Serialization.JsonPropertyName("groupid")]
                public int GroupId { get; set; }

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
                /// 获取或设置加班信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ot_info_v2")]
                [System.Text.Json.Serialization.JsonPropertyName("ot_info_v2")]
                public Types.Overtime? Overtime { get; set; }

                /// <summary>
                /// 获取或设置补卡提醒信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buka_remind")]
                [System.Text.Json.Serialization.JsonPropertyName("buka_remind")]
                public Types.RecheckinReminder? RecheckinReminder { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置是否立即生效。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effective_now")]
        [System.Text.Json.Serialization.JsonPropertyName("effective_now")]
        public bool? IsEffectiveNow { get; set; }

        /// <summary>
        /// 获取或设置打卡规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group")]
        [System.Text.Json.Serialization.JsonPropertyName("group")]
        public Types.CheckinGroup? CheckinGroup { get; set; }
    }
}
