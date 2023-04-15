namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/profit-allocations/receiver-accounts 接口的响应。</para>
    /// </summary>
    public class QueryProfitAllocationReceiverAccountsResponse : WechatTenpayBusinessResponse
    {
        public static class Types
        {
            public class ReceiverAccount
            {
                public static class Types
                {
                    public class WithdrawCycle
                    {
                        /// <summary>
                        /// 获取或设置周期类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cycle_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("cycle_type")]
                        public string CycleType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置周期值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cycle_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("cycle_value")]
                        public int CycleValue { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置接收方账户 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_acct_id")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_acct_id")]
                public string ReceiverAccountId { get; set; } = default!;

                /// <summary>
                /// 获取或设置接收方类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_type")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_type")]
                public string ReceiverType { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_name")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
                public string MerchantName { get; set; } = default!;

                /// <summary>
                /// 获取或设置统一社会信用代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unified_social_credit_code")]
                [System.Text.Json.Serialization.JsonPropertyName("unified_social_credit_code")]
                public string? UnifiedSocialCreditCode { get; set; }

                /// <summary>
                /// 获取或设置个人身份证号掩码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_num_mask")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_num_mask")]
                public string? IdCardNumberMask { get; set; }

                /// <summary>
                /// 获取或设置个人身份证号 MD5 值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_num_md5")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_num_md5")]
                public string? IdCardNumberMd5 { get; set; }

                /// <summary>
                /// 获取或设置开户银行。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                public string BankName { get; set; } = default!;

                /// <summary>
                /// 获取或设置账户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                public string AccountType { get; set; } = default!;

                /// <summary>
                /// 获取或设置开户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_name")]
                public string BankAccountName { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行卡号后 4 位。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_number_last4")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_number_last4")]
                public string BankAccountNumberLast4String { get; set; } = default!;

                /// <summary>
                /// 获取或设置分账方提现周期信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("withdraw_cycle")]
                [System.Text.Json.Serialization.JsonPropertyName("withdraw_cycle")]
                public Types.WithdrawCycle WithdrawCycle { get; set; } = default!;

                /// <summary>
                /// 获取或设置接收方提现周期信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_withdraw_cycle")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_withdraw_cycle")]
                public Types.WithdrawCycle ReceiverWithdrawCycle { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置分账接收方账户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver_accts")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver_accts")]
        public Types.ReceiverAccount[] ReceiverAccountList { get; set; } = default!;
    }
}
