namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/poll/get_theme_info 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingPollGetThemeInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Question
            {
                public static class Types
                {
                    public class Option
                    {
                        /// <summary>
                        /// 获取或设置选项描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("option_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("option_desc")]
                        public string OptionDescription { get; set; } = default!;
                    }
                }

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
        /// 获取或设置是否匿名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_anony")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_anony")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool IsAnonymous { get; set; }

        /// <summary>
        /// 获取或设置投票问题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poll_question_data")]
        [System.Text.Json.Serialization.JsonPropertyName("poll_question_data")]
        public Types.Question[] QuestionList { get; set; } = default!;
    }
}
