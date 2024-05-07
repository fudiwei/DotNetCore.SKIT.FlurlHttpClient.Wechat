namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/pay/transactions/apply 接口的响应。</para>
    /// </summary>
    public class ApplyPAPayPayTransactionResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Amount : GetPAPayPaySchedulesContractByContractIdResponse.Types.Amount
            {
            }
        }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置扣费金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public Types.Amount Amount { get; set; } = default!;
    }
}
