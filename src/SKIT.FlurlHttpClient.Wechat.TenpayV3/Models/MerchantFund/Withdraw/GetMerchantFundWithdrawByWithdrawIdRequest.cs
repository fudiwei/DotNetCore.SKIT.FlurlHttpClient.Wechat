namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant/fund/withdraw/{withdraw_id} 接口的请求。</para>
    /// </summary>
    public class GetMerchantFundWithdrawByWithdrawIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信支付提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string WithdrawId { get; set; } = string.Empty;
    }
}
