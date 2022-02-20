namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /capital/capitallhh/banks/search-banks-by-bank-account 接口的响应。</para>
    /// </summary>
    public class QueryCapitalBanksByBankAccountResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Bank
            {
                /// <summary>
                /// 获取或设置银行别名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_alias")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_alias")]
                public string BankAlias { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行别名编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_alias_code")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_alias_code")]
                public string BankAliasCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置开户银行。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_bank")]
                [System.Text.Json.Serialization.JsonPropertyName("account_bank")]
                public string AccountBank { get; set; } = default!;

                /// <summary>
                /// 获取或设置开户银行编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_bank_code")]
                [System.Text.Json.Serialization.JsonPropertyName("account_bank_code")]
                public int AccountBankCode { get; set; }

                /// <summary>
                /// 获取或设置是否需要填写支行。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_bank_branch")]
                [System.Text.Json.Serialization.JsonPropertyName("need_bank_branch")]
                public bool RequireBankBranch { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置银行列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Bank[] BankList { get; set; } = default!;

        /// <summary>
        /// 获取或设置数据总条数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
