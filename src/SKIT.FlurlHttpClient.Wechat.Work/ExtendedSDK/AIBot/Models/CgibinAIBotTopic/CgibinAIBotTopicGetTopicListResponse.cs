namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/topic/get_topic_list 接口的响应。</para>
    /// </summary>
    public class CgibinAIBotTopicGetTopicListResponse : WechatWorkAIBotResponse
    {
        public static class Types
        {
            public class Topic
            {
                public static class Types
                {
                    public class Member : CgibinAIBotTopicSearchRequest.Types.Member
                    {
                    }
                }

                /// <summary>
                /// 获取或设置频道 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("topic_id")]
                [System.Text.Json.Serialization.JsonPropertyName("topic_id")]
                public string? TopicId { get; set; }

                /// <summary>
                /// 获取或设置频道名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("topic_name")]
                [System.Text.Json.Serialization.JsonPropertyName("topic_name")]
                public string? TopicName { get; set; }

                /// <summary>
                /// 获取或设置频道描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("topic_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("topic_desc")]
                public string? TopicDEscription { get; set; }

                /// <summary>
                /// 获取或设置频道权限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("permission")]
                [System.Text.Json.Serialization.JsonPropertyName("permission")]
                public int Permission { get; set; }

                /// <summary>
                /// 获取或设置创建者信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creator")]
                [System.Text.Json.Serialization.JsonPropertyName("creator")]
                public Types.Member? Creator { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

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
