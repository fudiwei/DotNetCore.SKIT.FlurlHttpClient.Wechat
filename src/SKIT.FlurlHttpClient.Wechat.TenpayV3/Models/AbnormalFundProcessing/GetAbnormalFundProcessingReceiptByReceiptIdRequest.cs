namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /abnormal-fund-processing/receipts/{receipt_id} 接口的请求。</para>
    /// </summary>
    public class GetAbnormalFundProcessingReceiptByReceiptIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信支付在途异常资金付款单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ReceiptId { get; set; } = string.Empty;
    }
}
