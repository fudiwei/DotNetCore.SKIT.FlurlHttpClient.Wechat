namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /getbindlist/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class GetBindListResponse : WechatOpenAIResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public override int? ReturnCode { get; set; }

        /// <summary>
        /// 获取微信智能对话 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string? ReturnMessage { get; set; }

        /// <summary>
        /// 获取或设置绑定列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bindlist")]
        [System.Text.Json.Serialization.JsonPropertyName("bindlist")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.DynamicObjectConverter))]
        public dynamic BindList { get; set; } = default!;
    }
}
