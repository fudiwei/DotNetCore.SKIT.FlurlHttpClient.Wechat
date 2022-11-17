namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/funds/getbanklist 接口的响应。</para>
    /// </summary>
    public class ShopFundsGetBankListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Bank
            {
                /// <summary>
                /// 获取或设置开户银行。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_bank")]
                [System.Text.Json.Serialization.JsonPropertyName("account_bank")]
                public string AccountBank { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_type")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_type")]
                public int BankType { get; set; }

                /// <summary>
                /// 获取或设置银行联号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_id")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string BankId { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_code")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_code")]
                public string BankCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                public string BankName { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否需要填写支行信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_branch")]
                [System.Text.Json.Serialization.JsonPropertyName("need_branch")]
                public bool RequireBranch { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置银行列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Bank[] BankList { get; set; } = default!;
    }
}
