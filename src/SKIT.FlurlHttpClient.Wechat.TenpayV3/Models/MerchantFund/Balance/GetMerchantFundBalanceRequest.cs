namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant/fund/balance/{account_type} 接口的请求。</para>
    /// </summary>
    public class GetMerchantFundBalanceRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置账户类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AccountType { get; set; } = string.Empty;
    }
}
