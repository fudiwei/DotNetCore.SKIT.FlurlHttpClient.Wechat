namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/currency_pay 接口的响应。</para>
    /// </summary>
    public class XPayCurrencyPayResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置扣除代币的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置预扣后的余额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public int Balance { get; set; }

        /// <summary>
        /// 获取或设置本次扣除的赠送币的数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("used_present_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("used_present_amount")]
        public int UsedPresentAmount { get; set; }
    }
}
