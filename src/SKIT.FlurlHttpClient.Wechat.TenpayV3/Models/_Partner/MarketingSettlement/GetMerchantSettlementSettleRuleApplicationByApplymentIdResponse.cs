using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant-settlement/merchant-settle-rule-applications/{application_id} 接口的响应。</para>
    /// </summary>
    public class GetMerchantSettlementSettleRuleApplicationByApplymentIdResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置申请单编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_id")]
        [System.Text.Json.Serialization.JsonPropertyName("application_id")]
        public string ApplymentId { get; set; } = default!;

        /// <summary>
        /// 获取或设置申请单处理信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_process_info")]
        [System.Text.Json.Serialization.JsonPropertyName("application_process_info")]
        public string ApplymentProcessInformation { get; set; } = default!;

        /// <summary>
        /// 获取或设置申请单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_state")]
        [System.Text.Json.Serialization.JsonPropertyName("application_state")]
        public string? ApplymentState { get; set; }

        /// <summary>
        /// 获取或设置从业机构号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acquiring_bank_id")]
        [System.Text.Json.Serialization.JsonPropertyName("acquiring_bank_id")]
        public string? AcquiringBankId { get; set; }

        /// <summary>
        /// 获取或设置渠道商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// 获取或设置特约商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置结算规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_rule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_rule_id")]
        public int? SettleRuleId { get; set; }

        /// <summary>
        /// 获取或设置最后更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? UpdateTime { get; set; }
    }
}
