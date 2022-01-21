using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/word/import/json 接口的请求。</para>
    /// </summary>
    public class WordImportJsonRequest : WechatOpenAIThirdPartyRequest
    {
        public static class Types
        {
            public class Word
            {
                /// <summary>
                /// 获取或设置词条名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("word")]
                [System.Text.Json.Serialization.JsonPropertyName("word")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置权重（范围：0～1）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("weight")]
                [System.Text.Json.Serialization.JsonPropertyName("weight")]
                public double? Weight { get; set; }

                /// <summary>
                /// 获取或设置同义词列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("synonyms")]
                [System.Text.Json.Serialization.JsonPropertyName("synonyms")]
                public IList<string>? SynonymsList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置词条列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public IList<Types.Word> WordList { get; set; } = new List<Types.Word>();

        /// <summary>
        /// 获取或设置导入模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mode")]
        [System.Text.Json.Serialization.JsonPropertyName("mode")]
        public int Mode { get; set; }

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
