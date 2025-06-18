namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/poll/get_poll_list 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingPollGetPollListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class PollTheme
            {
                public static class Types
                {
                    public class Poll
                    {
                        /// <summary>
                        /// 获取或设置投票 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poll_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("poll_id")]
                        public string PollId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置投票主题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poll_topic")]
                        [System.Text.Json.Serialization.JsonPropertyName("poll_topic")]
                        public string PollTopic { get; set; } = default!;

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
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_shared")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool IsShared { get; set; }

                        /// <summary>
                        /// 获取或设置是否匿名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_anony")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_anony")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool IsAnonymous { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置投票主题 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poll_theme_id")]
                [System.Text.Json.Serialization.JsonPropertyName("poll_theme_id")]
                public string PollThemeId { get; set; } = default!;

                /// <summary>
                /// 获取或设置投票列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("polls_info")]
                [System.Text.Json.Serialization.JsonPropertyName("polls_info")]
                public Types.Poll[] PollList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置投票主题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("polls_theme_info")]
        [System.Text.Json.Serialization.JsonPropertyName("polls_theme_info")]
        public Types.PollTheme[] PollThemeList { get; set; } = default!;
    }
}
