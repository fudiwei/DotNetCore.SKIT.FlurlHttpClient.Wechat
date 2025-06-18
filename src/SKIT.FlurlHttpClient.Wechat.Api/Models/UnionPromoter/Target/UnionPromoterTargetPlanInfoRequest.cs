namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/promoter/target/plan_info 接口的请求。</para>
    /// </summary>
    public class UnionPromoterTargetPlanInfoRequest : WechatApiRequest, IInferable<UnionPromoterTargetPlanInfoRequest, UnionPromoterTargetPlanInfoResponse>
    {
        /// <summary>
        /// 获取或设置定向计划邀请链接。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PlanInvitaionUrl { get; set; } = string.Empty;
    }
}
