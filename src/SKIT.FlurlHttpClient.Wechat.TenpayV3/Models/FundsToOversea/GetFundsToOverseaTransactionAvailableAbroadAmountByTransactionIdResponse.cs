namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /funds-to-oversea/transactions/{transaction_id}/available_abroad_amounts 接口的响应。</para>
    /// </summary>
    public class GetFundsToOverseaTransactionAvailableAbroadAmountByTransactionIdResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单剩余可出境金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_abroad_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("available_abroad_amount")]
        public int AvailableAbroadAmount { get; set; }
    }
}
