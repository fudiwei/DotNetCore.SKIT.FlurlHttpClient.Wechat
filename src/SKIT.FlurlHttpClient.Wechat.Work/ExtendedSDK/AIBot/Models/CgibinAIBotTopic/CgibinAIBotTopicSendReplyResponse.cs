namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/topic/send_reply 接口的响应。</para>
    /// </summary>
    public class CgibinAIBotTopicSendReplyResponse : WechatWorkAIBotResponse
    {
        /// <summary>
        /// 获取或设置评论 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reply_id")]
        [System.Text.Json.Serialization.JsonPropertyName("reply_id")]
        public string? ReplyId { get; set; }
    }
}
