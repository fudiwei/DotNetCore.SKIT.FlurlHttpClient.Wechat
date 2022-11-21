namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /getbindlink/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class GetBindLinkResponse : WechatOpenAIResponse
    {
        /// <summary>
        /// 获取或设置绑定链接 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link")]
        [System.Text.Json.Serialization.JsonPropertyName("link")]
        public string Url { get; set; } = default!;
    }
}
