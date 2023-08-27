namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_withdraw_order 接口的请求。</para>
    /// </summary>
    public class XPayQueryWithdrawOrderRequest : XPayRequestBase, IInferable<XPayQueryWithdrawOrderRequest, XPayQueryWithdrawOrderResponse>
    {
        /// <summary>
        /// 获取或设置提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw_no")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw_no")]
        public string WithdrawNumber { get; set; } = string.Empty;

        protected internal override string GetRequestPath()
        {
            return "/xpay/query_withdraw_order";
        }
    }
}
