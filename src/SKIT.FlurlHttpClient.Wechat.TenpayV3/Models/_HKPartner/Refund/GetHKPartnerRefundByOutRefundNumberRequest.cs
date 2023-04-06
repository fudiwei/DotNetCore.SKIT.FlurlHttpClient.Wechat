namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /refunds/out-refund-no/{out_refund_no} 接口的请求。</para>
    /// </summary>
    public class GetHKPartnerRefundByOutRefundNumberRequest : GetHKRefundByOutRefundNumberRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;
    }
}
