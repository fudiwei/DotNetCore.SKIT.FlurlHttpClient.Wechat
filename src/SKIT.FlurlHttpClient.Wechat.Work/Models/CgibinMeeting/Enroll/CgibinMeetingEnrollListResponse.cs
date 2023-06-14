namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/enroll/list 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingEnrollListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Enroll
            {
                public static class Types
                {
                    public class Answer
                    {
                        /// <summary>
                        /// 获取或设置内容列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("answer_content")]
                        [System.Text.Json.Serialization.JsonPropertyName("answer_content")]
                        public string[] ContentList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置必填类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_required")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_required")]
                        public int RequiredType { get; set; }

                        /// <summary>
                        /// 获取或设置问题类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("question_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("question_type")]
                        public int QuestionType { get; set; }

                        /// <summary>
                        /// 获取或设置特殊问题类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("special_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("special_type")]
                        public int SpecialType { get; set; }

                        /// <summary>
                        /// 获取或设置问题编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("question_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("question_num")]
                        public int QuestionNumber { get; set; }

                        /// <summary>
                        /// 获取或设置问题标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("question_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("question_title")]
                        public string? QuestionTitle { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置报名 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enroll_id")]
                [System.Text.Json.Serialization.JsonPropertyName("enroll_id")]
                public string EnrollId { get; set; } = default!;

                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置临时 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tmp_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("tmp_openid")]
                public string? TempOpenId { get; set; }

                /// <summary>
                /// 获取或设置报名时间字符串（格式：yyyy/MM/dd HH:mm）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enroll_time")]
                [System.Text.Json.Serialization.JsonPropertyName("enroll_time")]
                public string EnrollTimeString { get; set; } = default!;

                /// <summary>
                /// 获取或设置报名来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enroll_source_type")]
                [System.Text.Json.Serialization.JsonPropertyName("enroll_source_type")]
                public int SourceType { get; set; }

                /// <summary>
                /// 获取或设置昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nick_name")]
                [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
                public string? Nickname { get; set; }

                /// <summary>
                /// 获取或设置报名状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置报名码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enroll_code")]
                [System.Text.Json.Serialization.JsonPropertyName("enroll_code")]
                public string? EnrollCode { get; set; }

                /// <summary>
                /// 获取或设置答题列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("answer_list")]
                [System.Text.Json.Serialization.JsonPropertyName("answer_list")]
                public Types.Answer[]? AnswerList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置报名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enroll_list")]
        [System.Text.Json.Serialization.JsonPropertyName("enroll_list")]
        public Types.Enroll[] EnrollList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
