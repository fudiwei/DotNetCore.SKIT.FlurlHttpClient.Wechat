using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/add_checkin_option 接口的请求。</para>
    /// </summary>
    public class CgibinCheckinAddCheckinOptionRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class CheckinGroup
            {
                public static class Types
                {
                    public class Range
                    {
                        /// <summary>
                        /// 获取或设置成员账号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public IList<string>? UserIdList { get; set; }

                        /// <summary>
                        /// 获取或设置部门 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("partyid")]
                        [System.Text.Json.Serialization.JsonPropertyName("partyid")]
                        public IList<long>? DepartmentIdList { get; set; }

                        /// <summary>
                        /// 获取或设置标签 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tagid")]
                        [System.Text.Json.Serialization.JsonPropertyName("tagid")]
                        public IList<int>? TagIdList { get; set; }
                    }

                    public class Reporter
                    {
                        public static class Types
                        {
                            public class ReportUser
                            {
                                /// <summary>
                                /// 获取或设置成员账号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("userid")]
                                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                                public string? UserId { get; set; }

                                /// <summary>
                                /// 获取或设置标签 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tagid")]
                                [System.Text.Json.Serialization.JsonPropertyName("tagid")]
                                public int? TagId { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置汇报人列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reporters")]
                        [System.Text.Json.Serialization.JsonPropertyName("reporters")]
                        public IList<Types.ReportUser>? ReportUserList { get; set; }
                    }

                    public class CheckinDate
                    {
                        public static class Types
                        {
                            public class LateRule
                            {
                                /// <summary>
                                /// 获取或设置是否允许超时下班。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("allow_offwork_after_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("allow_offwork_after_time")]
                                public bool? AllowOffWorkAfterTime { get; set; }

                                /// <summary>
                                /// 获取或设置迟到规则列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("timerules")]
                                [System.Text.Json.Serialization.JsonPropertyName("timerules")]
                                public IList<TimeRule> TimeRuleList { get; set; } = default!;
                            }

                            public class TimeRule
                            {
                                /// <summary>
                                /// 获取或设置晚走的时间距离最晚一个下班的时间（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("offwork_after_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("offwork_after_time")]
                                public int? OffWorkAfterTime { get; set; }

                                /// <summary>
                                /// 获取或设置第二天第一个班次允许迟到的弹性时间（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("onwork_flex_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("onwork_flex_time")]
                                public int? OnWorkFlexTime { get; set; }
                            }

                            public class BiWeekly
                            {
                                /// <summary>
                                /// 获取或设置是否开启大小周。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("enable_weekday_recurrence")]
                                [System.Text.Json.Serialization.JsonPropertyName("enable_weekday_recurrence")]
                                public bool? EnableWeekdayRecurrence { get; set; }

                                /// <summary>
                                /// 获取或设置奇数周次序号列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("odd_workdays")]
                                [System.Text.Json.Serialization.JsonPropertyName("odd_workdays")]
                                public IList<int>? OddWorkdayList { get; set; }

                                /// <summary>
                                /// 获取或设置偶数周次序号列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("even_workdays")]
                                [System.Text.Json.Serialization.JsonPropertyName("even_workdays")]
                                public IList<int>? EvenWorkdayList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置工作日序号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("workdays")]
                        [System.Text.Json.Serialization.JsonPropertyName("workdays")]
                        public IList<int>? WorkdayList { get; set; }

                        /// <summary>
                        /// 获取或设置工作日上下班打卡时间列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("checkintime")]
                        [System.Text.Json.Serialization.JsonPropertyName("checkintime")]
                        public IList<CheckinTime>? CheckinTimeList { get; set; }

                        /// <summary>
                        /// 获取或设置是否允许弹性时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("allow_flex")]
                        [System.Text.Json.Serialization.JsonPropertyName("allow_flex")]
                        public bool? AllowFlex { get; set; }

                        /// <summary>
                        /// 获取或设置允许迟到时间（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("flex_on_duty_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("flex_on_duty_time")]
                        public int? FlexOnDutyTime { get; set; }

                        /// <summary>
                        /// 获取或设置允许早退时间（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("flex_off_duty_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("flex_off_duty_time")]
                        public int? FlexOffDutyTime { get; set; }

                        /// <summary>
                        /// 获取或设置最早可打卡时间限制（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("max_allow_arrive_early")]
                        [System.Text.Json.Serialization.JsonPropertyName("max_allow_arrive_early")]
                        public int MaxAllowArriveEarly { get; set; }

                        /// <summary>
                        /// 获取或设置最晚可打卡时间限制（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("max_allow_arrive_late")]
                        [System.Text.Json.Serialization.JsonPropertyName("max_allow_arrive_late")]
                        public int MaxAllowArriveLate { get; set; }

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

                    public class CheckinTime
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
                        public bool? AllowRest { get; set; }

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
                        /// 获取或设置多组休息时间列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rest_times")]
                        [System.Text.Json.Serialization.JsonPropertyName("rest_times")]
                        public IList<Types.RestTime>? RestTimeList { get; set; }

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

                    public class SpecialCheckinDate
                    {
                        /// <summary>
                        /// 获取或设置特殊日期类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置特殊日期时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("timestamp")]
                        [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
                        public long? Timestamp { get; set; }

                        /// <summary>
                        /// 获取或设置特殊日期开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("begintime")]
                        [System.Text.Json.Serialization.JsonPropertyName("begintime")]
                        public long? BeginTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置特殊日期结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("endtime")]
                        [System.Text.Json.Serialization.JsonPropertyName("endtime")]
                        public long? EndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置特殊日期上下班打卡时间列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("checkintime")]
                        [System.Text.Json.Serialization.JsonPropertyName("checkintime")]
                        public IList<CheckinTime> CheckinTimeList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置特殊日期备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("notes")]
                        [System.Text.Json.Serialization.JsonPropertyName("notes")]
                        public string? Notes { get; set; }
                    }

                    public class WiFiMac
                    {
                        /// <summary>
                        /// 获取或设置 Wi-Fi 打卡地点名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wifiname")]
                        [System.Text.Json.Serialization.JsonPropertyName("wifiname")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置 Wi-Fi 打卡地点 MAC 地址或 BSSID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wifimac")]
                        [System.Text.Json.Serialization.JsonPropertyName("wifimac")]
                        public string? Mac { get; set; }
                    }

                    public class Location
                    {
                        /// <summary>
                        /// 获取或设置位置打卡地点名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("loc_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("loc_title")]
                        public string? Title { get; set; }

                        /// <summary>
                        /// 获取或设置位置打卡地点详情。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("loc_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("loc_detail")]
                        public string? Detail { get; set; }

                        /// <summary>
                        /// 获取或设置位置打卡地点经度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lng")]
                        [System.Text.Json.Serialization.JsonPropertyName("lng")]
                        public decimal Longitude { get; set; }

                        /// <summary>
                        /// 获取或设置位置打卡地点纬度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lat")]
                        [System.Text.Json.Serialization.JsonPropertyName("lat")]
                        public decimal Latitude { get; set; }

                        /// <summary>
                        /// 获取或设置允许打卡范围（单位：米）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("distance")]
                        [System.Text.Json.Serialization.JsonPropertyName("distance")]
                        public int Distance { get; set; }
                    }

                    public class Schedule
                    {
                        public static class Types
                        {
                            public class TimeSection : CheckinTime
                            {
                            }

                            public class LateRule
                            {
                                /// <summary>
                                /// 获取或设置是否允许超时下班。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("allow_offwork_after_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("allow_offwork_after_time")]
                                public bool? AllowOffWorkAfterTime { get; set; }

                                /// <summary>
                                /// 获取或设置超时下班时间（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("offwork_after_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("offwork_after_time")]
                                public int? OffWorkAfterTime { get; set; }

                                /// <summary>
                                /// 获取或设置第二天第一个班次允许迟到的弹性时间（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("onwork_flex_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("onwork_flex_time")]
                                public int? OnWorkFlexTime { get; set; }

                                /// <summary>
                                /// 获取或设置迟到规则列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("timerules")]
                                [System.Text.Json.Serialization.JsonPropertyName("timerules")]
                                public IList<TimeRule>? TimeRuleList { get; set; }
                            }

                            public class TimeRule
                            {
                                /// <summary>
                                /// 获取或设置晚走的时间距离最晚一个下班的时间（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("offwork_after_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("offwork_after_time")]
                                public int? OffWorkAfterTime { get; set; }

                                /// <summary>
                                /// 获取或设置第二天第一个班次允许迟到的弹性时间（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("onwork_flex_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("onwork_flex_time")]
                                public int? OnWorkFlexTime { get; set; }
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
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置班次上下班时段列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time_section")]
                        [System.Text.Json.Serialization.JsonPropertyName("time_section")]
                        public IList<Types.TimeSection> TimeSectionList { get; set; } = new List<Types.TimeSection>();

                        /// <summary>
                        /// 获取或设置是否允许弹性时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("allow_flex")]
                        [System.Text.Json.Serialization.JsonPropertyName("allow_flex")]
                        public bool? AllowFlex { get; set; }

                        /// <summary>
                        /// 获取或设置允许迟到时间（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("flex_on_duty_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("flex_on_duty_time")]
                        public int? FlexOnDutyTime { get; set; }

                        /// <summary>
                        /// 获取或设置允许早退时间（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("flex_off_duty_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("flex_off_duty_time")]
                        public int? FlexOffDutyTime { get; set; }

                        /// <summary>
                        /// 获取或设置最早可打卡时间限制（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("max_allow_arrive_early")]
                        [System.Text.Json.Serialization.JsonPropertyName("max_allow_arrive_early")]
                        public int? MaxAllowArriveEarly { get; set; }

                        /// <summary>
                        /// 获取或设置最晚可打卡时间限制（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("max_allow_arrive_late")]
                        [System.Text.Json.Serialization.JsonPropertyName("max_allow_arrive_late")]
                        public int? MaxAllowArriveLate { get; set; }

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
                            public class Configuration
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

                                    public class Checkin
                                    {
                                        /// <summary>
                                        /// 获取或设置加班开始时间距最晚下班时间的秒数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ot_time_start")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ot_time_start")]
                                        public int? OvertimeTimeStart { get; set; }

                                        /// <summary>
                                        /// 获取或设置最短加班时长（单位：秒）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ot_time_min")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ot_time_min")]
                                        public int? OvertimeTimeMin { get; set; }

                                        /// <summary>
                                        /// 获取或设置最长加班时长（单位：秒）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ot_time_max")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ot_time_max")]
                                        public int? OvertimeTimeMax { get; set; }

                                        /// <summary>
                                        /// 获取或设置休息时间配置信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("restinfo")]
                                        [System.Text.Json.Serialization.JsonPropertyName("restinfo")]
                                        public Rest? Rest { get; set; }
                                    }

                                    public class Rest
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
                                                public int? FixedTimeBeginTime { get; set; }

                                                /// <summary>
                                                /// 获取或设置休息时间的结束时间距当天零点的秒数。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("fix_time_end_sec")]
                                                [System.Text.Json.Serialization.JsonPropertyName("fix_time_end_sec")]
                                                public int? FixedTimeEndTime { get; set; }
                                            }

                                            public class CalendarTimeRuleList
                                            {
                                                /// <summary>
                                                /// 获取或设置按加班时长扣除配置列表。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("items")]
                                                [System.Text.Json.Serialization.JsonPropertyName("items")]
                                                public IList<CalendarTimeRuleItem> Items { get; set; } = new List<CalendarTimeRuleItem>();
                                            }

                                            public class CalendarTimeRuleItem
                                            {
                                                /// <summary>
                                                /// 获取或设置加班单位时长（单位：秒）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("ot_time")]
                                                [System.Text.Json.Serialization.JsonPropertyName("ot_time")]
                                                public int? OvertimeTime { get; set; }

                                                /// <summary>
                                                /// 获取或设置对应扣除时长（单位：秒）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("rest_time")]
                                                [System.Text.Json.Serialization.JsonPropertyName("rest_time")]
                                                public int? RestTime { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置休息扣除类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                                        public int Type { get; set; }

                                        /// <summary>
                                        /// 获取或设置休息时间配置列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("fix_time_rule_list")]
                                        [System.Text.Json.Serialization.JsonPropertyName("fix_time_rule_list")]
                                        public IList<Types.FixedTimeRule>? FixedTimeRuleList { get; set; }

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

                                    public class Vacation
                                    {
                                        /// <summary>
                                        /// 获取或设置调休比例。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("trans_ratio")]
                                        [System.Text.Json.Serialization.JsonPropertyName("trans_ratio")]
                                        public int? TransformRatio { get; set; }

                                        /// <summary>
                                        /// 获取或设置是否自动关联假勤。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sync_vacation")]
                                        [System.Text.Json.Serialization.JsonPropertyName("sync_vacation")]
                                        public bool? IsSyncVacation { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置是否允许加班。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("allow_ot")]
                                [System.Text.Json.Serialization.JsonPropertyName("allow_ot")]
                                public bool AllowOvertime { get; set; }

                                /// <summary>
                                /// 获取或设置加班类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public int? Type { get; set; }

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
                                /// 获取或设置是否允许加班时长记为调休或加班费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ot_trans_enable")]
                                [System.Text.Json.Serialization.JsonPropertyName("ot_trans_enable")]
                                public bool? IsTransformEnabled { get; set; }

                                /// <summary>
                                /// 获取或设置加班时长记为调休或加班费类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ot_trans_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("ot_trans_type")]
                                public int? TransformType { get; set; }

                                /// <summary>
                                /// 获取或设置假期信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("vacation")]
                                [System.Text.Json.Serialization.JsonPropertyName("vacation")]
                                public Types.Vacation? Vacation { get; set; }
                            }

                            public class TimeUnitConfig
                            {
                                /// <summary>
                                /// 获取或设置加班单位类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ot_time_unit")]
                                [System.Text.Json.Serialization.JsonPropertyName("ot_time_unit")]
                                public int? OvertimeTimeUnit { get; set; }

                                /// <summary>
                                /// 获取或设置每天时长（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("perday_duration_secs")]
                                [System.Text.Json.Serialization.JsonPropertyName("perday_duration_secs")]
                                public int? DurationSecondsPerDay { get; set; }

                                /// <summary>
                                /// 获取或设置舍入方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("rounding_method")]
                                [System.Text.Json.Serialization.JsonPropertyName("rounding_method")]
                                public int? RoundingMethod { get; set; }

                                /// <summary>
                                /// 获取或设置舍入保留小数位数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("rounding_precision")]
                                [System.Text.Json.Serialization.JsonPropertyName("rounding_precision")]
                                public int? RoundingPrecision { get; set; }

                                /// <summary>
                                /// 获取或设置舍入时取整步长。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("step_size")]
                                [System.Text.Json.Serialization.JsonPropertyName("step_size")]
                                public int? StepSize { get; set; }
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

                    public class RecheckinReminder
                    {
                        /// <summary>
                        /// 获取或设置是否开启补卡提醒。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_remind")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_remind")]
                        public bool IsOpen { get; set; }

                        /// <summary>
                        /// 获取或设置补卡提醒月份。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buka_remind_month")]
                        [System.Text.Json.Serialization.JsonPropertyName("buka_remind_month")]
                        public int? RemindMonth { get; set; }

                        /// <summary>
                        /// 获取或设置补卡提醒日期。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buka_remind_day")]
                        [System.Text.Json.Serialization.JsonPropertyName("buka_remind_day")]
                        public int? RemindDay { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置打卡规则类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grouptype")]
                [System.Text.Json.Serialization.JsonPropertyName("grouptype")]
                public int GroupType { get; set; }

                /// <summary>
                /// 获取或设置打卡规则名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("groupname")]
                [System.Text.Json.Serialization.JsonPropertyName("groupname")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置打卡方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int? Type { get; set; }

                /// <summary>
                /// 获取或设置打卡人员信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("range")]
                [System.Text.Json.Serialization.JsonPropertyName("range")]
                public Types.Range? Range { get; set; }

                /// <summary>
                /// 获取或设置白名单成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("white_users")]
                [System.Text.Json.Serialization.JsonPropertyName("white_users")]
                public IList<string>? UserIdWhiteList { get; set; }

                /// <summary>
                /// 获取或设置汇报对象信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reporterinfo")]
                [System.Text.Json.Serialization.JsonPropertyName("reporterinfo")]
                public Types.Reporter? Reporter { get; set; }

                /// <summary>
                /// 获取或设置是否同步法定节假日。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sync_holidays")]
                [System.Text.Json.Serialization.JsonPropertyName("sync_holidays")]
                public bool? IsSyncHolidays { get; set; }

                /// <summary>
                /// 获取或设置是否打卡必须拍照。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_photo")]
                [System.Text.Json.Serialization.JsonPropertyName("need_photo")]
                public bool? RequirePhoto { get; set; }

                /// <summary>
                /// 获取或设置是否备注时允许上传本地图片。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("note_can_use_local_pic")]
                [System.Text.Json.Serialization.JsonPropertyName("note_can_use_local_pic")]
                public bool? AllowNotesUseLocalPicture { get; set; }

                /// <summary>
                /// 获取或设置是否非工作日允许打卡。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allow_checkin_offworkday")]
                [System.Text.Json.Serialization.JsonPropertyName("allow_checkin_offworkday")]
                public bool? AllowCheckinNonWorkday { get; set; }

                /// <summary>
                /// 获取或设置是否允许提交补卡申请。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allow_apply_offworkday")]
                [System.Text.Json.Serialization.JsonPropertyName("allow_apply_offworkday")]
                public bool? AllowApplyOffWorkday { get; set; }

                /// <summary>
                /// 获取或设置每月最多补卡次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allow_apply_bk_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("allow_apply_bk_cnt")]
                public int? LimitApplyRecheckinCount { get; set; }

                /// <summary>
                /// 获取或设置补卡时限（单位：天）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allow_apply_bk_day_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("allow_apply_bk_day_limit")]
                public int? LimitApplyRecheckinDay { get; set; }

                /// <summary>
                /// 获取或设置补卡时限（单位：天）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buka_limit_next_month")]
                [System.Text.Json.Serialization.JsonPropertyName("buka_limit_next_month")]
                public int? LimitApplyRecheckinNextMonth { get; set; }

                /// <summary>
                /// 获取或设置范围外打卡处理方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("option_out_range")]
                [System.Text.Json.Serialization.JsonPropertyName("option_out_range")]
                public int? OutRangeOption { get; set; }

                /// <summary>
                /// 获取或设置打卡时间配置列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("checkindate")]
                [System.Text.Json.Serialization.JsonPropertyName("checkindate")]
                public IList<Types.CheckinDate>? CheckinDateList { get; set; }

                /// <summary>
                /// 获取或设置特殊日期必须打卡日期列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spe_workdays")]
                [System.Text.Json.Serialization.JsonPropertyName("spe_workdays")]
                public IList<Types.SpecialCheckinDate>? SpecialCheckinDateList { get; set; }

                /// <summary>
                /// 获取或设置特殊日期不用打卡日期列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spe_offdays")]
                [System.Text.Json.Serialization.JsonPropertyName("spe_offdays")]
                public IList<Types.SpecialCheckinDate>? SpecialNonCheckinDateList { get; set; }

                /// <summary>
                /// 获取或设置 Wi-Fi 打卡地点列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wifimac_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("wifimac_infos")]
                public IList<Types.WiFiMac>? WiFiMacList { get; set; }

                /// <summary>
                /// 获取或设置位置打卡地点列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("loc_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("loc_infos")]
                public IList<Types.Location>? LocationList { get; set; }

                /// <summary>
                /// 获取或设置排班列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("schedulelist")]
                [System.Text.Json.Serialization.JsonPropertyName("schedulelist")]
                public IList<Types.Schedule>? ScheduleList { get; set; }

                /// <summary>
                /// 获取或设置加班信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ot_info_v2")]
                [System.Text.Json.Serialization.JsonPropertyName("ot_info_v2")]
                public Types.Overtime? Overtime { get; set; }

                /// <summary>
                /// 获取或设置是否开启人脸识别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("use_face_detect")]
                [System.Text.Json.Serialization.JsonPropertyName("use_face_detect")]
                public bool? IsUseFaceDetect { get; set; }

                /// <summary>
                /// 获取或设置是否开启人脸活体识别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_face_live_detect")]
                [System.Text.Json.Serialization.JsonPropertyName("open_face_live_detect")]
                public bool? IsOpenFaceLiveDetect { get; set; }

                /// <summary>
                /// 获取或设置自由签到时间（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("offwork_interval_time")]
                [System.Text.Json.Serialization.JsonPropertyName("offwork_interval_time")]
                public int? OffWorkIntervalTime { get; set; }

                /// <summary>
                /// 获取或设置是否外出打卡同步至上下班。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sync_out_checkin")]
                [System.Text.Json.Serialization.JsonPropertyName("sync_out_checkin")]
                public bool? IsSyncOutCheckin { get; set; }

                /// <summary>
                /// 获取或设置补卡提醒信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buka_remind")]
                [System.Text.Json.Serialization.JsonPropertyName("buka_remind")]
                public Types.RecheckinReminder? RecheckinReminder { get; set; }

                /// <summary>
                /// 获取或设置补卡异常类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buka_restriction")]
                [System.Text.Json.Serialization.JsonPropertyName("buka_restriction")]
                public int? RecheckinRestriction { get; set; }

                /// <summary>
                /// 获取或设置自由上下班规则的跨天时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("span_day_time")]
                [System.Text.Json.Serialization.JsonPropertyName("span_day_time")]
                public int? SpanDayTime { get; set; }

                /// <summary>
                /// 获取或设置自由上下班规则的工作时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("standard_work_duration")]
                [System.Text.Json.Serialization.JsonPropertyName("standard_work_duration")]
                public int? StandardWorkDuration { get; set; }

                /// <summary>
                /// 获取或设置是否开启审批打卡。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_sp_checkin")]
                [System.Text.Json.Serialization.JsonPropertyName("open_sp_checkin")]
                public bool? IsOpenApprovalCheckin { get; set; }

                /// <summary>
                /// 获取或设置打卡交替方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("checkin_method_type")]
                [System.Text.Json.Serialization.JsonPropertyName("checkin_method_type")]
                public int? CheckinMethodType { get; set; }
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
        public Types.CheckinGroup CheckinGroup { get; set; } = new Types.CheckinGroup();
    }
}
