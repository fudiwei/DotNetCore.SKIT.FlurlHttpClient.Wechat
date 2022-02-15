namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /capital/capitallhh/banks/{bank_alias_code}/branches 接口的响应。</para>
    /// </summary>
    public class QueryCapitalBanksBranchesResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Branch
            {
                /// <summary>
                /// 获取或设置支行名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_branch_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_branch_name")]
                public string BranchName { get; set; } = default!;

                /// <summary>
                /// 获取或设置支行联行号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_branch_id")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_branch_id")]
                public string BranchId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置支行列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Branch[] BranchList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置数据总条数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

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
    }
}
