namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/present_currency 接口的请求。</para>
    /// </summary>
    public class XPayPresentCurrencyRequest : XPayRequestBase, IInferable<XPayPresentCurrencyRequest, XPayPresentCurrencyResponse>
    {
        /// <summary>
        /// 获取或设置赠送代币的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置赠送代币的个数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        protected internal override string GetRequestPath()
        {
            return "/xpay/present_currency";
        }
    }
}
