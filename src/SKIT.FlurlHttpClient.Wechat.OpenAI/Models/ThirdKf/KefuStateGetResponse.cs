namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /kefustate/get/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class KefuStateGetResponse : WechatOpenAIResponse
    {
        /// <summary>
        /// 获取或设置客服接入状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kefustate")]
        [System.Text.Json.Serialization.JsonPropertyName("kefustate")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置人工客服接入状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;
    }
}
