using System;
using System.Collections.Generic;

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
                    public class CheckinGroup
                    {
                        public static class Types
                        {
                            public class CheckinDate
                            {
                                /// <summary>
                                /// 获取或设置工作日序号列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("workdays")]
                                [System.Text.Json.Serialization.JsonPropertyName("workdays")]
                                public int[] WorkdayList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置工作日上下班打卡时间列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("checkintime")]
                                [System.Text.Json.Serialization.JsonPropertyName("checkintime")]
                                public CheckinTime[] CheckinTimeList { get; set; } = default!;

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
                                public int FlexTime { get; set; }

                                /// <summary>
                                /// 获取或设置允许迟到时间（单位：毫秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("flex_on_duty_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("flex_on_duty_time")]
                                public int FlexOnDutyTime { get; set; }

                                /// <summary>
                                /// 获取或设置允许早退时间（单位：毫秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("flex_off_duty_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("flex_off_duty_time")]
                                public int FlexOffDutyTime { get; set; }

                                /// <summary>
                                /// 获取或设置提前打卡时间限制（单位：毫秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("limit_aheadtime")]
                                [System.Text.Json.Serialization.JsonPropertyName("limit_aheadtime")]
                                public int LimitAheadTime { get; set; }
                            }

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

                            public class SpecialCheckinDate
                            {
                                /// <summary>
                                /// 获取或设置特殊日期时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("timestamp")]
                                [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
                                public long Timestamp { get; set; }

                                /// <summary>
                                /// 获取或设置特殊日期上下班打卡时间列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("checkintime")]
                                [System.Text.Json.Serialization.JsonPropertyName("checkintime")]
                                public CheckinTime[] CheckinTimeList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置特殊日期备注。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("notes")]
                                [System.Text.Json.Serialization.JsonPropertyName("notes")]
                                public string Notes { get; set; } = default!;
                            }

                            public class WiFiMac
                            {
                                /// <summary>
                                /// 获取或设置 Wi-Fi 打卡地点名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("wifiname")]
                                [System.Text.Json.Serialization.JsonPropertyName("wifiname")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 Wi-Fi 打卡地点 MAC 地址或 BSSID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("wifimac")]
                                [System.Text.Json.Serialization.JsonPropertyName("wifimac")]
                                public string Mac { get; set; } = default!;
                            }

                            public class Location
                            {
                                /// <summary>
                                /// 获取或设置位置打卡地点名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("loc_title")]
                                [System.Text.Json.Serialization.JsonPropertyName("loc_title")]
                                public string Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置位置打卡地点详情。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("loc_detail")]
                                [System.Text.Json.Serialization.JsonPropertyName("loc_detail")]
                                public string Detail { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置位置打卡地点经度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("lng")]
                                [System.Text.Json.Serialization.JsonPropertyName("lng")]
                                public double Longitude { get; set; }

                                /// <summary>
                                /// 获取或设置位置打卡地点纬度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("lat")]
                                [System.Text.Json.Serialization.JsonPropertyName("lat")]
                                public double Latitude { get; set; }

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
                                        /// <summary>
                                        /// 获取或设置时段 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("time_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("time_id")]
                                        public int TimeSectionId { get; set; }

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
                                        public int RestBeginTime { get; set; }

                                        /// <summary>
                                        /// 获取或设置休息结束时间距当天零点的秒数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("rest_end_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("rest_end_time")]
                                        public int RestEndTime { get; set; }
                                    }

                                    public class LateRule
                                    {
                                        /// <summary>
                                        /// 获取或设置是否允许超时下班。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("allow_offwork_after_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("allow_offwork_after_time")]
                                        public bool AllowOffWorkAfterTime { get; set; }

                                        /// <summary>
                                        /// 获取或设置迟到规则列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("timerules")]
                                        [System.Text.Json.Serialization.JsonPropertyName("timerules")]
                                        public TimeRule[] TimeRuleList { get; set; } = default!;
                                    }

                                    public class TimeRule
                                    {
                                        /// <summary>
                                        /// 获取或设置晚走的时间距离最晚一个下班的时间（单位：秒）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("offwork_after_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("offwork_after_time")]
                                        public int OffWorkAfterTime { get; set; }

                                        /// <summary>
                                        /// 获取或设置第二天第一个班次允许迟到的弹性时间（单位：秒）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("onwork_flex_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("onwork_flex_time")]
                                        public int OnWorkFlexTime { get; set; }
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
                                public Types.TimeSection[] TimeSectionList { get; set; } = default!;

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

                                /// <summary>
                                /// 获取或设置是否允许弹性时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("allow_flex")]
                                [System.Text.Json.Serialization.JsonPropertyName("allow_flex")]
                                public bool AllowFlex { get; set; }

                                /// <summary>
                                /// 获取或设置允许迟到时间（单位：毫秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("flex_on_duty_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("flex_on_duty_time")]
                                public int FlexOnDutyTime { get; set; }

                                /// <summary>
                                /// 获取或设置允许早退时间（单位：毫秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("flex_off_duty_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("flex_off_duty_time")]
                                public int FlexOffDutyTime { get; set; }

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
                            }
                        }

                        /// <summary>
                        /// 获取或设置打卡规则 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("groupid")]
                        [System.Text.Json.Serialization.JsonPropertyName("groupid")]
                        public int GroupId { get; set; }

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
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否同步法定节假日。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sync_holidays")]
                        [System.Text.Json.Serialization.JsonPropertyName("sync_holidays")]
                        public bool IsSyncHolidays { get; set; }

                        /// <summary>
                        /// 获取或设置是否打卡必须拍照。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("need_photo")]
                        [System.Text.Json.Serialization.JsonPropertyName("need_photo")]
                        public bool RequirePhoto { get; set; }

                        /// <summary>
                        /// 获取或设置是否备注时允许上传本地图片。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("note_can_use_local_pic")]
                        [System.Text.Json.Serialization.JsonPropertyName("note_can_use_local_pic")]
                        public bool AllowNotesUseLocalPicture { get; set; }

                        /// <summary>
                        /// 获取或设置是否非工作日允许打卡。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("allow_checkin_offworkday")]
                        [System.Text.Json.Serialization.JsonPropertyName("allow_checkin_offworkday")]
                        public bool AllowCheckinNonWorkday { get; set; }

                        /// <summary>
                        /// 获取或设置是否允许提交补卡申请。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("allow_apply_offworkday")]
                        [System.Text.Json.Serialization.JsonPropertyName("allow_apply_offworkday")]
                        public bool AllowApplyOffWorkday { get; set; }

                        /// <summary>
                        /// 获取或设置打卡时间配置列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("checkindate")]
                        [System.Text.Json.Serialization.JsonPropertyName("checkindate")]
                        public Types.CheckinDate[] CheckinDateList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置特殊日期必须打卡日期列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spe_workdays")]
                        [System.Text.Json.Serialization.JsonPropertyName("spe_workdays")]
                        public Types.SpecialCheckinDate[]? SpecialCheckinDateList { get; set; }

                        /// <summary>
                        /// 获取或设置特殊日期不用打卡日期列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spe_offdays")]
                        [System.Text.Json.Serialization.JsonPropertyName("spe_offdays")]
                        public Types.SpecialCheckinDate[]? SpecialNonCheckinDateList { get; set; }

                        /// <summary>
                        /// 获取或设置 Wi-Fi 打卡地点列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wifimac_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("wifimac_infos")]
                        public Types.WiFiMac[]? WiFiMacList { get; set; }

                        /// <summary>
                        /// 获取或设置位置打卡地点列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("loc_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("loc_infos")]
                        public Types.Location[]? LocationList { get; set; }

                        /// <summary>
                        /// 获取或设置排班列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("schedulelist")]
                        [System.Text.Json.Serialization.JsonPropertyName("schedulelist")]
                        public Types.Schedule[]? ScheduleList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置打卡规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group")]
                [System.Text.Json.Serialization.JsonPropertyName("group")]
                public Types.CheckinGroup CheckinGroup { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置打卡规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.CheckinOption[] CheckinOptionList { get; set; } = default!;
    }
}
