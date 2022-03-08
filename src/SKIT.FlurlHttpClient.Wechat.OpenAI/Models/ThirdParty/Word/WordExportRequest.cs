namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/word/export 接口的请求。</para>
    /// </summary>
    public class WordExportRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置词典 ID。与字段 <see cref="DictionaryName"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dict_id")]
        [System.Text.Json.Serialization.JsonPropertyName("dict_id")]
        public long? DictionaryId { get; set; }

        /// <summary>
        /// 获取或设置词典名称。与字段 <see cref="DictionaryId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dict_name")]
        [System.Text.Json.Serialization.JsonPropertyName("dict_name")]
        public string? DictionaryName { get; set; }
    }
}
