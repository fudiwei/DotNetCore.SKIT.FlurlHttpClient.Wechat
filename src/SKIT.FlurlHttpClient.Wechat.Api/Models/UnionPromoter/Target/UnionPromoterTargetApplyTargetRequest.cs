namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/promoter/target/apply_target 接口的请求。</para>
    /// </summary>
    public class UnionPromoterTargetApplyTargetRequest : WechatApiRequest, IInferable<UnionPromoterTargetApplyTargetRequest, UnionPromoterTargetApplyTargetResponse>
    {
        /// <summary>
        /// 获取或设置定向计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("planId")]
        [System.Text.Json.Serialization.JsonPropertyName("planId")]
        public string PlanId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置申请原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyReason")]
        [System.Text.Json.Serialization.JsonPropertyName("applyReason")]
        public string ApplyReason { get; set; } = string.Empty;
    }
}
