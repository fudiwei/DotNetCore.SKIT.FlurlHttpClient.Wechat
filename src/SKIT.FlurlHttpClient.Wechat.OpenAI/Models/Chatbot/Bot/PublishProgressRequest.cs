namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /publish_progress/{TOKEN} 接口的请求。</para>
    /// </summary>
    public class PublishProgressRequest : WechatChatbotRequest, WechatChatbotRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置管理员 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("managerid")]
        [System.Text.Json.Serialization.JsonPropertyName("managerid")]
        public string ManagerId { get; set; } = string.Empty;
    }
}
