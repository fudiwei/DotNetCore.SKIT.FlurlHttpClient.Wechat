namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /payscore/plan/payscore-plans/merchant-plan-no/{merchant_plan_no} 接口的请求。</para>
    /// </summary>
    public class GetPayScorePlanByOutPlanNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户计划号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutPlanNumber { get; set; } = string.Empty;
    }
}
