namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/plan/partner/payscore-plans/merchant-plan-no/{merchant_plan_no}/stop 接口的请求。</para>
    /// </summary>
    public class StopPayScorePartnerPlanRequest : StopPayScorePlanRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;
    }
}
