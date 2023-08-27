namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/cancel_currency_pay 接口的响应。</para>
    /// </summary>
    public class XPayCancelCurrencyPayResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置退回代币的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = default!;
    }
}
