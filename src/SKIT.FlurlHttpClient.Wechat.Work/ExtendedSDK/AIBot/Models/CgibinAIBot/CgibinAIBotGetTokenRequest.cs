namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/get_token 接口的请求。</para>
    /// </summary>
    public class CgibinAIBotGetTokenRequest : WechatWorkAIBotRequest
    {
        /// <summary>
        /// 获取或设置机器人 ID。如果不指定将使用构造 <see cref="WechatWorkAIBotClient"/> 时的 <see cref="WechatWorkAIBotClientOptions.BotId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bot_id")]
        [System.Text.Json.Serialization.JsonPropertyName("bot_id")]
        public string? BotId { get; set; }

        /// <summary>
        /// 获取或设置时间戳。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time")]
        [System.Text.Json.Serialization.JsonPropertyName("time")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// 获取或设置随机字符串。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nonce")]
        [System.Text.Json.Serialization.JsonPropertyName("nonce")]
        public string? Nonce { get; set; }

        /// <summary>
        /// 获取或设置请求签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signature")]
        [System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }
    }
}
