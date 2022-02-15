namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [GET] /v2/dict/get_builtin_list 接口的响应。</para>
    /// </summary>
    public class DictionaryGetBuiltinListResponse : WechatOpenAIThirdPartyResponse<DictionaryGetBuiltinListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Dictionary
                    {
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
                }

                /// <summary>
                /// 获取或设置系统内置的词典列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Dictionary[] DictionaryList { get; set; } = default!;

                /// <summary>
                /// 获取或设置系统内置的词典总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int TotalCount { get; set; }
            }
        }
    }
}
