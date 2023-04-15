namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/profit-allocations/{payment_id}/amounts 接口的请求。</para>
    /// </summary>
    public class GetProfitAllocationAmountByPaymentIdRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置微企付支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PaymentId { get; set; } = string.Empty;
    }
}
