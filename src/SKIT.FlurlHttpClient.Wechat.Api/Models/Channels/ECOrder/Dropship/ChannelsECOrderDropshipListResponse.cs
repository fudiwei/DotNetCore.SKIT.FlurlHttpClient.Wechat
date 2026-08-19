namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/dropship/list 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderDropshipListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Pagination
            {
                /// <summary>
                /// 获取或设置分页起始位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("offset")]
                [System.Text.Json.Serialization.JsonPropertyName("offset")]
                public int? Offset { get; set; }

                /// <summary>
                /// 获取或设置分页每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limit")]
                [System.Text.Json.Serialization.JsonPropertyName("limit")]
                public int Limit { get; set; }

                /// <summary>
                /// 获取或设置下一页分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_key")]
                [System.Text.Json.Serialization.JsonPropertyName("next_key")]
                public string? NextCursor { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置代发单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ds_order_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("ds_order_id_list")]
        public string[] DropshipOrderIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置下一页分页信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_page")]
        [System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public Types.Pagination? NextPagination { get; set; }
    }
}
