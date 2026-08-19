namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/promotion/plan/list 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeaguePromotionPlanListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class PromotionPlan
            {
                /// <summary>
                /// 获取或设置推广计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_plan_id")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_plan_id")]
                public long PromotionPlanId { get; set; }

                /// <summary>
                /// 获取或设置推广计划类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_plan_type")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_plan_type")]
                public int PromotionPlanType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置推广计划列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.PromotionPlan[] PromotionPlanList { get; set; } = default!;

        /// <summary>
        /// 获取或设置推广计划总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("continue_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("continue_flag")]
        public bool HasMore { get; set; }
    }
}
