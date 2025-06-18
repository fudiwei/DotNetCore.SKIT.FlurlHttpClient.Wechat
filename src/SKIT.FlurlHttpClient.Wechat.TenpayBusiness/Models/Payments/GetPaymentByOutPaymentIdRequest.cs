namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/payments/out-payment-id/{out_payment_id} 接口的请求。</para>
    /// </summary>
    public class GetPaymentByOutPaymentIdRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置平台支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutPaymentId { get; set; } = string.Empty;
    }
}
