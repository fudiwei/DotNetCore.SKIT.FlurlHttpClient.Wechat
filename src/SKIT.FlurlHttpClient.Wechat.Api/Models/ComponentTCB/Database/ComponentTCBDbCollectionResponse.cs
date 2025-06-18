namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/dbcollection 接口的响应。</para>
    /// </summary>
    public class ComponentTCBDbCollectionResponse : WechatApiResponse
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
        }

        /// <summary>
        /// 获取或设置集合列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collections")]
        [System.Text.Json.Serialization.JsonPropertyName("collections")]
        public Types.Collection[]? CollectionList { get; set; }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? TotalCount { get; set; }
    }
}
