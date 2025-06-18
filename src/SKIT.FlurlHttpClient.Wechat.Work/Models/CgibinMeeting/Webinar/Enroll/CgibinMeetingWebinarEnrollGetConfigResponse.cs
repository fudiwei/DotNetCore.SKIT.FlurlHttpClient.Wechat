namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/webinar/enroll/get_config 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingWebinarEnrollGetConfigResponse : CgibinMeetingEnrollGetConfigResponse
    {
        public static new class Types
        {
            public class Question : CgibinMeetingEnrollGetConfigResponse.Types.Question
            {
                public static new class Types
                {
                    public class Option : CgibinMeetingEnrollGetConfigResponse.Types.Question.Types.Option
                    {
                    }
                }

                /// <summary>
                /// 获取或设置选项列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("option_list")]
                [System.Text.Json.Serialization.JsonPropertyName("option_list")]
                public new Types.Option[]? OptionList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置问题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("question_list")]
        [System.Text.Json.Serialization.JsonPropertyName("question_list")]
        public new Types.Question[] QuestionList { get; set; } = default!;
    }
}
