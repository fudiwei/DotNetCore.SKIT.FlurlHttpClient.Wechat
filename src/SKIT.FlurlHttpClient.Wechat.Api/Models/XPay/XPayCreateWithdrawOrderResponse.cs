namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/create_withdraw_order 接口的响应。</para>
    /// </summary>
    public class XPayCreateWithdrawOrderResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw_no")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw_no")]
        public string WithdrawNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信内部提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_withdraw_no")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_withdraw_no")]
        public string WxWithdrawNumber { get; set; } = default!;
    }
}
