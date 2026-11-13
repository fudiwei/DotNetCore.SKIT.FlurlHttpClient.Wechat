namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/topic/send_post 接口的响应。</para>
    /// </summary>
    public class CgibinAIBotTopicSendPostResponse : WechatWorkAIBotResponse
    {
        /// <summary>
        /// 获取或设置帖子 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_id")]
        [System.Text.Json.Serialization.JsonPropertyName("post_id")]
        public string? PostId { get; set; }
    }
}
