namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/withdraws/{withdraw_id} 接口的请求。</para>
    /// </summary>
    public class GetWithdrawByWithdrawIdRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置微企付提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string WithdrawId { get; set; } = string.Empty;
    }
}
