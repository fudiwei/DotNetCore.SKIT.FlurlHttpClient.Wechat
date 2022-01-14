namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/order/getbyfilter 接口的响应。</para>
    /// </summary>
    public class MerchantOrderGetByFilterResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order : MerchantOrderGetByIdResponse.Types.Order
            {
            }
        }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public Types.Order[] OrderList { get; set; } = default!;
    }
}
