namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partner/delivery-plan/delivery-plans/{plan_id}/terminate 接口的请求。</para>
    /// </summary>
    public class TerminateMarketingPartnerDeliveryPlanRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置投放计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PlanId { get; set; } = string.Empty;
    }
}
