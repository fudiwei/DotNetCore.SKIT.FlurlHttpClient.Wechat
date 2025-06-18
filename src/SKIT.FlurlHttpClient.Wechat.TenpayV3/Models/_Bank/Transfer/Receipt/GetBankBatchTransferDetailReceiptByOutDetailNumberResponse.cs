namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /bank-batch-transfer/receipt/detail-receipts 接口的响应。</para>
    /// </summary>
    public class GetBankBatchTransferDetailReceiptByOutDetailNumberResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置银行批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_batch_no")]
        public string OutBatchNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置银行明细单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_detail_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_detail_no")]
        public string OutDetailNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置电子回单申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receipt_no")]
        [System.Text.Json.Serialization.JsonPropertyName("receipt_no")]
        public string ReceiptNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置电子回单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receipt_state")]
        [System.Text.Json.Serialization.JsonPropertyName("receipt_state")]
        public string? ReceiptStatus { get; set; }

        /// <summary>
        /// 获取或设置电子回单文件的哈希方法。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hash_type")]
        [System.Text.Json.Serialization.JsonPropertyName("hash_type")]
        public string? HashType { get; set; }

        /// <summary>
        /// 获取或设置电子回单文件的哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hash_value")]
        [System.Text.Json.Serialization.JsonPropertyName("hash_value")]
        public string? HashValue { get; set; }

        /// <summary>
        /// 获取或设置电子回单文件的下载地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_url")]
        [System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }
    }
}
