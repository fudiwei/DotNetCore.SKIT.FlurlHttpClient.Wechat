namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/store/classification/tree/product/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECStoreClassificationTreeProductGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置商品 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("product_ids")]
                public long[] ProductIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置下一页分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_context")]
                [System.Text.Json.Serialization.JsonPropertyName("page_context")]
                public string? NextCursor { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置响应数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resp")]
        [System.Text.Json.Serialization.JsonPropertyName("resp")]
        public Types.Data Data { get; set; } = default!;
    }
}
