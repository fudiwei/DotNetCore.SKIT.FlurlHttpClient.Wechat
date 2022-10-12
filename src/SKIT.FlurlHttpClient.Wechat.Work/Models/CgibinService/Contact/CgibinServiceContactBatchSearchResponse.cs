namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/contact/batchsearch 接口的响应。</para>
    /// </summary>
    public class CgibinServiceContactBatchSearchResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Query
            {
                public static class Types
                {
                    public class QueryRequest
                    {
                        /// <summary>
                        /// 获取或设置搜索关键词。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("query_word")]
                        [System.Text.Json.Serialization.JsonPropertyName("query_word")]
                        public string QueryWord { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置查询类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("query_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("query_type")]
                        public int? QueryType { get; set; }

                        /// <summary>
                        /// 获取或设置查询范围。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("query_range")]
                        [System.Text.Json.Serialization.JsonPropertyName("query_range")]
                        public int? QueryRange { get; set; }

                        /// <summary>
                        /// 获取或设置精确匹配字段类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("full_match_field")]
                        [System.Text.Json.Serialization.JsonPropertyName("full_match_field")]
                        public int? FullMatchField { get; set; }

                        /// <summary>
                        /// 获取或设置翻页标记。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cursor")]
                        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                        public string? Cursor { get; set; }

                        /// <summary>
                        /// 获取或设置分页每页数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("limit")]
                        public int? Limit { get; set; }
                    }

                    public class QueryResult : CgibinServiceContactSearchResponse.Types.QueryResult
                    {
                    }
                }

                /// <summary>
                /// 获取或设置搜索请求信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query_request")]
                [System.Text.Json.Serialization.JsonPropertyName("query_request")]
                public Types.QueryRequest QueryRequest { get; set; } = default!;

                /// <summary>
                /// 获取或设置搜索结果信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query_result")]
                [System.Text.Json.Serialization.JsonPropertyName("query_result")]
                public Types.QueryResult QueryResult { get; set; } = default!;

                /// <summary>
                /// 获取或设置翻页是否结束。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_last")]
                [System.Text.Json.Serialization.JsonPropertyName("is_last")]
                public bool IsLast { get; set; }

                /// <summary>
                /// 获取或设置翻页标记。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
                public string? NextCursor { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置搜索列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_result_list")]
        [System.Text.Json.Serialization.JsonPropertyName("query_result_list")]
        public Types.Query[] QueryList { get; set; } = default!;
    }
}
