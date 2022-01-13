namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/health/get_report_job_info 接口的响应。</para>
    /// </summary>
    public class CgibinHealthGetReportJobInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class ReportJob
            {
                public static class Types
                {
                    public class ReportRange
                    {
                        /// <summary>
                        /// 获取或设置用户 UserId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userids")]
                        [System.Text.Json.Serialization.JsonPropertyName("userids")]
                        public string[]? UserIdList { get; set; }

                        /// <summary>
                        /// 获取或设置部门 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("partyids")]
                        [System.Text.Json.Serialization.JsonPropertyName("partyids")]
                        public int[]? DepartmentIdList { get; set; }
                    }

                    public class ReportTo
                    {
                        /// <summary>
                        /// 获取或设置用户 UserId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userids")]
                        [System.Text.Json.Serialization.JsonPropertyName("userids")]
                        public string[]? UserIdList { get; set; }
                    }

                    public class QuestionTemplate
                    {
                        public static class Types
                        {
                            public class Option
                            {
                                /// <summary>
                                /// 获取或设置选项 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("option_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("option_id")]
                                public int OptionId { get; set; }

                                /// <summary>
                                /// 获取或设置选项文本。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("option_text")]
                                [System.Text.Json.Serialization.JsonPropertyName("option_text")]
                                public string Text { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置问题 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("question_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("question_id")]
                        public int QuestionId { get; set; }

                        /// <summary>
                        /// 获取或设置问题标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置问题类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("question_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("question_type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置是否必填。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_required")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_required")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsRequired { get; set; }

                        /// <summary>
                        /// 获取或设置选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_list")]
                        public Types.Option[]? OptionList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置任务名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置发起人成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creator")]
                [System.Text.Json.Serialization.JsonPropertyName("creator")]
                public string CreatorUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置 ID 类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int IdType { get; set; }

                /// <summary>
                /// 获取或设置已完成上报人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finish_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("finish_cnt")]
                public int FinishCount { get; set; }

                /// <summary>
                /// 获取或设置上报方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("report_type")]
                [System.Text.Json.Serialization.JsonPropertyName("report_type")]
                public int ReportType { get; set; }

                /// <summary>
                /// 获取或设置上报范围信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_range")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_range")]
                public Types.ReportRange ReportRange { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇报对象信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("report_to")]
                [System.Text.Json.Serialization.JsonPropertyName("report_to")]
                public Types.ReportTo ReportTo { get; set; } = default!;

                /// <summary>
                /// 获取或设置非工作日是否需要上报。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skip_weekend")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("skip_weekend")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsSkipWeekend { get; set; }

                /// <summary>
                /// 获取或设置上报问题列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("question_templates")]
                [System.Text.Json.Serialization.JsonPropertyName("question_templates")]
                public Types.QuestionTemplate[] QuestionTemplateList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置任务信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("job_info")]
        [System.Text.Json.Serialization.JsonPropertyName("job_info")]
        public Types.ReportJob ReportJob { get; set; } = default!;
    }
}
