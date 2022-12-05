using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/shop/target/add_plan 接口的请求。</para>
    /// </summary>
    public class UnionShopTargetAddPlanRequest : WechatApiRequest, IInferable<UnionShopTargetAddPlanRequest, UnionShopTargetAddPlanResponse>
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
                public string PlanName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置计划描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planDesc")]
                [System.Text.Json.Serialization.JsonPropertyName("planDesc")]
                public string Description { get; set; } = string.Empty;

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
            }

            public class Product
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("productId")]
                [System.Text.Json.Serialization.JsonPropertyName("productId")]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置佣金率（单位：万分之一）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rate")]
                [System.Text.Json.Serialization.JsonPropertyName("rate")]
                public int CommissionRatio { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置计划信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("planItem")]
        [System.Text.Json.Serialization.JsonPropertyName("planItem")]
        public Types.Plan Plan { get; set; } = new Types.Plan();

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productList")]
        [System.Text.Json.Serialization.JsonPropertyName("productList")]
        public IList<Types.Product> ProductList { get; set; } = new List<Types.Product>();
    }
}
