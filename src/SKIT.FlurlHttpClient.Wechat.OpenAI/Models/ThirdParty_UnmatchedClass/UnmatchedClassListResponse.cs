namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v1/unmatched/class/list 接口的响应。</para>
    /// </summary>
    public class UnmatchedClassListResponse : WechatOpenAIThirdPartyResponse<UnmatchedClassListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Class
                    {
                        /// <summary>
                        /// 获取或设置话术 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public long ClassId { get; set; }

                        /// <summary>
                        /// 获取或设置话术名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置未命中数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        public int Count { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置话术列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Class[] ClassList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置分页页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_no")]
                [System.Text.Json.Serialization.JsonPropertyName("page_no")]
                public int Page { get; set; }

                /// <summary>
                /// 获取或设置分页每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_size")]
                [System.Text.Json.Serialization.JsonPropertyName("page_size")]
                public int Limit { get; set; }
            }
        }
    }
}
