namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/getcheckinoption 接口的响应。</para>
    /// </summary>
    public class CgibinCheckinGetCheckinOptionResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class CheckinOption
            {
                public static class Types
                {
                    public abstract class __zz__CheckinGroup : CgibinCheckinAddCheckinOptionRequest.Types.__zz__CheckinGroup
                    {
                        /// <summary>
                        /// 获取或设置打卡规则 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("groupid")]
                        [System.Text.Json.Serialization.JsonPropertyName("groupid")]
                        public int GroupId { get; set; }
                    }

                    public class CheckinGroup : __zz__CheckinGroup
                    {
                        public static class Types
                        {
                            public abstract class __zz__CheckinDate : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.__zz__CheckinDate
                            {
                                /// <summary>
                                /// 获取或设置是否下班不需要打卡。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("noneed_offwork")]
                                [System.Text.Json.Serialization.JsonPropertyName("noneed_offwork")]
                                public bool IsNoNeedOffWork { get; set; }

                                /// <summary>
                                /// 获取或设置弹性时间（单位：毫秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("flex_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("flex_time")]
                                public int? FlexTime { get; set; }

                                /// <summary>
                                /// 获取或设置提前打卡时间限制（单位：毫秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("limit_aheadtime")]
                                [System.Text.Json.Serialization.JsonPropertyName("limit_aheadtime")]
                                public int? LimitAheadTime { get; set; }
                            }

                            public class CheckinDate : __zz__CheckinDate
                            {
                                public static class Types
                                {
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
                                /// 获取或设置大小周信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("biweekly")]
                                [System.Text.Json.Serialization.JsonPropertyName("biweekly")]
                                public Types.BiWeekly? BiWeekly { get; set; }
                            }

                            public abstract class __zz__CheckinTime
                            {
                                /// <summary>
                                /// 获取或设置时段 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("time_id")]
                                public int? TimeId { get; set; }

                                /// <summary>
                                /// 获取或设置上班时间距当天零点的秒数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("work_sec")]
                                [System.Text.Json.Serialization.JsonPropertyName("work_sec")]
                                public int? OnWorkTime { get; set; }

                                /// <summary>
                                /// 获取或设置下班时间距当天零点的秒数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("off_work_sec")]
                                [System.Text.Json.Serialization.JsonPropertyName("off_work_sec")]
                                public int? OffWorkTime { get; set; }

                                /// <summary>
                                /// 获取或设置最早上班时间距当天零点的秒数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("earliest_work_sec")]
                                [System.Text.Json.Serialization.JsonPropertyName("earliest_work_sec")]
                                public int? EarliestOnWorkTime { get; set; }

                                /// <summary>
                                /// 获取或设置最晚下班时间距当天零点的秒数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("latest_work_sec")]
                                [System.Text.Json.Serialization.JsonPropertyName("latest_work_sec")]
                                public int? LatestOnWorkTime { get; set; }

                                /// <summary>
                                /// 获取或设置最早下班时间距当天零点的秒数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("earliest_off_work_sec")]
                                [System.Text.Json.Serialization.JsonPropertyName("earliest_off_work_sec")]
                                public int? EarliestOffWorkTime { get; set; }

                                /// <summary>
                                /// 获取或设置最晚下班时间距当天零点的秒数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("latest_off_work_sec")]
                                [System.Text.Json.Serialization.JsonPropertyName("latest_off_work_sec")]
                                public int? LatestOffWorkTime { get; set; }

                                /// <summary>
                                /// 获取或设置提醒上班时间距当天零点的秒数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("remind_work_sec")]
                                [System.Text.Json.Serialization.JsonPropertyName("remind_work_sec")]
                                public int? RemindOnWorkTime { get; set; }

                                /// <summary>
                                /// 获取或设置提醒下班时间距当天零点的秒数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("remind_off_work_sec")]
                                [System.Text.Json.Serialization.JsonPropertyName("remind_off_work_sec")]
                                public int? RemindOffWorkTime { get; set; }

                                /// <summary>
                                /// 获取或设置是否允许休息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("allow_rest")]
                                [System.Text.Json.Serialization.JsonPropertyName("allow_rest")]
                                public bool AllowRest { get; set; }

                                /// <summary>
                                /// 获取或设置休息开始时间距当天零点的秒数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("rest_begin_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("rest_begin_time")]
                                public int? RestBeginTime { get; set; }

                                /// <summary>
                                /// 获取或设置休息结束时间距当天零点的秒数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("rest_end_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("rest_end_time")]
                                public int? RestEndTime { get; set; }

                                /// <summary>
                                /// 获取或设置是否不需要上班打卡。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("no_need_checkon")]
                                [System.Text.Json.Serialization.JsonPropertyName("no_need_checkon")]
                                public bool? IsNoNeedCheckOn { get; set; }

                                /// <summary>
                                /// 获取或设置是否不需要下班打卡。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("no_need_checkoff")]
                                [System.Text.Json.Serialization.JsonPropertyName("no_need_checkoff")]
                                public bool? IsNoNeedCheckOff { get; set; }
                            }

                            public class CheckinTime : __zz__CheckinTime
                            {
                                public static class Types
                                {
                                    public class RestTime
                                    {
                                        /// <summary>
                                        /// 获取或设置休息开始时间距当天零点的秒数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("rest_begin_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("rest_begin_time")]
                                        public int BeginTime { get; set; }

                                        /// <summary>
                                        /// 获取或设置休息结束时间距当天零点的秒数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("rest_end_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("rest_end_time")]
                                        public int EndTime { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置多组休息时间列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("rest_times")]
                                [System.Text.Json.Serialization.JsonPropertyName("rest_times")]
                                public List<Types.RestTime>? RestTimeList { get; set; }
                            }

                            public abstract class __zz__SpecialCheckinDate
                            {
                                /// <summary>
                                /// 获取或设置特殊日期时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("timestamp")]
                                [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
                                public long Timestamp { get; set; }

                                /// <summary>
                                /// 获取或设置特殊日期备注。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("notes")]
                                [System.Text.Json.Serialization.JsonPropertyName("notes")]
                                public string? Notes { get; set; }
                            }

                            public class SpecialCheckinDate : __zz__SpecialCheckinDate
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

                            public abstract class __zz__Schedule : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.__zz__Schedule
                            {
                                /// <summary>
                                /// 获取或设置是否下班不需要打卡。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("noneed_offwork")]
                                [System.Text.Json.Serialization.JsonPropertyName("noneed_offwork")]
                                public bool IsNoNeedOffWork { get; set; }

                                /// <summary>
                                /// 获取或设置提前打卡时间限制（单位：毫秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("limit_aheadtime")]
                                [System.Text.Json.Serialization.JsonPropertyName("limit_aheadtime")]
                                public int LimitAheadTime { get; set; }

                                /// <summary>
                                /// 获取或设置下班延迟打卡时间限制（单位：毫秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("limit_offtime")]
                                [System.Text.Json.Serialization.JsonPropertyName("limit_offtime")]
                                public int LimitOffTime { get; set; }
                            }

                            public class Schedule : __zz__Schedule
                            {
                                public static class Types
                                {
                                    public class TimeSection : CheckinTime
                                    {
                                    }

                                    public abstract class __zz__LateRule : CgibinCheckinAddCheckinOptionRequest.Types.CheckinGroup.Types.Schedule.Types.__zz__LateRule
                                    {
                                    }

                                    public class LateRule : __zz__LateRule
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
                    }
                }

                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置打卡规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group")]
                [System.Text.Json.Serialization.JsonPropertyName("group")]
                public Types.CheckinGroup? CheckinGroup { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置打卡规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public List<Types.CheckinOption>? CheckinOptionList { get; set; }
    }
}
