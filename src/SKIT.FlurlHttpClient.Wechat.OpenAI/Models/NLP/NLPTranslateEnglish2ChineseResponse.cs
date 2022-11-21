namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /nlp/translate_en2cn/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class NLPTranslateEnglish2ChineseResponse : WechatOpenAIResponse
    {
        /// <summary>
        /// 获取或设置结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string Result { get; set; } = default!;
    }
}
