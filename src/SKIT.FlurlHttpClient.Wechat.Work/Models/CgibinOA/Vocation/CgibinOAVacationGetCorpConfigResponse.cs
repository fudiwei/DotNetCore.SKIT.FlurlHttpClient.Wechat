namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/oa/vacation/getcorpconf 接口的响应。</para>
    /// </summary>
    public class CgibinOAVacationGetCorpConfigResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Vacation
            {
                public static class Types
                {
                    public class Quota
                    {
                        public static class Types
                        {
                            public class QuotaRuleList
                            {
                                /// <summary>
                                /// 获取或设置额度计算规则。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("list")]
                                [System.Text.Json.Serialization.JsonPropertyName("list")]
                                public QuotaRuleItem[] Items { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置是否根据实际入职时间计算假期。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("based_on_actual_work_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("based_on_actual_work_time")]
                                public bool IsBasedOnActualWorkTime { get; set; }
                            }

                            public class QuotaRuleItem
                            {
                                /// <summary>
                                /// 获取或设置区间发放时长（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("quota")]
                                [System.Text.Json.Serialization.JsonPropertyName("quota")]
                                public int Quota { get; set; }

                                /// <summary>
                                /// 获取或设置区间开始点（单位：年）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("begin")]
                                [System.Text.Json.Serialization.JsonPropertyName("begin")]
                                public int Begin { get; set; }

                                /// <summary>
                                /// 获取或设置区间结束点（单位：年）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end")]
                                [System.Text.Json.Serialization.JsonPropertyName("end")]
                                public int End { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置假期发放类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置自动发放时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("autoreset_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("autoreset_time")]
                        public long? AutoResetTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置自动发放时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("autoreset_duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("autoreset_duration")]
                        public int? AutoResetDuration { get; set; }

                        /// <summary>
                        /// 获取或设置额度计算类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quota_rule_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("quota_rule_type")]
                        public int QuotaRuleType { get; set; }

                        /// <summary>
                        /// 获取或设置额度计算规则列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quota_rules")]
                        [System.Text.Json.Serialization.JsonPropertyName("quota_rules")]
                        public Types.QuotaRuleList QuotaRuleList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否按照入职日期发放假期。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("at_entry_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("at_entry_date")]
                        public bool IsAtEntryDate { get; set; }

                        /// <summary>
                        /// 获取或设置自动按月发放的发放时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("auto_reset_month_day")]
                        [System.Text.Json.Serialization.JsonPropertyName("auto_reset_month_day")]
                        public int? AutoResetMonthDay { get; set; }
                    }

                    public class ExpireRule
                    {
                        public static class Types
                        {
                            public class Date
                            {
                                /// <summary>
                                /// 获取或设置月份。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("month")]
                                [System.Text.Json.Serialization.JsonPropertyName("month")]
                                public int Month { get; set; }

                                /// <summary>
                                /// 获取或设置天。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("day")]
                                [System.Text.Json.Serialization.JsonPropertyName("day")]
                                public int Day { get; set; }
                            }

                            public class Duration
                            {
                                /// <summary>
                                /// 获取或设置月数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("month")]
                                [System.Text.Json.Serialization.JsonPropertyName("month")]
                                public int Month { get; set; }

                                /// <summary>
                                /// 获取或设置天数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("day")]
                                [System.Text.Json.Serialization.JsonPropertyName("day")]
                                public int Day { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置过期规则类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置有效期。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("duration")]
                        public int Duration { get; set; }

                        /// <summary>
                        /// 获取或设置失效日期信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date")]
                        [System.Text.Json.Serialization.JsonPropertyName("date")]
                        public Types.Date? Date { get; set; }

                        /// <summary>
                        /// 获取或设置是否允许延长有效期。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("extern_duration_enable")]
                        [System.Text.Json.Serialization.JsonPropertyName("extern_duration_enable")]
                        public bool IsExternDurationEnabled { get; set; }

                        /// <summary>
                        /// 获取或设置延长有效期的具体时间信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("extern_duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("extern_duration")]
                        public Types.Duration? ExternDuration { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置假期类型标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int VacationId { get; set; }

                /// <summary>
                /// 获取或设置假期名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置时长计算类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("duration_type")]
                [System.Text.Json.Serialization.JsonPropertyName("duration_type")]
                public int DurationType { get; set; }

                /// <summary>
                /// 获取或设置假期时间刻度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time_attr")]
                [System.Text.Json.Serialization.JsonPropertyName("time_attr")]
                public int TimeType { get; set; }

                /// <summary>
                /// 获取或设置假期发放相关配置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quota_attr")]
                [System.Text.Json.Serialization.JsonPropertyName("quota_attr")]
                public Types.Quota Quota { get; set; } = default!;

                /// <summary>
                /// 获取或设置一天对应的秒数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("perday_duration")]
                [System.Text.Json.Serialization.JsonPropertyName("perday_duration")]
                public int DurationPerDay { get; set; }

                /// <summary>
                /// 获取或设置是否关联加班调休。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_newovertime")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_newovertime")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsNewOvertime { get; set; }

                /// <summary>
                /// 获取或设置入职时间大于多久可用该假期（单位：月）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enter_comp_time_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("enter_comp_time_limit")]
                public int EnterCompanyTimeLimit { get; set; }

                /// <summary>
                /// 获取或设置假期过期规则。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_rule")]
                public Types.ExpireRule? ExpireRule { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置假期列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lists")]
        [System.Text.Json.Serialization.JsonPropertyName("lists")]
        public Types.Vacation[] VacationList { get; set; } = default!;
    }
}
