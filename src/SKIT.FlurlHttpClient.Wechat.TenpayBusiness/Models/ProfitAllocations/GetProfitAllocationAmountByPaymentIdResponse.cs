namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/profit-allocations/{payment_id}/amounts 接口的响应。</para>
    /// </summary>
    public class GetProfitAllocationAmountByPaymentIdResponse : WechatTenpayBusinessResponse
    {
        /// <summary>
        /// 获取或设置微企付支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_id")]
        public string PaymentId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单剩余待分金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unsplit_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("unsplit_amount")]
        public int UnsplitAmount { get; set; }
    }
}
