namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/refunds/refund-id/{refund_id} 接口的请求。</para>
    /// </summary>
    public class GetRefundByRefundIdRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置微企付退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string RefundId { get; set; } = string.Empty;
    }
}
