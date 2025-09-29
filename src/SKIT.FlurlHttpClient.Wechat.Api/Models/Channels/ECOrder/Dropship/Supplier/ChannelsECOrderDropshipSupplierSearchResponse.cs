namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/dropship/supplier/search 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderDropshipSupplierSearchResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Pagination : ChannelsECOrderDropshipSupplierSearchRequest.Types.Pagination
            {
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
