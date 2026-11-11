namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /payscore/plan/partner/payscore-plans/merchant-plan-no/{merchant_plan_no} 接口的响应。</para>
    /// </summary>
    public class GetPayScorePartnerPlanByOutPlanNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class PlanDetail : CreatePayScorePlanRequest.Types.PlanDetail
            {
                /// <summary>
                /// 获取或设置明细序号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plan_detail_no")]
                [System.Text.Json.Serialization.JsonPropertyName("plan_detail_no")]
                public int DetailNumber { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置子商户微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置商户计划号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_plan_no")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_plan_no")]
        public string? OutPlanNumber { get; set; }

        /// <summary>
        /// 获取或设置支付分计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public string? PlanId { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string? ServiceId { get; set; }

        /// <summary>
        /// 获取或设置计划名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_name")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_name")]
        public string? PlanName { get; set; }

        /// <summary>
        /// 获取或设置计划有效期（单位：天）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_duration")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_duration")]
        public int PlanDuration { get; set; }

        /// <summary>
        /// 获取或设置计划状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_state")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_state")]
        public string? PlanState { get; set; }

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
        public List<Types.PlanDetail>? PlanDetailList { get; set; }

        /// <summary>
        /// 获取或设置终止方商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stop_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("stop_mchid")]
        public string? StopMerchantId { get; set; }

        /// <summary>
        /// 获取或设置终止时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stop_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("stop_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? StopTime { get; set; }
    }
}
