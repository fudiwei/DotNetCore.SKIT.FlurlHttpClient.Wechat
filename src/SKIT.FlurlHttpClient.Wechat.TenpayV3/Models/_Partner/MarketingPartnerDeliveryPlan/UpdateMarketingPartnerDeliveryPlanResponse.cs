namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /marketing/partner/delivery-plan/delivery-plans/{plan_id} 接口的响应。</para>
    /// </summary>
    public class UpdateMarketingPartnerDeliveryPlanResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Plan : CreateMarketingPartnerDeliveryPlanResponse.Types.Plan
            {
            }
        }

        /// <summary>
        /// 获取或设置投放计划信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan")]
        [System.Text.Json.Serialization.JsonPropertyName("plan")]
        public Types.Plan Plan { get; set; } = default!;
    }
}
