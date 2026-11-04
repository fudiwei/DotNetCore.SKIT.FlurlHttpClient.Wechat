namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/user/get_student_customize_health_info 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolUserGetStudentCustomizeHealthInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class HealthInfo : CgibinSchoolUserGetTeacherCustomizeHealthInfoResponse.Types.__zz__HealthInfo
            {
                public static class Types
                {
                    public class ReportValue : CgibinSchoolUserGetTeacherCustomizeHealthInfoResponse.Types.HealthInfo.Types.ReportValue
                    {
                    }
                }

                /// <summary>
                /// 获取或设置填写答案列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("report_values")]
                [System.Text.Json.Serialization.JsonPropertyName("report_values")]
                public List<Types.ReportValue>? ReportValueList { get; set; }
            }

            public class QuestionTemplate : CgibinSchoolUserGetTeacherCustomizeHealthInfoResponse.Types.__zz__QuestionTemplate
            {
                public static class Types
                {
                    public class Option : CgibinSchoolUserGetTeacherCustomizeHealthInfoResponse.Types.QuestionTemplate.Types.Option
                    {
                    }
                }

                /// <summary>
                /// 获取或设置选项列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("option_list")]
                [System.Text.Json.Serialization.JsonPropertyName("option_list")]
                public List<Types.Option>? OptionList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置自定义问题模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// 获取或设置自定义问题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("question_templates")]
        [System.Text.Json.Serialization.JsonPropertyName("question_templates")]
        public List<Types.QuestionTemplate>? QuestionTemplateList { get; set; }

        /// <summary>
        /// 获取或设置健康信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("health_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("health_infos")]
        public List<Types.HealthInfo>? HealthInfoList { get; set; }

        /// <summary>
        /// 获取或设置翻页是否结束。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ending")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("ending")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
        public bool IsEnding { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }
    }
}
