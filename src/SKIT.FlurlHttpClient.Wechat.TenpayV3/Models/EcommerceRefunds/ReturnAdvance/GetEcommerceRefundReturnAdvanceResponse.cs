using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/refunds/{refund_id}/return-advance 接口的响应。</para>
    /// </summary>
    public class GetEcommerceRefundReturnAdvanceResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
        public string RefundId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信回补单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advance_return_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advance_return_id")]
        public string AdvanceReturnId { get; set; } = default!;

        /// <summary>
        /// 获取或设置垫付回补金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("return_amount")]
        public int ReturnAmount { get; set; }

        /// <summary>
        /// 获取或设置出款方商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("payer_mchid")]
        public string PayerMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置出款方账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer_account")]
        [System.Text.Json.Serialization.JsonPropertyName("payer_account")]
        public string PayerAccount { get; set; } = default!;

        /// <summary>
        /// 获取或设置入账方商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("payee_mchid")]
        public string PayeeMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置入账方账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee_account")]
        [System.Text.Json.Serialization.JsonPropertyName("payee_account")]
        public string PayeeAccount { get; set; } = default!;

        /// <summary>
        /// 获取或设置垫付回补结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string Result { get; set; } = default!;

        /// <summary>
        /// 获取或设置垫付回补完成时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("success_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? SuccessTime { get; set; }
    }
}
