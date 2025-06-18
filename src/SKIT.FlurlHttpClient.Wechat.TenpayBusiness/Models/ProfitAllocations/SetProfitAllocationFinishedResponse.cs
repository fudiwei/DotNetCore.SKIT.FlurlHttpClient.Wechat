namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/profit-allocations/finish 接口的响应。</para>
    /// </summary>
    public class SetProfitAllocationFinishedResponse : WechatTenpayBusinessResponse
    {
        /// <summary>
        /// 获取或设置微企付支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_id")]
        public string PaymentId { get; set; } = default!;

        /// <summary>
        /// 获取或设置平台分账单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_allocation_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_allocation_id")]
        public string OutAllocationId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微企付分账单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allocation_id")]
        [System.Text.Json.Serialization.JsonPropertyName("allocation_id")]
        public string AllocationId { get; set; } = default!;
    }
}
