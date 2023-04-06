namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/transactions/out-trade-no/{out_trade_no}/reverse 接口的请求。</para>
    /// </summary>
    public class ReverseHKPartnerPAPPayTransactionRequest : ReverseHKPAPPayTransactionRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;
    }
}
