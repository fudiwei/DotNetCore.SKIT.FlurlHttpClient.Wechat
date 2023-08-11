namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /bank-batch-transfer/receipt/detail-receipts 接口的请求。</para>
    /// </summary>
    public class CreateBankBatchTransferDetailReceiptRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置银行批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_batch_no")]
        public string OutBatchNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置银行明细单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_detail_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_detail_no")]
        public string OutDetailNumber { get; set; } = string.Empty;
    }
}
