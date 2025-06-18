namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /papay/pay/schedules/contract-id/{contract_id} 接口的响应。</para>
    /// </summary>
    public class GetPAPayPaySchedulesContractByContractIdResponse : WechatTenpayResponse
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
        /// 获取或设置扣费预约状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule_state")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule_state")]
        public string ScheduleState { get; set; } = default!;

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
