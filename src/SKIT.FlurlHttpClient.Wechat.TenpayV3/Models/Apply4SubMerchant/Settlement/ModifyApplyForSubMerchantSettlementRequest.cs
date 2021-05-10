using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /apply4sub/sub_merchants/{sub_mchid}/modify-settlement 接口的请求。</para>
    /// </summary>
    public class ModifyApplyForSubMerchantSettlementRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置特约商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置账户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_type")]
        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
        public string AccountType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置银行账号（需使用微信支付平台公钥加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_number")]
        [System.Text.Json.Serialization.JsonPropertyName("account_number")]
        public string AccountNumberEncryptedData { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开户银行。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_bank")]
        [System.Text.Json.Serialization.JsonPropertyName("account_bank")]
        public string AccountBank { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开户银行省市编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_address_code")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_address_code")]
        public string BankAddressCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开户银行联行号。与字段 <see cref="BankBranchName"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_branch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_branch_id")]
        public string? BankBranchId { get; set; }

        /// <summary>
        /// 获取或设置开户开户银行全称（含支行）。与字段 <see cref="BankBranchId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
        public string? BankBranchName { get; set; }
    }
}
