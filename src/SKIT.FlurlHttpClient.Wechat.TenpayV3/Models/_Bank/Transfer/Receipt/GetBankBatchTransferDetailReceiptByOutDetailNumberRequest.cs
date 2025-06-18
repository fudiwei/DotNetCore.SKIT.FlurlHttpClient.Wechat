namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /bank-batch-transfer/receipt/detail-receipts 接口的请求。</para>
    /// </summary>
    public class GetBankBatchTransferDetailReceiptByOutDetailNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置银行批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutBatchNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置银行明细单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutDetailNumber { get; set; } = string.Empty;
    }
}
