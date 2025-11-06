namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partner/delivery-plan/delivery-plans 接口的响应。</para>
    /// </summary>
    public class CreateMarketingPartnerDeliveryPlanResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Plan : QueryMarketingPartnerDeliveryPlansResponse.Types.Plan
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
