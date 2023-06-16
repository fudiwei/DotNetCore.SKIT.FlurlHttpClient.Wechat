namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/poll/get_poll_detail 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingPollGetPollDetailResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Question
            {
                public static class Types
                {
                    public class Option
                    {
                        public static class Types
                        {
                            public class User
                            {
                                /// <summary>
                                /// 获取或设置成员账号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("userid")]
                                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                                public string? UserId { get; set; }

                                /// <summary>
                                /// 获取或设置参会的成员临时 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tmp_openid")]
                                [System.Text.Json.Serialization.JsonPropertyName("tmp_openid")]
                                public string? TempOpenId { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置选项 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string QuestionId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置选项描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_desc")]
                        public string OptionDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置投票数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_num")]
                        public int Number { get; set; }

                        /// <summary>
                        /// 获取或设置投票率（范围：0～100）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("rate")]
                        public int Rate { get; set; }

                        /// <summary>
                        /// 获取或设置投票用户列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_user")]
                        public Types.User[]? UserList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置问题 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("question_id")]
                [System.Text.Json.Serialization.JsonPropertyName("question_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string QuestionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置问题类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("question_type")]
                [System.Text.Json.Serialization.JsonPropertyName("question_type")]
                public int QuestionType { get; set; }

                /// <summary>
                /// 获取或设置问题描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("question_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("question_desc")]
                public string QuestionDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置选项列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("option_info")]
                [System.Text.Json.Serialization.JsonPropertyName("option_info")]
                public Types.Option[] OptionList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置投票主题 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poll_theme_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poll_theme_id")]
        public string PollThemeId { get; set; } = default!;

        /// <summary>
        /// 获取或设置投票主题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poll_topic")]
        [System.Text.Json.Serialization.JsonPropertyName("poll_topic")]
        public string PollTopic { get; set; } = default!;

        /// <summary>
        /// 获取或设置投票主题描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poll_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("poll_desc")]
        public string PollDescription { get; set; } = default!;

        /// <summary>
        /// 获取或设置投票状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置是否共享。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_shared")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_shared")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsShared { get; set; }

        /// <summary>
        /// 获取或设置是否匿名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_anony")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_anony")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsAnonymous { get; set; }

        /// <summary>
        /// 获取或设置投票人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vote_total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("vote_total_num")]
        public int VoteTotalCount { get; set; }

        /// <summary>
        /// 获取或设置投票问题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poll_question_data")]
        [System.Text.Json.Serialization.JsonPropertyName("poll_question_data")]
        public Types.Question[] QuestionList { get; set; } = default!;
    }
}
