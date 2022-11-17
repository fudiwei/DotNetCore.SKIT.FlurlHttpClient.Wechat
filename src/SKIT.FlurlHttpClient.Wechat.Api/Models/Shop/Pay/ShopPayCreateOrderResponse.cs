namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/pay/createorder 接口的响应。</para>
    /// </summary>
    public class ShopPayCreateOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class PaymentParameters : ShopOrderGetPaymentParametersResponse.Types.PaymentParameters
            {
            }
        }

        /// <summary>
        /// 获取或设置支付参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_params")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_params")]
        public Types.PaymentParameters PaymentParameters { get; set; } = default!;
    }
}
