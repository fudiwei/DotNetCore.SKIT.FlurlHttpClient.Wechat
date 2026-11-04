namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/webinar/enroll/list 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingWebinarEnrollListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Enroll : CgibinMeetingEnrollListResponse.Types.__zz__Enroll
            {
                public static class Types
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
                public List<Types.Answer>? AnswerList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置报名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enroll_list")]
        [System.Text.Json.Serialization.JsonPropertyName("enroll_list")]
        public List<Types.Enroll>? EnrollList { get; set; }

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
