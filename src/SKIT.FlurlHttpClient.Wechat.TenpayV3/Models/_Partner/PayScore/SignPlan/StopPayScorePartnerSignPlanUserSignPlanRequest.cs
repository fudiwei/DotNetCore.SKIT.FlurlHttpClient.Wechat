namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/sign-plan/partner/user-sign-plans/merchant-sign-plan-no/{merchant_sign_plan_no}/stop 接口的请求。</para>
    /// </summary>
    public class StopPayScorePartnerSignPlanUserSignPlanRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置商户签约计划单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? OutSignPlanNumber { get; set; }

        /// <summary>
        /// 获取或设置停止原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stop_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        public string? StopReason { get; set; }
    }
}
