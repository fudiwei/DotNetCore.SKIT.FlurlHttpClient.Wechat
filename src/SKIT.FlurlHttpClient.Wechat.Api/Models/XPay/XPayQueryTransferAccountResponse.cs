namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_transfer_account 接口的响应。</para>
    /// </summary>
    public class XPayQueryTransferAccountResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Account
            {
                /// <summary>
                /// 获取或设置充值账户 UID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transfer_account_uid")]
                [System.Text.Json.Serialization.JsonPropertyName("transfer_account_uid")]
                public int TransferAccountUID { get; set; }

                /// <summary>
                /// 获取或设置充值账户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transfer_account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("transfer_account_name")]
                public string TransferAccountName { get; set; } = default!;

                /// <summary>
                /// 获取或设置充值账户服务商账号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transfer_account_agency_id")]
                [System.Text.Json.Serialization.JsonPropertyName("transfer_account_agency_id")]
                public int? TransferAccountAgencyId { get; set; }

                /// <summary>
                /// 获取或设置充值账户服务商账号名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transfer_account_agency_name")]
                [System.Text.Json.Serialization.JsonPropertyName("transfer_account_agency_name")]
                public string? TransferAccountAgencyName { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置广告金充值账户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acct_list")]
        [System.Text.Json.Serialization.JsonPropertyName("acct_list")]
        public Types.Account[] AccountList { get; set; } = default!;
    }
}
