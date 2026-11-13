namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/topic/search 接口的响应。</para>
    /// </summary>
    public class CgibinAIBotTopicSearchResponse : WechatWorkAIBotResponse
    {
        public static class Types
        {
            public class Topic
            {
                /// <summary>
                /// 获取或设置频道 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("topic_id")]
                [System.Text.Json.Serialization.JsonPropertyName("topic_id")]
                public string? TopicId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置搜索任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string? JobId { get; set; }

        /// <summary>
        /// 获取或设置频道列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topic_list")]
        [System.Text.Json.Serialization.JsonPropertyName("topic_list")]
        public Types.Topic[]? TopicList { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置下一页分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
