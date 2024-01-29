namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/sitecode/get_site_report_info 接口的响应。</para>
    /// </summary>
    public class CgibinReportSiteCodeGetSiteReportInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
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
                        /// 获取或设置选项文案。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_text")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_text")]
                        public string OptionText { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置问题 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("question_id")]
                [System.Text.Json.Serialization.JsonPropertyName("question_id")]
                public int QuestionId { get; set; }

                /// <summary>
                /// 获取或设置问题类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("question_type")]
                [System.Text.Json.Serialization.JsonPropertyName("question_type")]
                public int QuestionType { get; set; }

                /// <summary>
                /// 获取或设置问题标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否必填。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_required")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_required")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
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
        /// 获取或设置健康上报问题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("question_templates")]
        [System.Text.Json.Serialization.JsonPropertyName("question_templates")]
        public Types.QuestionTemplate[] QuestionTemplateList { get; set; } = default!;
    }
}
