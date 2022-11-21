namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /feedback/{TOKEN} 接口的请求。</para>
    /// </summary>
    public class FeedbackRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgid")]
        [System.Text.Json.Serialization.JsonPropertyName("msgid")]
        public string MessageId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置反馈结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feedbackResult")]
        [System.Text.Json.Serialization.JsonPropertyName("feedbackResult")]
        public int FeedbackResult { get; set; }

        /// <summary>
        /// 获取或设置用户反馈时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("updateAt")]
        [System.Text.Json.Serialization.JsonPropertyName("updateAt")]
        public long UpdateTimestamp { get; set; }
    }
}
