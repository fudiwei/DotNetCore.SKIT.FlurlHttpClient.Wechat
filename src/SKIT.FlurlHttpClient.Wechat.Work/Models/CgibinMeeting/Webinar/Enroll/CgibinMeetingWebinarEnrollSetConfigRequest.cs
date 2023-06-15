using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/webinar/enroll/set_config 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingWebinarEnrollSetConfigRequest : CgibinMeetingEnrollSetConfigRequest
    {
        public static new class Types
        {
            public class Question : CgibinMeetingEnrollSetConfigRequest.Types.Question
            {
                public static new class Types
                {
                    public class Option : CgibinMeetingEnrollSetConfigRequest.Types.Question.Types.Option
                    {
                    }
                }

                /// <summary>
                /// 获取或设置选项列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("option_list")]
                [System.Text.Json.Serialization.JsonPropertyName("option_list")]
                public new IList<Types.Option>? OptionList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置问题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("question_list")]
        [System.Text.Json.Serialization.JsonPropertyName("question_list")]
        public new IList<Types.Question>? QuestionList { get; set; }
    }
}
