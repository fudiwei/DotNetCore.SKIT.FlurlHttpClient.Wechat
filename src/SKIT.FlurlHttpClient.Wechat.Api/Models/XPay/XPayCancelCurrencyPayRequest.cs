namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/cancel_currency_pay 接口的请求。</para>
    /// </summary>
    public class XPayCancelCurrencyPayRequest : XPayRequestBase, IInferable<XPayCancelCurrencyPayRequest, XPayCancelCurrencyPayResponse>
    {
        /// <summary>
        /// 获取或设置扣除代币的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_order_id")]
        public string PayOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置退回代币的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置本次退回的代币的数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        protected internal override string GetRequestPath()
        {
            return "/xpay/cancel_currency_pay";
        }
    }
}
