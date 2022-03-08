namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/api/set_welcome_msg 接口的请求。</para>
    /// </summary>
    public class ApiSetWelcomeMessageRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置渠道 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channelId")]
        [System.Text.Json.Serialization.JsonPropertyName("channelId")]
        public string ChannelId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置来源类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source")]
        [System.Text.Json.Serialization.JsonPropertyName("source")]
        public int Source { get; set; }

        /// <summary>
        /// 获取或设置欢迎语 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgId")]
        [System.Text.Json.Serialization.JsonPropertyName("msgId")]
        public string? MessageId { get; set; }

        /// <summary>
        /// 获取或设置欢迎语类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgType")]
        [System.Text.Json.Serialization.JsonPropertyName("msgType")]
        public string MessageType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置欢迎语内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("welcomeMsg")]
        [System.Text.Json.Serialization.JsonPropertyName("welcomeMsg")]
        public string MessageContent { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置标签 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lableId")]
        [System.Text.Json.Serialization.JsonPropertyName("lableId")]
        public string? LabelId { get; set; }

        /// <summary>
        /// 获取或设置发送间隔（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("newSendInterval")]
        [System.Text.Json.Serialization.JsonPropertyName("newSendInterval")]
        public int SendInterval { get; set; }
    }
}
