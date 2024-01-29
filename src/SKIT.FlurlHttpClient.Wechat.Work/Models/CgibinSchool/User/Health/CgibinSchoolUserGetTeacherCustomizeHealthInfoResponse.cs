namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/user/get_teacher_customize_health_info 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolUserGetTeacherCustomizeHealthInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class HealthInfo
            {
                public static class Types
                {
                    public class ReportValue
                    {
                        /// <summary>
                        /// 获取或设置问题 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("question_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("question_id")]
                        public int QuestionId { get; set; }

                        /// <summary>
                        /// 获取或设置单选题答案编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("single_chose")]
                        [System.Text.Json.Serialization.JsonPropertyName("single_chose")]
                        public int? SignleChoice { get; set; }

                        /// <summary>
                        /// 获取或设置填空题答案内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public string? Text { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置用户 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置健康码状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("health_qrcode_status")]
                [System.Text.Json.Serialization.JsonPropertyName("health_qrcode_status")]
                public int HealthQrcodeStatus { get; set; }

                /// <summary>
                /// 获取或设置健康状态是否为本人填写。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("self_submit")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("self_submit")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsSelfSubmit { get; set; }

                /// <summary>
                /// 获取或设置填写答案列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("report_values")]
                [System.Text.Json.Serialization.JsonPropertyName("report_values")]
                public Types.ReportValue[] ReportValueList { get; set; } = default!;
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
                [Newtonsoft.Json.JsonProperty("is_must_fill")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_must_fill")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsRequired { get; set; }

                /// <summary>
                /// 获取或设置是否隐藏。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_not_display")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_not_display")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsHidden { get; set; }

                /// <summary>
                /// 获取或设置选项列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("option_list")]
                [System.Text.Json.Serialization.JsonPropertyName("option_list")]
                public Types.Option[]? OptionList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置自定义问题模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = default!;

        /// <summary>
        /// 获取或设置自定义问题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("question_templates")]
        [System.Text.Json.Serialization.JsonPropertyName("question_templates")]
        public Types.QuestionTemplate[] QuestionTemplateList { get; set; } = default!;

        /// <summary>
        /// 获取或设置健康信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("health_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("health_infos")]
        public Types.HealthInfo[] HealthInfoList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页是否结束。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ending")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("ending")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool IsEnding { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }
    }
}
