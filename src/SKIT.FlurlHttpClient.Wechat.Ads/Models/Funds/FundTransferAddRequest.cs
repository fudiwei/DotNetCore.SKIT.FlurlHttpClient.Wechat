namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /fund_transfer/add 接口的请求。</para>
    /// </summary>
    public class FundTransferAddRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置资金账户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fund_type")]
        [System.Text.Json.Serialization.JsonPropertyName("fund_type")]
        public string FundType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置调用方订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("external_bill_no")]
        public string? ExternalBillNumber { get; set; }

        /// <summary>
        /// 获取或设置备注信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        [System.Text.Json.Serialization.JsonPropertyName("memo")]
        public string? Memo { get; set; }
    }
}
