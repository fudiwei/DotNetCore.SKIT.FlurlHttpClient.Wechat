namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /transfer-detail/electronic-receipts 接口的请求。</para>
    /// </summary>
    public class GetTransferDetailElectronicReceiptByOutDetailNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置受理类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AcceptType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? OutBatchNumber { get; set; }

        /// <summary>
        /// 获取或设置商户明细单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutDetailNumber { get; set; } = string.Empty;
    }
}
