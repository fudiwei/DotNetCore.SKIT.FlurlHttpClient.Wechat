namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/topic/post_emoji 接口的请求。</para>
    /// </summary>
    public class CgibinAIBotTopicPostEmojiRequest : WechatWorkAIBotRequest
    {
        /// <summary>
        /// 获取或设置频道 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topic_id")]
        [System.Text.Json.Serialization.JsonPropertyName("topic_id")]
        public string? TopicId { get; set; }

        /// <summary>
        /// 获取或设置帖子 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_id")]
        [System.Text.Json.Serialization.JsonPropertyName("post_id")]
        public string? PostId { get; set; }

        /// <summary>
        /// 获取或设置评论 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reply_id")]
        [System.Text.Json.Serialization.JsonPropertyName("reply_id")]
        public string? ReplyId { get; set; }

        /// <summary>
        /// 获取或设置表情类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("emoji_type")]
        [System.Text.Json.Serialization.JsonPropertyName("emoji_type")]
        public int EmojiType { get; set; }

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public int Action { get; set; }
    }
}
