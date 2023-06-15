namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/webinar/enroll/list 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingWebinarEnrollListResponse : CgibinMeetingEnrollListResponse
    {
        public static new class Types
        {
            public class Enroll : CgibinMeetingEnrollListResponse.Types.Enroll
            {
                public static new class Types
                {
                    public class Answer : CgibinMeetingEnrollListResponse.Types.Enroll.Types.Answer
                    {
                    }
                }

                /// <summary>
                /// 获取或设置答题列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("answer_list")]
                [System.Text.Json.Serialization.JsonPropertyName("answer_list")]
                public new Types.Answer[]? AnswerList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置报名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enroll_list")]
        [System.Text.Json.Serialization.JsonPropertyName("enroll_list")]
        public new Types.Enroll[] EnrollList { get; set; } = default!;
    }
}
