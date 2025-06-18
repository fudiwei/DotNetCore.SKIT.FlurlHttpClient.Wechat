using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/plan/payscore-plans 接口的请求。</para>
    /// </summary>
    public class CreatePayScorePlanRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class PlanDetail
            {
                /// <summary>
                /// 获取或设置明细名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plan_detail_name")]
                [System.Text.Json.Serialization.JsonPropertyName("plan_detail_name")]
                public string DetailName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置优惠说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plan_discount_description")]
                [System.Text.Json.Serialization.JsonPropertyName("plan_discount_description")]
                public string? DiscountDescription { get; set; }

                /// <summary>
                /// 获取或设置原支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("original_price")]
                [System.Text.Json.Serialization.JsonPropertyName("original_price")]
                public int OriginalPrice { get; set; }

                /// <summary>
                /// 获取或设置实际支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actual_price")]
                [System.Text.Json.Serialization.JsonPropertyName("actual_price")]
                public int ActualPrice { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户计划号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_plan_no")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_plan_no")]
        public string OutPlanNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置计划名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_name")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_name")]
        public string PlanName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置计划有效期（单位：天）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_duration")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_duration")]
        public int PlanDuration { get; set; }

        /// <summary>
        /// 获取或设置扣费次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deduction_quantity")]
        [System.Text.Json.Serialization.JsonPropertyName("deduction_quantity")]
        public int DeductionQuantity { get; set; }

        /// <summary>
        /// 获取或设置原总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_original_price")]
        [System.Text.Json.Serialization.JsonPropertyName("total_original_price")]
        public int TotalOriginalPrice { get; set; }

        /// <summary>
        /// 获取或设置实际总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_actual_price")]
        [System.Text.Json.Serialization.JsonPropertyName("total_actual_price")]
        public int TotalActualPrice { get; set; }

        /// <summary>
        /// 获取或设置计划明细列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_detail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_detail_list")]
        public IList<Types.PlanDetail>? PlanDetailList { get; set; }
    }
}
