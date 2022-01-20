namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/promoter/order/search 接口的响应。</para>
    /// </summary>
    public class UnionPromoterOrderSearchResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order : UnionPromoterOrderInfoResponse.Types.Order
            {
            }
        }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orderList")]
        [System.Text.Json.Serialization.JsonPropertyName("orderList")]

        public Types.Order[] OrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalNum")]
        [System.Text.Json.Serialization.JsonPropertyName("totalNum")]
        public int Total { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pageSize")]
        [System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public int Limit { get; set; }
    }
}
