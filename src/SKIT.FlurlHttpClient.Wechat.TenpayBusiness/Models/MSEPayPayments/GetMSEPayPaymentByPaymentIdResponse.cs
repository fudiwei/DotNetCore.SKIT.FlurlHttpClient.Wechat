namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/payments/{payment_id} 接口的响应。</para>
    /// </summary>
    [WechatTenpayBusinessSensitive]
    public class GetMSEPayPaymentByPaymentIdResponse : WechatTenpayBusinessResponse
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
                /// 获取或设置企业名称（需使用平台私钥解密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ent_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ent_name")]
                [WechatTenpayBusinessSensitiveProperty]
                public string EnterpriseName { get; set; } = default!;

                /// <summary>
                /// 获取或设置企业账户 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ent_acct_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ent_acct_id")]
                public string EnterpriseAccountId { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行卡号后 4 位。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_number_last4")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_number_last4")]
                public string? BankAccountNumberLast4String { get; set; }
            }
        
            public class FailedReason
            {
                /// <summary>
                /// 获取或设置失败类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_type")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_type")]
                public string? FailedType { get; set; }

                /// <summary>
                /// 获取或设置失败原因详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_detail")]
                public string? FailedDetail { get; set; }
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
        /// 获取或设置收款方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee")]
        [System.Text.Json.Serialization.JsonPropertyName("payee")]
        public Types.Payee Payee { get; set; } = default!;

        /// <summary>
        /// 获取或设置微企付用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("user_openid")]
        public string? UserOpenId { get; set; }

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
        /// 获取或设置失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failed_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("failed_reason")]
        public Types.FailedReason? FailedReason { get; set; }

        /// <summary>
        /// 获取或设置附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attachment")]
        [System.Text.Json.Serialization.JsonPropertyName("attachment")]
        public string? Attachment { get; set; }
    }
}
