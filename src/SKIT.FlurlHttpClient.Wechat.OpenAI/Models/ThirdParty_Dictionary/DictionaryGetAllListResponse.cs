﻿namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/dict/get_all_list 接口的响应。</para>
    /// </summary>
    public class DictionaryGetAllListResponse : WechatOpenAIThirdPartyResponse<DictionaryGetAllListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class DictionaryItem
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
                        public string ChineseName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置英文名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name_en")]
                        [System.Text.Json.Serialization.JsonPropertyName("name_en")]
                        public string EnglishName { get; set; } = default!;
                    }

                    public class DictionaryList
                    {
                        /// <summary>
                        /// 获取或设置词典列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("list")]
                        [System.Text.Json.Serialization.JsonPropertyName("list")]
                        public DictionaryItem[] Items { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置词典总数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        public int TotalCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置系统内置的词典列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sys")]
                [System.Text.Json.Serialization.JsonPropertyName("sys")]
                public Types.DictionaryList BuiltinDictionaryList { get; set; } = default!;

                /// <summary>
                /// 获取或设置自定义的词典列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user")]
                [System.Text.Json.Serialization.JsonPropertyName("user")]
                public Types.DictionaryList CustomDictionaryList { get; set; } = default!;
            }
        }
    }
}
