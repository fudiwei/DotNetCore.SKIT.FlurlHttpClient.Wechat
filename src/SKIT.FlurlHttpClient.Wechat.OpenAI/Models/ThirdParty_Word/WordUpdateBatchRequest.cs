using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/word/update/batch 接口的请求。</para>
    /// </summary>
    public class WordUpdateBatchRequest : WechatOpenAIThirdPartyRequest
    {
        public static class Types
        {
            public class Word
            {
                /// <summary>
                /// 获取或设置词条 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long? WordId { get; set; }

                /// <summary>
                /// 获取或设置词条名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置权重（范围：0～1）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("weight")]
                [System.Text.Json.Serialization.JsonPropertyName("weight")]
                public double? Weight { get; set; }

                /// <summary>
                /// 获取或设置词条开关。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("switch")]
                [System.Text.Json.Serialization.JsonPropertyName("switch")]
                public bool Switch { get; set; }

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
        /// 获取或设置词典 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dict_id")]
        [System.Text.Json.Serialization.JsonPropertyName("dict_id")]
        public long DictionaryId { get; set; }
    }
}
