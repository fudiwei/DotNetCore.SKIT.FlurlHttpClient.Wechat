namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/withdraws/out-withdraw-id/{out_withdraw_id} 接口的请求。</para>
    /// </summary>
    public class GetWithdrawByOutWithdrawIdRequest : WechatTenpayBusinessRequest
    {
        /// <summary>
        /// 获取或设置平台提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutWithdrawId { get; set; } = string.Empty;
    }
}
