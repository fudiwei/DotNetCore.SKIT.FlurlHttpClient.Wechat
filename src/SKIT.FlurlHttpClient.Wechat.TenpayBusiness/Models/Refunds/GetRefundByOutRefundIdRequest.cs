namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/refunds/out-refund-id/{out_refund_id} 接口的请求。</para>
    /// </summary>
    public class GetRefundByOutRefundIdRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置平台退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutRefundId { get; set; } = string.Empty;
    }
}
