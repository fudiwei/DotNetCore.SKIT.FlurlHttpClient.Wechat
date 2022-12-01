namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/shop/target/add_plan 接口的响应。</para>
    /// </summary>
    public class UnionShopTargetAddPlanResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("planId")]
        [System.Text.Json.Serialization.JsonPropertyName("planId")]
        public string PlanId { get; set; } = default!;

        /// <summary>
        /// 获取或设置计划类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("planType")]
        [System.Text.Json.Serialization.JsonPropertyName("planType")]
        public string PlanType { get; set; } = default!;

        /// <summary>
        /// 获取或设置邀请链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inviteUrl")]
        [System.Text.Json.Serialization.JsonPropertyName("inviteUrl")]
        public string InviteUrl { get; set; } = default!;
    }
}
