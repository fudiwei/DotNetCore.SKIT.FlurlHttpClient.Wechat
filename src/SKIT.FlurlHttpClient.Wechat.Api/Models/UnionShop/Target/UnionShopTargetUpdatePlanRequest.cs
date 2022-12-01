using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/shop/target/update_plan 接口的请求。</para>
    /// </summary>
    public class UnionShopTargetUpdatePlanRequest : WechatApiRequest, IInferable<UnionShopTargetUpdatePlanRequest, UnionShopTargetUpdatePlanResponse>
    {
        public static class Types
        {
            public class Plan
            {
                /// <summary>
                /// 获取或设置计划名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planName")]
                [System.Text.Json.Serialization.JsonPropertyName("planName")]
                public string? PlanName { get; set; }

                /// <summary>
                /// 获取或设置计划描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planDesc")]
                [System.Text.Json.Serialization.JsonPropertyName("planDesc")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置计划开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planStartTime")]
                [System.Text.Json.Serialization.JsonPropertyName("planStartTime")]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置计划结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planEndTime")]
                [System.Text.Json.Serialization.JsonPropertyName("planEndTime")]
                public long? EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置计划状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("planStatus")]
                public string? Status { get; set; }
            }

            public class Product : UnionShopTargetAddPlanRequest.Types.Product
            {
            }
        }

        /// <summary>
        /// 获取或设置计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("planId")]
        [System.Text.Json.Serialization.JsonPropertyName("planId")]
        public string PlanId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置计划信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("planItem")]
        [System.Text.Json.Serialization.JsonPropertyName("planItem")]
        public Types.Plan? Plan { get; set; }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productList")]
        [System.Text.Json.Serialization.JsonPropertyName("productList")]
        public IList<Types.Product>? ProductList { get; set; }
    }
}
