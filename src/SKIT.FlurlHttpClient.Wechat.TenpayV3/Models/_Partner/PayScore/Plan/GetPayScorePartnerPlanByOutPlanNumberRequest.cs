namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /payscore/plan/partner/payscore-plans/merchant-plan-no/{merchant_plan_no} 接口的请求。</para>
    /// </summary>
    public class GetPayScorePartnerPlanByOutPlanNumberRequest : GetPayScorePlanByOutPlanNumberRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;
    }
}
