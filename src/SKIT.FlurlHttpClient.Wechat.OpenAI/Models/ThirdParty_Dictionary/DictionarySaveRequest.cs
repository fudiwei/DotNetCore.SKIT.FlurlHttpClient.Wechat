using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/dict/save 接口的请求。</para>
    /// </summary>
    public class DictionarySaveRequest : WechatOpenAIThirdPartyRequest
    {
        public static class Types
        {
            public class Dictionary
            {
                /// <summary>
                /// 获取或设置词典 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long? DictionaryId { get; set; }

                /// <summary>
                /// 获取或设置中文名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name_ch")]
                [System.Text.Json.Serialization.JsonPropertyName("name_ch")]
                public string ChineseName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置英文名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name_en")]
                [System.Text.Json.Serialization.JsonPropertyName("name_en")]
                public string? EnglishName { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置词典列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public IList<Types.Dictionary> DictionaryList { get; set; } = new List<Types.Dictionary>();
    }
}
