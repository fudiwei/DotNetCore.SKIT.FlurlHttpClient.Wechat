namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant/fund/dayendbalance/{account_type} 接口的请求。</para>
    /// </summary>
    public class GetMerchantFundDayendBalanceRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置账户类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AccountType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string DateString { get; set; } = string.Empty;
    }
}
