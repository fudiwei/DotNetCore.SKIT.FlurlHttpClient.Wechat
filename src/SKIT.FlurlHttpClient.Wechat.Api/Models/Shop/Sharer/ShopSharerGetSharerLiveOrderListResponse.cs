namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/sharer/get_sharer_live_order_list 接口的响应。</para>
    /// </summary>
    public class ShopSharerGetSharerLiveOrderListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order : ShopOrderGetListResponse.Types.Order
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
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
