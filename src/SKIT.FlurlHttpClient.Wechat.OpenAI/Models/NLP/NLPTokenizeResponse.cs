namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /nlp/tokenize/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class NLPTokenizeResponse : WechatOpenAIResponse
    {
        /// <summary>
        /// 获取或设置常规粒度分词结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("words")]
        [System.Text.Json.Serialization.JsonPropertyName("words")]
        public string[] WordList { get; set; } = default!;

        /// <summary>
        /// 获取或设置常规粒度词性标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("POSs")]
        [System.Text.Json.Serialization.JsonPropertyName("POSs")]
        public int[] POSList { get; set; } = default!;

        /// <summary>
        /// 获取或设置混合粒度分词结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("words_mix")]
        [System.Text.Json.Serialization.JsonPropertyName("words_mix")]
        public string[] WordMixList { get; set; } = default!;

        /// <summary>
        /// 获取或设置混合粒度词性标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("POSs_mix")]
        [System.Text.Json.Serialization.JsonPropertyName("POSs_mix")]
        public int[] POSMixList { get; set; } = default!;

        /// <summary>
        /// 获取或设置短语提取结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entities")]
        [System.Text.Json.Serialization.JsonPropertyName("entities")]
        public string[] EntityList { get; set; } = default!;

        /// <summary>
        /// 获取或设置短语类型标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entity_types")]
        [System.Text.Json.Serialization.JsonPropertyName("entity_types")]
        public int[] EntityTypeList { get; set; } = default!;
    }
}
