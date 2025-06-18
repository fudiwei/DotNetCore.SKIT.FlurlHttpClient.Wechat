namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/plan/payscore-plans/merchant-plan-no/{merchant_plan_no}/stop 接口的请求。</para>
    /// </summary>
    public class StopPayScorePlanRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户计划号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutPlanNumber { get; set; } = string.Empty;
    }
}
