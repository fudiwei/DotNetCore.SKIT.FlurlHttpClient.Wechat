namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/getcorpcheckinoption 接口的响应。</para>
    /// </summary>
    public class CgibinCheckinGetCorpCheckinOptionResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class CheckinGroup : CgibinCheckinGetCheckinOptionResponse.Types.CheckinOption.Types.CheckinGroup
            {
                public new static class Types
                {
                    public class Range
                    {
                        /// <summary>
                        /// 获取或设置成员账号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string[]? UserIdList { get; set; }

                        /// <summary>
                        /// 获取或设置部门 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("partyid")]
                        [System.Text.Json.Serialization.JsonPropertyName("partyid")]
                        public long[]? DepartmentIdList { get; set; }

                        /// <summary>
                        /// 获取或设置标签 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tagid")]
                        [System.Text.Json.Serialization.JsonPropertyName("tagid")]
                        public int[]? TagIdList { get; set; }
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
                                public string UserId { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置汇报人列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reporters")]
                        [System.Text.Json.Serialization.JsonPropertyName("reporters")]
                        public Types.ReportUser[]? ReportUserList { get; set; }

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
                                        public CalendarTimeRuleItem[] Items { get; set; } = default!;
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
                /// 获取或设置打卡方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置打卡人员信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("range")]
                [System.Text.Json.Serialization.JsonPropertyName("range")]
                public Types.Range Range { get; set; } = default!;

                /// <summary>
                /// 获取或设置打卡人员白名单。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("white_users")]
                [System.Text.Json.Serialization.JsonPropertyName("white_users")]
                public string[] UserIdWhiteList { get; set; } = default!;

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
                /// 获取或设置每月最多补卡次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allow_apply_bk_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("allow_apply_bk_cnt")]
                public int LimitApplyCount { get; set; }

                /// <summary>
                /// 获取或设置补卡时限（单位：天）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allow_apply_bk_day_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("allow_apply_bk_day_limit")]
                public int LimitApplyDay { get; set; }

                /// <summary>
                /// 获取或设置范围外打卡处理方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("option_out_range")]
                [System.Text.Json.Serialization.JsonPropertyName("option_out_range")]
                public int OutRangeOption { get; set; }

                /// <summary>
                /// 获取或设置是否开启人脸识别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("use_face_detect")]
                [System.Text.Json.Serialization.JsonPropertyName("use_face_detect")]
                public bool UseFaceDetect { get; set; }

                /// <summary>
                /// 获取或设置自由签到时间（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("offwork_interval_time")]
                [System.Text.Json.Serialization.JsonPropertyName("offwork_interval_time")]
                public int OffWorkIntervalTime { get; set; }

                /// <summary>
                /// 获取或设置创建人成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("create_userid")]
                public string CreatorUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置最近编辑人成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("update_userid")]
                public string UpdaterUserId { get; set; } = default!;

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
        public Types.CheckinGroup[] CheckinGroupList { get; set; } = default!;
    }
}
