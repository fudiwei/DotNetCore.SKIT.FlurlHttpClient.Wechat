namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /platsolution/ecommerce/mch-transfer/compensate-bills/bill-id/{bill_id} 接口的请求。</para>
    /// </summary>
    public class GetPlatformSolutionEcommerceMerchantTransferCompensationBillByBillIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信支付付款单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BillId { get; set; } = string.Empty;
    }
}
