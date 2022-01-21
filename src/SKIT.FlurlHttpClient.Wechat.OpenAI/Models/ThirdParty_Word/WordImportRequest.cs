namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/word/import 接口的请求。</para>
    /// </summary>
    public class WordImportRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置上传的文件标识。与字段 <see cref="FileUrl"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_key")]
        [System.Text.Json.Serialization.JsonPropertyName("file_key")]
        public string? FileKey { get; set; }

        /// <summary>
        /// 获取或设置待上传文件 URL。与字段 <see cref="FileKey"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_uri")]
        [System.Text.Json.Serialization.JsonPropertyName("file_uri")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// 获取或设置是否覆盖。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover")]
        [System.Text.Json.Serialization.JsonPropertyName("cover")]
        public bool IsCover { get; set; }

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
