namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /nlp/translate_cn2en/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class NLPTranslateChinese2EnglishResponse : WechatOpenAIPlatformResponse
    {
        /// <summary>
        /// 获取或设置结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string Result { get; set; } = default!;
    }
}
