namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/insurance_freight/update_notify_funds 接口的请求。</para>
    /// </summary>
    public class WxaBusinessInsuranceFreightUpdateNotifyFundsRequest : WechatApiRequest, IInferable<WxaBusinessInsuranceFreightUpdateNotifyFundsRequest, WxaBusinessInsuranceFreightUpdateNotifyFundsResponse>
    {
        /// <summary>
        /// 获取或设置通知的金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_funds")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_funds")]
        public int NotifyFunds { get; set; }
    }
}
