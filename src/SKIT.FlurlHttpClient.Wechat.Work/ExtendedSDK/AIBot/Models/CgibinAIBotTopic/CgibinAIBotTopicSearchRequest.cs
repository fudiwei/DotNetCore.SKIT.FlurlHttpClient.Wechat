namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/topic/search 接口的请求。</para>
    /// </summary>
    public class CgibinAIBotTopicSearchRequest : WechatWorkAIBotRequest
    {
        public static class Types
        {
            public class Member
            {
                /// <summary>
                /// 获取或设置类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置成员 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置机器人 BotId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aibotid")]
                [System.Text.Json.Serialization.JsonPropertyName("aibotid")]
                public string? BotId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置关键词列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_list")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword_list")]
        public List<string>? KeywordList { get; set; }

        /// <summary>
        /// 获取或设置频道 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topic_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("topic_id_list")]
        public List<string>? TopicIdList { get; set; }

        /// <summary>
        /// 获取或设置频道关键词列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topic_keyword_list")]
        [System.Text.Json.Serialization.JsonPropertyName("topic_keyword_list")]
        public List<string>? TopicKeywordList { get; set; }

        /// <summary>
        /// 获取或设置发帖人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creator_list")]
        [System.Text.Json.Serialization.JsonPropertyName("creator_list")]
        public List<Types.Member>? CreatorList { get; set; }

        /// <summary>
        /// 获取或设置起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        public long? BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
