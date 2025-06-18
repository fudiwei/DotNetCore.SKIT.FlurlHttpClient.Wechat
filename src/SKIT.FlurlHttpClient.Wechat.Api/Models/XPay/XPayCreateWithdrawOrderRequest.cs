namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/create_withdraw_order 接口的请求。</para>
    /// </summary>
    public class XPayCreateWithdrawOrderRequest : XPayRequestBase, IInferable<XPayCreateWithdrawOrderRequest, XPayCreateWithdrawOrderResponse>
    {
        /// <summary>
        /// 获取或设置提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw_no")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw_no")]
        public string WithdrawNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置提现金额（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw_amount")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw_amount")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public decimal? Amount { get; set; }

        protected internal override string GetRequestPath()
        {
            return "/xpay/create_withdraw_order";
        }
    }
}
