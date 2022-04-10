namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/order/get_list 接口的响应。</para>
    /// </summary>
    public class ShopOrderGetListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order : ShopOrderGetResponse.Types.Order
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
