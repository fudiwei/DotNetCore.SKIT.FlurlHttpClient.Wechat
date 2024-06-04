using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /feedback/{TOKEN} 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2023-04-07 下线。")]
    public class FeedbackRequest : WechatChatbotRequest, WechatChatbotRequest.Serialization.IEncryptedXmlable
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
