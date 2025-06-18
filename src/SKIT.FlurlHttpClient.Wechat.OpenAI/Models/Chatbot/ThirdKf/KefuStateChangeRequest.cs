namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /kefustate/change/{TOKEN} 接口的请求。</para>
    /// </summary>
    public class KefuStateChangeRequest : WechatChatbotRequest, WechatChatbotRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatChatbotClient"/> 时的 <see cref="WechatChatbotClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置客服接入状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kefustate")]
        [System.Text.Json.Serialization.JsonPropertyName("kefustate")]
        public string KfState { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires")]
        [System.Text.Json.Serialization.JsonPropertyName("expires")]
        public int? ExpiresIn { get; set; }
    }
}
