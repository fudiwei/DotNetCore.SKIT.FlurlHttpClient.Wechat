using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /webizpay/employees/{employee_id}/out-quota-cards/{out_card_no} 接口的响应。</para>
    /// </summary>
    public class GetWeBusinessPayEmployeeQuotaCardByOutCardNumberResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信授权关系 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("employee_id")]
        [System.Text.Json.Serialization.JsonPropertyName("employee_id")]
        public string EmployeeId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户卡号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_card_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_card_no")]
        public string OutCardNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置企业支付额度卡卡号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_no")]
        [System.Text.Json.Serialization.JsonPropertyName("card_no")]
        public string CardNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置企业支付卡模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_template_id")]
        public string CardTemplateId { get; set; } = default!;

        /// <summary>
        /// 获取或设置使用规则。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("card_rule")]
        public string CardRule { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款规则。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_rule")]
        public string RefundRule { get; set; } = default!;

        /// <summary>
        /// 获取或设置总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置可用金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remain_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("remain_amount")]
        public int RemainAmount { get; set; }

        /// <summary>
        /// 获取或设置有效期开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effective_begin_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("effective_begin_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset EffectiveBeginTime { get; set; }

        /// <summary>
        /// 获取或设置有效期结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effective_end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("effective_end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset EffectiveEndTime { get; set; }

        /// <summary>
        /// 获取或设置卡片状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_state")]
        [System.Text.Json.Serialization.JsonPropertyName("card_state")]
        public string CardState { get; set; } = default!;

        /// <summary>
        /// 获取或设置卡片名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_name")]
        [System.Text.Json.Serialization.JsonPropertyName("card_name")]
        public string CardName { get; set; } = default!;

        /// <summary>
        /// 获取或设置卡片备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("card_remark")]
        public string? CardRemark { get; set; }

        /// <summary>
        /// 获取或设置卡片失效时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_disabled_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("card_disabled_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? DisableTime { get; set; }

        /// <summary>
        /// 获取或设置失效原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? DisableReason { get; set; }

        /// <summary>
        /// 获取或设置最近一次使用时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_usage_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("card_usage_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? LastUsageTime { get; set; }

        /// <summary>
        /// 获取或设置最近一次关联微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? LastTransactionId { get; set; }
    }
}
