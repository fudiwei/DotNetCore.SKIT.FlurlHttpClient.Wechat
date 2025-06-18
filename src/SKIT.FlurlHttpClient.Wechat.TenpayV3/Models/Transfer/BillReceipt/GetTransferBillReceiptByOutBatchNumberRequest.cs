namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /transfer/bill-receipt/{out_batch_no} 接口的请求。</para>
    /// </summary>
    public class GetTransferBillReceiptByOutBatchNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutBatchNumber { get; set; } = string.Empty;
    }
}
