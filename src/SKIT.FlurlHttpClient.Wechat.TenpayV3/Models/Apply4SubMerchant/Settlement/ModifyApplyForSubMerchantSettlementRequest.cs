namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /apply4sub/sub_merchants/{sub_mchid}/modify-settlement 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
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
        /// 获取或设置银行账号（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_number")]
        [System.Text.Json.Serialization.JsonPropertyName("account_number")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string AccountNumber { get; set; } = string.Empty;

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
        /// 获取或设置开户银行全称（含支行）。与字段 <see cref="BankBranchId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
        public string? BankBranchName { get; set; }
    }
}
