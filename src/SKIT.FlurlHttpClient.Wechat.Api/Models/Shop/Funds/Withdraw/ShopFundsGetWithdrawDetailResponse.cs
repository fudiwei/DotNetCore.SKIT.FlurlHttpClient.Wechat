namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/funds/getwithdrawdetail 接口的响应。</para>
    /// </summary>
    public class ShopFundsGetWithdrawDetailResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Withdraw
            {
                /// <summary>
                /// 获取或设置提现金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置提现备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置银行名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                public string? BankName { get; set; }

                /// <summary>
                /// 获取或设置银行账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_num")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_num")]
                public string? BankAccountNumber { get; set; }

                /// <summary>
                /// 获取或设置银行附言。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_memo")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_memo")]
                public string? BankMemo { get; set; }

                /// <summary>
                /// 获取或设置提现状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置提现原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                public string? Reason { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置修改时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置提现信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw_info")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw_info")]
        public Types.Withdraw Withdraw { get; set; } = default!;
    }
}
