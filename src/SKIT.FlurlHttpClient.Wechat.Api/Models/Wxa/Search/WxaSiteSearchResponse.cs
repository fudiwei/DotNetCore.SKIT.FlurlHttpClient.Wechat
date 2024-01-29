namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sitesearch 接口的响应。</para>
    /// </summary>
    public class WxaSiteSearchResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置小程序页面标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序页面主图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image")]
                [System.Text.Json.Serialization.JsonPropertyName("image")]
                public string ImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序页面摘要。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string Path { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置搜索结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public Types.Result[] ResultList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否有下一页。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_next_page")]
        [System.Text.Json.Serialization.JsonPropertyName("has_next_page")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 获取或设置请求下一页的参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_page_info")]
        [System.Text.Json.Serialization.JsonPropertyName("next_page_info")]
        public string NextPageParameter { get; set; } = default!;

        /// <summary>
        /// 获取或设置估算索引文档数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hit_count")]
        [System.Text.Json.Serialization.JsonPropertyName("hit_count")]
        public int HitCount { get; set; }
    }
}
