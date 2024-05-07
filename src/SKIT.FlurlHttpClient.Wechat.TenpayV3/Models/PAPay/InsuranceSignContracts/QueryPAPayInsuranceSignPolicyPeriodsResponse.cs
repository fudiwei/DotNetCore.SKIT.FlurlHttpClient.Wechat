namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /papay/insurance-sign/policy_periods/plan-id/{plan_id}/out-contract-code/{out_contract_code} 接口的响应。</para>
    /// </summary>
    public class QueryPAPayInsuranceSignPolicyPeriodsResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class PolicyPeriod
            {
                public static class Types
                {
                    public class Amount : GetPAPayInsurancePayPolicyPeriodByPolicyPeriodIdResponse.Types.Amount
                    {
                    }
                }

                /// <summary>
                /// 获取或设置保险扣费周期编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("policy_period_id")]
                [System.Text.Json.Serialization.JsonPropertyName("policy_period_id")]
                public int PolicyPeriodId { get; set; }

                /// <summary>
                /// 获取或设置保险扣费周期编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("estimated_deduct_date")]
                [System.Text.Json.Serialization.JsonPropertyName("estimated_deduct_date")]
                public string EstimatedDeductDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置预计扣费金额信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("estimated_deduct_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("estimated_deduct_amount")]
                public Types.Amount EstimatedDeductAmount { get; set; } = default!;

                /// <summary>
                /// 获取或设置扣费周期预约状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("policy_period_state")]
                [System.Text.Json.Serialization.JsonPropertyName("policy_period_state")]
                public string PolicyPeriodState { get; set; } = default!;

                /// <summary>
                /// 获取或设置已预约的扣费金额信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scheduled_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("scheduled_amount")]
                public Types.Amount? ScheduledAmount { get; set; }

                /// <summary>
                /// 获取或设置实际扣费金额信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deduct_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("deduct_amount")]
                public Types.Amount? DeductAmount { get; set; }

                /// <summary>
                /// 获取或设置实际扣费日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deduct_date")]
                [System.Text.Json.Serialization.JsonPropertyName("deduct_date")]
                public string? DeductDateString { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.PolicyPeriod[] PolicyPeriodList { get; set; } = default!;

        /// <summary>
        /// 获取或设置记录总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }
    }
}
