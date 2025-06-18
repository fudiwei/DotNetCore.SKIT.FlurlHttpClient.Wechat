namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/present_currency 接口的响应。</para>
    /// </summary>
    public class XPayPresentCurrencyResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置赠送代币的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置赠送后的余额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public int Balance { get; set; }

        /// <summary>
        /// 获取或设置赠送后的代币余额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present_balance")]
        [System.Text.Json.Serialization.JsonPropertyName("present_balance")]
        public int PresentBalance { get; set; }
    }
}
