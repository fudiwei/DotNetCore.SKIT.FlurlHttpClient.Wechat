namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/fund/withdraw 接口的响应。</para>
    /// </summary>
    public class CreateEcommerceFundWithdrawResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw_id")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw_id")]
        public string WithdrawId { get; set; } = default!;
    }
}
