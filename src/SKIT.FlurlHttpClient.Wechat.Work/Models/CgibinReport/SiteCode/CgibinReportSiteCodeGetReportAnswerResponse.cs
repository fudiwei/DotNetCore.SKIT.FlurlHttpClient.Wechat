namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/sitecode/get_report_answer 接口的响应。</para>
    /// </summary>
    public class CgibinReportSiteCodeGetReportAnswerResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Answer
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
                        /// 获取或设置单选题答案 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("single_choice")]
                        [System.Text.Json.Serialization.JsonPropertyName("single_choice")]
                        public int? SingleChoiceOptionId { get; set; }

                        /// <summary>
                        /// 获取或设置多选题答案 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("multi_choice")]
                        [System.Text.Json.Serialization.JsonPropertyName("multi_choice")]
                        public int[]? MultiChoiceOptionIdList { get; set; }

                        /// <summary>
                        /// 获取或设置填空题答案内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public string? Text { get; set; }

                        /// <summary>
                        /// 获取或设置图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }

                        /// <summary>
                        /// 获取或设置行程卡类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("itinerary_card_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("itinerary_card_type")]
                        public int? ItineraryCardType { get; set; }

                        /// <summary>
                        /// 获取或设置高风险行程信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("high_risk_area")]
                        [System.Text.Json.Serialization.JsonPropertyName("high_risk_area")]
                        public string? HighRiskArea { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置上报时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("report_time")]
                [System.Text.Json.Serialization.JsonPropertyName("report_time")]
                public long ReportTimestamp { get; set; }

                /// <summary>
                /// 获取或设置上报信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("report_values")]
                [System.Text.Json.Serialization.JsonPropertyName("report_values")]
                public Types.ReportValue[] ReportValueList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置答案列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("answers")]
        [System.Text.Json.Serialization.JsonPropertyName("answers")]
        public Types.Answer[] AnswerList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
