namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/currency_pay 接口的请求。</para>
    /// </summary>
    public class XPayCurrencyPayRequest : XPayRequestBase, IInferable<XPayCurrencyPayRequest, XPayCurrencyPayResponse>
    {
        /// <summary>
        /// 获取或设置扣除代币的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置扣除代币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置物品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payitem")]
        [System.Text.Json.Serialization.JsonPropertyName("payitem")]
        public string? PayItem { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        protected internal override string GetRequestPath()
        {
            return "/xpay/currency_pay";
        }
    }
}
