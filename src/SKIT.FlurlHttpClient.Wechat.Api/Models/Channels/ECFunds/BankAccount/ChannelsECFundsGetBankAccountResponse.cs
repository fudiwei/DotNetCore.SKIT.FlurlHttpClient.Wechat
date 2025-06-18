namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/funds/getbankacct 接口的响应。</para>
    /// </summary>
    public class ChannelsECFundsGetBankAccountResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Account
            {
                /// <summary>
                /// 获取或设置银行账户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_type")]
                public string BankAccountType { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_bank")]
                [System.Text.Json.Serialization.JsonPropertyName("account_bank")]
                public string BankName { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行名称前端展示值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_bank4show")]
                [System.Text.Json.Serialization.JsonPropertyName("account_bank4show")]
                public string? BankNameForShow { get; set; }

                /// <summary>
                /// 获取或设置开户银行联行号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_address_code")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_address_code")]
                public string BankAddressCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行省市编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_branch_id")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_branch_id")]
                public string? BankBranchId { get; set; }

                /// <summary>
                /// 获取或设置开户银行全称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                public string? BankBranchName { get; set; }

                /// <summary>
                /// 获取或设置银行账户。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_number")]
                [System.Text.Json.Serialization.JsonPropertyName("account_number")]
                public string BankAccountNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行账户全称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("account_name")]
                public string? BankAccountName { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置银行账户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_info")]
        [System.Text.Json.Serialization.JsonPropertyName("account_info")]
        public Types.Account Account { get; set; } = default!;
    }
}
