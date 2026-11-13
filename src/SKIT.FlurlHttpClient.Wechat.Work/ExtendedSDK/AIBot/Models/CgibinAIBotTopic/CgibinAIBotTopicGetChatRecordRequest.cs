namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/topic/get_chat_record 接口的请求。</para>
    /// </summary>
    public class CgibinAIBotTopicGetChatRecordRequest : WechatWorkAIBotRequest
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
        /// 获取或设置聊天记录 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_record_id")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_record_id")]
        public string? ChatRecordId { get; set; }
    }
}
