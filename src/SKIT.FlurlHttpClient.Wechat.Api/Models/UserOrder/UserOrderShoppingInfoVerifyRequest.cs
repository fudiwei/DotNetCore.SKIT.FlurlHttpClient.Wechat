namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /user-order/shoppinginfo/verify 接口的请求。</para>
    /// </summary>
    public class UserOrderShoppingInfoVerifyRequest : WechatApiRequest, IInferable<UserOrderShoppingInfoVerifyRequest, UserOrderShoppingInfoVerifyResponse>
    {
        public static class Types
        {
            public class OrderKey : UserOrderOrdersRequest.Types.OrderKey
            {
            }

            public class Payer : UserOrderOrdersRequest.Types.Payer
            {
            }
        }

        /// <summary>
        /// 获取或设置订单标识信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_key")]
        [System.Text.Json.Serialization.JsonPropertyName("order_key")]
        public Types.OrderKey OrderKey { get; set; } = new Types.OrderKey();

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public Types.Payer Payer { get; set; } = new Types.Payer();
    }
}
