namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/payments/{payment_id} 接口的请求。</para>
    /// </summary>
    public class GetPaymentByPaymentIdRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置微企付支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PaymentId { get; set; } = string.Empty;
    }
}
