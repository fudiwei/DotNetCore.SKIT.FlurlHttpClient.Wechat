using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /funds-to-oversea/orders/{out_order_id} 接口的响应。</para>
    /// </summary>
    public class GetFundsToOverseaOrderByOutOrderIdResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户出境单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_id")]
        public string OutOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信出境单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置出境结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string Result { get; set; } = default!;

        /// <summary>
        /// 获取或设置出境失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        public string? FailReason { get; set; }

        /// <summary>
        /// 获取或设置出境金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置境外收款金额（单位：该币种最小计价单位）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("foreign_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("foreign_amount")]
        public int? ForeignAmount { get; set; }

        /// <summary>
        /// 获取或设置境外收款币种。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("foreign_currency")]
        [System.Text.Json.Serialization.JsonPropertyName("foreign_currency")]
        public string ForeignCurrency { get; set; } = default!;

        /// <summary>
        /// 获取或设置汇率（格式：外币兑换人民币的比例乘以 10 的 8 次方）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rate")]
        [System.Text.Json.Serialization.JsonPropertyName("rate")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long? ExchangeRate { get; set; }

        /// <summary>
        /// 获取或设置购汇时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exchange_rate_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("exchange_rate_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? ExchangeRateTime { get; set; }

        /// <summary>
        /// 获取或设置预计购汇时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estimate_exchange_rate_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("estimate_exchange_rate_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? EstimateExchangeRateTime { get; set; }

        /// <summary>
        /// 获取或设置真实出境人民币金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("departure_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("departure_amount")]
        public int? DepartureAmount { get; set; }

        /// <summary>
        /// 获取或设置手续费金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee")]
        [System.Text.Json.Serialization.JsonPropertyName("fee")]
        public int? Fee { get; set; }

        /// <summary>
        /// 获取或设置手续费承担商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charge_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("charge_mchid")]
        public string? ChargeMerchantId { get; set; }

        /// <summary>
        /// 获取或设置手续费承担账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charge_account_type")]
        [System.Text.Json.Serialization.JsonPropertyName("charge_account_type")]
        public string? ChargeAccountType { get; set; }
    }
}
