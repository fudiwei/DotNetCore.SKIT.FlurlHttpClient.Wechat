namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/shop/target/plan_list 接口的响应。</para>
    /// </summary>
    public class UnionShopTargetPlanListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Plan
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
                /// 获取或设置计划名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planName")]
                [System.Text.Json.Serialization.JsonPropertyName("planName")]
                public string PlanName { get; set; } = default!;

                /// <summary>
                /// 获取或设置计划描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planDesc")]
                [System.Text.Json.Serialization.JsonPropertyName("planDesc")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置计划状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("planStatus")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置计划开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planStartTime")]
                [System.Text.Json.Serialization.JsonPropertyName("planStartTime")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置计划结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planEndTime")]
                [System.Text.Json.Serialization.JsonPropertyName("planEndTime")]
                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置过审推客数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("acceptPromoterCnt")]
                [System.Text.Json.Serialization.JsonPropertyName("acceptPromoterCnt")]
                public int AcceptedPromoterCount { get; set; }

                /// <summary>
                /// 获取或设置待审批推客数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auditingPromoterCnt")]
                [System.Text.Json.Serialization.JsonPropertyName("auditingPromoterCnt")]
                public int AuditingPromoterCnt { get; set; }

                /// <summary>
                /// 获取或设置邀请链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inviteUrl")]
                [System.Text.Json.Serialization.JsonPropertyName("inviteUrl")]
                public string InviteUrl { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置计划列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("planList")]
        [System.Text.Json.Serialization.JsonPropertyName("planList")]
        public Types.Plan[]? PlanList { get; set; }

        /// <summary>
        /// 获取或设置计划信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan")]
        [System.Text.Json.Serialization.JsonPropertyName("plan")]
        public Types.Plan? Plan { get; set; }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? TotalCount { get; set; }
    }
}
