namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /payscore/sign-plan/user-sign-plans/merchant-sign-plan-no/{merchant_sign_plan_no} 接口的请求。</para>
    /// </summary>
    public class GetPayScoreSignPlanUserSignPlanByOutSignPlanNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户签约计划单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutSignPlanNumber { get; set; } = string.Empty;
    }
}
