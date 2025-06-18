namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/bot/effective_progress 接口的请求。</para>
    /// </summary>
    public class BotEffectiveProgressV2Request : WechatOpenAIRequest
    {
        /// <summary>
        /// 获取或设置查询环境。
        /// <para>默认值："online"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string Environment { get; set; } = "online";
    }
}
