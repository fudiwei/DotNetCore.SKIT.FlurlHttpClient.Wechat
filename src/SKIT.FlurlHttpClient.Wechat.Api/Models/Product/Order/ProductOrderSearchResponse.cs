namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/order/search 接口的响应。</para>
    /// </summary>
    public class ProductOrderSearchResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order : ProductOrderGetResponse.Types.Order
            {
            }
        }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orders")]
        [System.Text.Json.Serialization.JsonPropertyName("orders")]
        public Types.Order[] OrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
