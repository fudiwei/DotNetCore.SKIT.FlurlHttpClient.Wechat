namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /papay/insurance-pay/policy-periods/contract-id/{contract_id}/policy-period-id/{policy_period_id} 接口的响应。</para>
    /// </summary>
    public class GetPAPayInsurancePayPolicyPeriodByPolicyPeriodIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Amount
            {
                /// <summary>
                /// 获取或设置金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int Total { get; set; }

                /// <summary>
                /// 获取或设置货币类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string? Currency { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置保单的扣费周期编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_period_id")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_period_id")]
        public int PolicyPeriodId { get; set; } = default!;

        /// <summary>
        /// 获取或设置当前扣费周期的状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_period_state")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_period_state")]
        public string PolicyPeriodState { get; set; } = default!;

        /// <summary>
        /// 获取或设置可扣费开始日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deduct_start_date")]
        [System.Text.Json.Serialization.JsonPropertyName("deduct_start_date")]
        public string? DeductStartDateString { get; set; }

        /// <summary>
        /// 获取或设置可扣费结束日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deduct_end_date")]
        [System.Text.Json.Serialization.JsonPropertyName("deduct_end_date")]
        public string? DeductEndDateString { get; set; }

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
