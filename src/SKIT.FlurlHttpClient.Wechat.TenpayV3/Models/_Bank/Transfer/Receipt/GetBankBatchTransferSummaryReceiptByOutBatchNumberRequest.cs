namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /bank-batch-transfer/receipt/summary-receipts 接口的请求。</para>
    /// </summary>
    public class GetBankBatchTransferSummaryReceiptByOutBatchNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置银行批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutBatchNumber { get; set; } = string.Empty;
    }
}
