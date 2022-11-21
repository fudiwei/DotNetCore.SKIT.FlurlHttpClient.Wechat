using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /feedback/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class FeedbackRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [XmlElement("msgid")]
        public string MessageId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置反馈结果。
        /// </summary>
        [XmlElement("feedbackResult")]
        public int FeedbackResult { get; set; }

        /// <summary>
        /// 获取或设置用户反馈时间戳。
        /// </summary>
        [XmlElement("updateAt")]
        public long UpdateTimestamp { get; set; }
    }
}
