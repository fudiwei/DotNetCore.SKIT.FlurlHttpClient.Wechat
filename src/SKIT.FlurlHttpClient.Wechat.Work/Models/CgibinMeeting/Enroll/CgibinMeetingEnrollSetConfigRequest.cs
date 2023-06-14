using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/enroll/set_config 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingEnrollSetConfigRequest : WechatWorkRequest
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
                        /// 获取或设置选项内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string? Content { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置必填类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_required")]
                [System.Text.Json.Serialization.JsonPropertyName("is_required")]
                public int? RequiredType { get; set; }

                /// <summary>
                /// 获取或设置问题类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("question_type")]
                [System.Text.Json.Serialization.JsonPropertyName("question_type")]
                public int? QuestionType { get; set; }

                /// <summary>
                /// 获取或设置特殊问题类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("special_type")]
                [System.Text.Json.Serialization.JsonPropertyName("special_type")]
                public int? SpecialType { get; set; }

                /// <summary>
                /// 获取或设置问题标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("question_title")]
                [System.Text.Json.Serialization.JsonPropertyName("question_title")]
                public string? QuestionTitle { get; set; }

                /// <summary>
                /// 获取或设置选项列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("option_list")]
                [System.Text.Json.Serialization.JsonPropertyName("option_list")]
                public IList<Types.Option>? OptionList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置审批类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approve_type")]
        [System.Text.Json.Serialization.JsonPropertyName("approve_type")]
        public int? ApproveType { get; set; }

        /// <summary>
        /// 获取或设置收集问题类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_collect_question")]
        [System.Text.Json.Serialization.JsonPropertyName("is_collect_question")]
        public int? CollectQuestionType { get; set; }

        /// <summary>
        /// 获取或设置问题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("question_list")]
        [System.Text.Json.Serialization.JsonPropertyName("question_list")]
        public IList<Types.Question>? QuestionList { get; set; }

        /// <summary>
        /// 获取或设置是否本企业成员无需报名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("no_registration_needed_for_staff")]
        [System.Text.Json.Serialization.JsonPropertyName("no_registration_needed_for_staff")]
        public bool? IsNoRegistrationNeededForStaff { get; set; }
    }
}
