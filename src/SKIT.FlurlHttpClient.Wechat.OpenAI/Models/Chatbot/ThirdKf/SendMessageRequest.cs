namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /sendmsg/{TOKEN} 接口的请求。</para>
    /// </summary>
    public class SendMessageRequest : WechatChatbotRequest, WechatChatbotRequest.Serialization.IEncryptedXmlable
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
        /// 获取或设置消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置渠道。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel")]
        [System.Text.Json.Serialization.JsonPropertyName("channel")]
        public int Channel { get; set; }

        /// <summary>
        /// 获取或设置事件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event")]
        [System.Text.Json.Serialization.JsonPropertyName("event")]
        public string? Event { get; set; }

        /// <summary>
        /// 获取或设置客服人员的昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kefuname")]
        [System.Text.Json.Serialization.JsonPropertyName("kefuname")]
        public string? KfName { get; set; }

        /// <summary>
        /// 获取或设置客服人员的头像 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kefuavatar")]
        [System.Text.Json.Serialization.JsonPropertyName("kefuavatar")]
        public string? KfAvatarUrl { get; set; }

        /// <summary>
        /// 获取或设置分类或技能名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ans_node_name")]
        [System.Text.Json.Serialization.JsonPropertyName("ans_node_name")]
        public string? AnswerNodeName { get; set; }
    }
}
