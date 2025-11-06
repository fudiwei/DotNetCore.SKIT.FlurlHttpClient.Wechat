using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /marketing/partner/delivery-plan/delivery-plans/{plan_id} 接口的请求。</para>
    /// </summary>
    public class UpdateMarketingPartnerDeliveryPlanRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class ModifyContent
            {

                /// <summary>
                /// 获取或设置投放计划名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plan_name")]
                [System.Text.Json.Serialization.JsonPropertyName("plan_name")]
                public string? PlanName { get; set; }

                /// <summary>
                /// 获取或设置总库存数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int? TotalCount { get; set; }

                /// <summary>
                /// 获取或设置单用户限领数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("user_limit")]
                public int? UserLimitCount { get; set; }

                /// <summary>
                /// 获取或设置单日限领数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("daily_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("daily_limit")]
                public int? DailyLimitCount { get; set; }

                /// <summary>
                /// 获取或设置结束时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_end_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_end_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset? EndTime { get; set; }

                /// <summary>
                /// 获取或设置营销自定义文案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recommend_word")]
                [System.Text.Json.Serialization.JsonPropertyName("recommend_word")]
                public string? RecommentWording { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置投放计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PlanId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string? OutRequestNumber { get; set; }

        /// <summary>
        /// 获取或设置修改内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modify_content")]
        [System.Text.Json.Serialization.JsonPropertyName("modify_content")]
        public Types.ModifyContent ModifyContent { get; set; } = new Types.ModifyContent();
    }
}
