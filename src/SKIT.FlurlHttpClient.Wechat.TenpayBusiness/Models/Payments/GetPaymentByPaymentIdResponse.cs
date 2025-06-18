using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/payments/{payment_id} 接口的响应。</para>
    /// </summary>
    public class GetPaymentByPaymentIdResponse : WechatTenpayBusinessResponse
    {
        public static class Types
        {
            public class Payee
            {
                /// <summary>
                /// 获取或设置企业 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ent_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ent_id")]
                public string EnterpriseId { get; set; } = default!;

                /// <summary>
                /// 获取或设置企业名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ent_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ent_name")]
                public string EnterpriseName { get; set; } = default!;
            }

            public class Payer
            {
                /// <summary>
                /// 获取或设置付款方 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_id")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_id")]
                public string? PayerId { get; set; }

                /// <summary>
                /// 获取或设置付款方名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_name")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_name")]
                public string? PayerName { get; set; }

                /// <summary>
                /// 获取或设置平台付款方 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_payer_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_payer_id")]
                public string? OutPayerId { get; set; }

                /// <summary>
                /// 获取或设置银行卡号后 4 位。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_acct_last4")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_acct_last4")]
                public string? BankAccountNumberLast4String { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置平台支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_payment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_payment_id")]
        public string OutPaymentId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微企付支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_id")]
        public string PaymentId { get; set; } = default!;

        /// <summary>
        /// 获取或设置支付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置币种。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currency")]
        [System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string Currency { get; set; } = default!;

        /// <summary>
        /// 获取或设置付款方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public Types.Payer Payer { get; set; } = default!;

        /// <summary>
        /// 获取或设置收款方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee")]
        [System.Text.Json.Serialization.JsonPropertyName("payee")]
        public Types.Payee Payee { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_status")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置附言。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        [System.Text.Json.Serialization.JsonPropertyName("memo")]
        public string? Memo { get; set; }

        /// <summary>
        /// 获取或设置附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attachment")]
        [System.Text.Json.Serialization.JsonPropertyName("attachment")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置付款时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? SucceedTime { get; set; }
    }
}
