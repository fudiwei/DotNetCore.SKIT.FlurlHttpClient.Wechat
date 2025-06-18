namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/membercard-open/activate-informations/{activate_ticket} 接口的请求。</para>
    /// </summary>
    public class GetMarketingMemberCardOpenActivateInformationRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置激活 Ticket。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ActivateTicket { get; set; } = string.Empty;
    }
}
