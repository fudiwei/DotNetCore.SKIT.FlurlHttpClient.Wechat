namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/fund/withdraw 接口的响应。</para>
    /// </summary>
    public class CreateMerchantFundWithdrawResponse : WechatTenpayResponse
    {
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
