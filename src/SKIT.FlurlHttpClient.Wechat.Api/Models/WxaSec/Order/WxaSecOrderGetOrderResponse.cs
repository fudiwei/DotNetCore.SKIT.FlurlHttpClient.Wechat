namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/order/get_order 接口的响应。</para>
    /// </summary>
    public class WxaSecOrderGetOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order : WxaSecOrderGetOrderListResponse.Types.Order
            {
            }
        }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public Types.Order Order { get; set; } = default!;
    }
}
