namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /transfer-detail/electronic-receipts 接口的请求。</para>
    /// </summary>
    public class CreateTransferDetailElectronicReceiptRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置受理类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accept_type")]
        [System.Text.Json.Serialization.JsonPropertyName("accept_type")]
        public string AcceptType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_batch_no")]
        public string? OutBatchNumber { get; set; }

        /// <summary>
        /// 获取或设置商户明细单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_detail_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_detail_no")]
        public string OutDetailNumber { get; set; } = string.Empty;
    }
}
