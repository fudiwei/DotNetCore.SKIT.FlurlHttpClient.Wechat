namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/funds/submitwithdraw 接口的请求。</para>
    /// </summary>
    public class ProductFundsSubmitWithdrawRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置提现金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置银行附言。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_memo")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_memo")]
        public string? BankMemo { get; set; }
    }
}
