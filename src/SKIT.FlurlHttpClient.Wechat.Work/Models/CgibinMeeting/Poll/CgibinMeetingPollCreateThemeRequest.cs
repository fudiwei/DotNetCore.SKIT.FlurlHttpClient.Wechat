using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/poll/create_theme 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingPollCreateThemeRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Question
            {
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
                public string QuestionDescription { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置选项列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poll_option")]
                [System.Text.Json.Serialization.JsonPropertyName("poll_option")]
                public IList<string> OptionList { get; set; } = new List<string>();
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作者的 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("operator_userid")]
        public string OperatorUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置终端设备类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instance_id")]
        [System.Text.Json.Serialization.JsonPropertyName("instance_id")]
        public int InstanceId { get; set; }

        /// <summary>
        /// 获取或设置投票主题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poll_topic")]
        [System.Text.Json.Serialization.JsonPropertyName("poll_topic")]
        public string PollTopic { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置投票主题描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poll_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("poll_desc")]
        public string PollDescription { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否匿名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_anony")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_anony")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsAnonymous { get; set; }

        /// <summary>
        /// 获取或设置投票问题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poll_questions")]
        [System.Text.Json.Serialization.JsonPropertyName("poll_questions")]
        public IList<Types.Question> QuestionList { get; set; } = new List<Types.Question>();
    }
}
