using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /apply4sub/sub_merchants/{sub_mchid}/application/{application_no} 接口的响应。</para>
    /// </summary>
    public class GetApplyForSubMerchantSettlementByApplicationNumberResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置账户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_type")]
        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
        public string AccountType { get; set; } = default!;

        /// <summary>
        /// 获取或设置开户名称（掩码显示）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_name")]
        [System.Text.Json.Serialization.JsonPropertyName("account_name")]
        public string AccountName { get; set; } = default!;

        /// <summary>
        /// 获取或设置银行账号（掩码显示）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_number")]
        [System.Text.Json.Serialization.JsonPropertyName("account_number")]
        public string AccountNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置开户银行。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_bank")]
        [System.Text.Json.Serialization.JsonPropertyName("account_bank")]
        public string AccountBank { get; set; } = default!;

        /// <summary>
        /// 获取或设置开户银行省市编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_address_code")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_address_code")]
        public string? BankAddressCode { get; set; }

        /// <summary>
        /// 获取或设置开户银行联行号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_branch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_branch_id")]
        public string? BankBranchId { get; set; }

        /// <summary>
        /// 获取或设置开户银行全称（含支行）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
        public string? BankBranchName { get; set; }

        /// <summary>
        /// 获取或设置汇款验证结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_result")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_result")]
        public string VerifyResult { get; set; } = default!;

        /// <summary>
        /// 获取或设置汇款验证失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_fail_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_fail_reason")]
        public string? VerifyFailReason { get; set; }

        /// <summary>
        /// 获取或设置汇款验证失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_finish_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("verify_finish_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? VerifyFinishTime { get; set; }
    }
}
