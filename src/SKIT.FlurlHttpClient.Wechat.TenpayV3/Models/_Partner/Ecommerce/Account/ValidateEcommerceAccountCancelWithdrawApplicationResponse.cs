namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/account/apply-cancel-withdraw/validate-cancel/{sub_mchid} 接口的响应。</para>
    /// </summary>
    public class ValidateEcommerceAccountCancelWithdrawApplicationResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class AccountInfo
            {
                /// <summary>
                /// 获取或设置出款子账户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("out_account_type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置账户金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }
            }

            public class BlockReason
            {
                /// <summary>
                /// 获取或设置原因类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置原因描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户号状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_state")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_state")]
        public string MerchanttState { get; set; } = default!;

        /// <summary>
        /// 获取或设置注销资格检查结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validate_result")]
        [System.Text.Json.Serialization.JsonPropertyName("validate_result")]
        public string ValidateResult { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户资金账户余额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_info")]
        [System.Text.Json.Serialization.JsonPropertyName("account_info")]
        public Types.AccountInfo[]? AccountInfoList { get; set; }

        /// <summary>
        /// 获取或设置不可发起注销原因列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("block_reasons")]
        [System.Text.Json.Serialization.JsonPropertyName("block_reasons")]
        public Types.BlockReason[]? BlockReasonList { get; set; }
    }
}
