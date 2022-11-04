namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/databasecollectionget 接口的响应。</para>
    /// </summary>
    public class TCBDatabaseCollectionGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Collection
            {
                /// <summary>
                /// 获取或设置集合名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string CollectionName { get; set; } = default!;

                /// <summary>
                /// 获取或设置数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int RecordCount { get; set; }

                /// <summary>
                /// 获取或设置大小。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size")]
                [System.Text.Json.Serialization.JsonPropertyName("size")]
                public int RecordSize { get; set; }

                /// <summary>
                /// 获取或设置索引数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("index_count")]
                [System.Text.Json.Serialization.JsonPropertyName("index_count")]
                public int IndexCount { get; set; }

                /// <summary>
                /// 获取或设置索引大小。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("index_size")]
                [System.Text.Json.Serialization.JsonPropertyName("index_size")]
                public int IndexSize { get; set; }
            }

            public class Pagination
            {
                /// <summary>
                /// 获取或设置分页起始位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Offset")]
                [System.Text.Json.Serialization.JsonPropertyName("Offset")]
                public int Offset { get; set; }

                /// <summary>
                /// 获取或设置分页每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Limit")]
                [System.Text.Json.Serialization.JsonPropertyName("Limit")]
                public int Limit { get; set; }

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Total")]
                [System.Text.Json.Serialization.JsonPropertyName("Total")]
                public int TotalCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置集合列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collections")]
        [System.Text.Json.Serialization.JsonPropertyName("collections")]
        public Types.Collection[] CollectionList { get; set; } = default!;

        /// <summary>
        /// 获取或设置查询分页信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pager")]
        [System.Text.Json.Serialization.JsonPropertyName("pager")]
        public Types.Pagination Pagination { get; set; } = default!;
    }
}
