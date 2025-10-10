namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /transaction-block/transaction-block-submissions/sub-mchid/{sub_mchid} 接口的请求。</para>
    /// </summary>
    public class CreateTransactionBlockSubmissionRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户申诉单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_submit_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_submit_id")]
        public string MerchantSubmitId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置提交数据（JSON 格式）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("submit_data")]
        [System.Text.Json.Serialization.JsonPropertyName("submit_data")]
        public string SubmitData { get; set; } = "{}";
    }
}
