namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/get_token 接口的响应。</para>
    /// </summary>
    public class CgibinAIBotGetTokenResponse : WechatWorkAIBotResponse
    {
        /// <summary>
        /// 获取或设置机器人接口调用凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }
    }
}
