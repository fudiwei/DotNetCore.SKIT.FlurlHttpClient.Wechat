namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/order/get_list 接口的响应。</para>
    /// </summary>
    public class ProductOrderGetListResponse : WechatApiResponse
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
    }
}
