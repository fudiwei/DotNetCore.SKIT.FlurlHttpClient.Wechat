using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/subsidies/return 接口的响应。</para>
    /// </summary>
    public class CreateEcommerceSubsidyReturnResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户补差回退单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string OutReturnNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信补差回退单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subsidy_refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("subsidy_refund_id")]
        public string SubsidyReturnId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
        public string? RefundId { get; set; }

        /// <summary>
        /// 获取或设置补差回退描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 获取或设置补差回退金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置补差回退结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string Result { get; set; } = default!;

        /// <summary>
        /// 获取或设置补差回退完成时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("success_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? SuccessTime { get; set; }
    }
}
