using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/poll/update_theme 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingPollUpdateThemeRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Question : CgibinMeetingPollCreateThemeRequest.Types.Question
            {
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置投票主题 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poll_theme_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poll_theme_id")]
        public string PollThemeId { get; set; } = string.Empty;

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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_anony")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsAnonymous { get; set; }

        /// <summary>
        /// 获取或设置投票问题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poll_questions")]
        [System.Text.Json.Serialization.JsonPropertyName("poll_questions")]
        public IList<Types.Question> QuestionList { get; set; } = new List<Types.Question>();
    }
}
