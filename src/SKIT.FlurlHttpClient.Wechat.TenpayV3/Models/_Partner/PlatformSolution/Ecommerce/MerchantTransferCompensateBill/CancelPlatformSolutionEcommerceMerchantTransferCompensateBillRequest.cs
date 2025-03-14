namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /platsolution/ecommerce/mch-transfer/compensate-bills/out-bill-no/{out_bill_no}/cancel 接口的请求。</para>
    /// </summary>
    public class CancelPlatformSolutionEcommerceMerchantTransferCompensateBillRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutBillNumber { get; set; } = string.Empty;
    }
}
