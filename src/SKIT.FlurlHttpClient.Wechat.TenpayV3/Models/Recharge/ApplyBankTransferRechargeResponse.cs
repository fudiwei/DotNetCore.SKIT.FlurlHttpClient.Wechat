namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /recharge/bank-transfer-recharges/apply 接口的响应。</para>
    /// </summary>
    public class ApplyBankTransferRechargeResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class TransferInAccount
            {
                /// <summary>
                /// 获取或设置开户银行名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                public string? BankName { get; set; }

                /// <summary>
                /// 获取或设置开户银行省市编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_address_code")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_address_code")]
                public string? BankAddressCode { get; set; }

                /// <summary>
                /// 获取或设置开户银行行号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_code")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_code")]
                public string? BankCode { get; set; }

                /// <summary>
                /// 获取或设置银行账户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_name")]
                public string? BankAccountName { get; set; }

                /// <summary>
                /// 获取或设置银行账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_no")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_no")]
                public string? BankAccountNumber { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商户充值单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_recharge_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_recharge_no")]
        public string OutRechargeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信充值单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recharge_id")]
        [System.Text.Json.Serialization.JsonPropertyName("recharge_id")]
        public string RechargeId { get; set; } = default!;

        /// <summary>
        /// 获取或设置充值目标账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_in_account")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_in_account")]
        public Types.TransferInAccount TransferInAccount { get; set; } = default!;
    }
}
