using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /mch_operate/risk/withdrawl-apply 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateMerchantOperateRiskWithdrawlApplyRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class PayeeInfo
            {
                public static class Types
                {
                    public class BankAccount
                    {
                        /// <summary>
                        /// 获取或设置开户名称（需使用平台公钥/证书加密）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_name")]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                        public string AccountName { get; set; } = string.Empty;

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

                    public class Identity
                    {
                        /// <summary>
                        /// 获取或设置证件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_doc_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_doc_type")]
                        public string? IdentityType { get; set; }

                        /// <summary>
                        /// 获取或设置证件姓名（需使用平台公钥/证书加密）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("identification_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("identification_name")]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                        public string? IdName { get; set; }

                        /// <summary>
                        /// 获取或设置证件号码（需使用平台公钥/证书加密）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("identification_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("identification_no")]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                        public string? IdNumber { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置出款子账户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                public string AccountType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置银行账户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_info")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_info")]
                public Types.BankAccount BankAccount { get; set; } = new Types.BankAccount();

                /// <summary>
                /// 获取或设置收款人身份证件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identity_info")]
                [System.Text.Json.Serialization.JsonPropertyName("identity_info")]
                public Types.Identity? Identity { get; set; }

            }

            public class Proof
            {
                public static class Types
                {
                    public class PayeeProof
                    {
                        /// <summary>
                        /// 获取或设置证明材料 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("proof_media_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("proof_media_type")]
                        public string ProofId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置证明材料 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("proof_media")]
                        [System.Text.Json.Serialization.JsonPropertyName("proof_media")]
                        public string ProofMediaId { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置申请证明材料表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("proof_payee_media")]
                [System.Text.Json.Serialization.JsonPropertyName("proof_payee_media")]
                public IList<Types.PayeeProof>? PayeeProofList { get; set; }
            }

            public class AdditionalInformation
            {
                /// <summary>
                /// 获取或设置补充材料 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("additional_media")]
                [System.Text.Json.Serialization.JsonPropertyName("additional_media")]
                public IList<string>? AdditionalMaterialMediaIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置从业机构特约商户号	。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户提现申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置出款子账户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_account_type")]
        [System.Text.Json.Serialization.JsonPropertyName("out_account_type")]
        public string OutAccountType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置提现金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置收款对象类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee_type")]
        [System.Text.Json.Serialization.JsonPropertyName("payee_type")]
        public string PayeeType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收款对象对应的商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("payee_mchid")]
        public string? PayeeMerchantId { get; set; }

        /// <summary>
        /// 获取或设置收款账号信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee_info")]
        [System.Text.Json.Serialization.JsonPropertyName("payee_info")]
        public Types.PayeeInfo PayeeInfo { get; set; } = new Types.PayeeInfo();

        /// <summary>
        /// 获取或设置付款申请证明信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("proof_media_list")]
        [System.Text.Json.Serialization.JsonPropertyName("proof_media_list")]
        public Types.Proof? Proof { get; set; }

        /// <summary>
        /// 获取或设置补充材料信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("additional_materials")]
        [System.Text.Json.Serialization.JsonPropertyName("additional_materials")]
        public Types.AdditionalInformation? AdditionalInformation { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }
    }
}
