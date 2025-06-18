namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/fund/balance/{sub_mchid} 接口的响应。</para>
    /// </summary>
    public class GetEcommerceFundBalanceResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置账户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_type")]
        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
        public string? AccountType { get; set; }

        /// <summary>
        /// 获取或设置可用余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("available_amount")]
        public long AvailableAmount { get; set; }

        /// <summary>
        /// 获取或设置不可用余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pending_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("pending_amount")]
        public long PendingAmount { get; set; }
    }
}
