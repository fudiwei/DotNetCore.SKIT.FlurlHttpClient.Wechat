using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/account/apply-cancel-withdraw 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateEcommerceAccountCancelWithdrawApplicationRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Payee
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
                        /// 获取或设置开户银行名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_bank")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_bank")]
                        public string AccountBank { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置开户银行支行名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bank_branch_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("bank_branch_name")]
                        public string? BankBranchName { get; set; }

                        /// <summary>
                        /// 获取或设置开户银行支行联行号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bank_branch_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("bank_branch_id")]
                        public string? BankBranchId { get; set; }

                        /// <summary>
                        /// 获取或设置银行账号（需使用平台公钥/证书加密）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_number")]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                        public string AccountNumber { get; set; } = string.Empty;
                    }

                    public class Identify
                    {
                        /// <summary>
                        /// 获取或设置证件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_doc_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_doc_type")]
                        public string IdentityType { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置证件姓名（需使用平台公钥/证书加密）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("identification_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("identification_name")]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                        public string IdName { get; set; } = string.Empty;

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
                /// 获取或设置账户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                public string AccountType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置银行账户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_info")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_info")]
                public Types.BankAccount? BankAccount { get; set; }

                /// <summary>
                /// 获取或设置证件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identity_info")]
                [System.Text.Json.Serialization.JsonPropertyName("identity_info")]
                public Types.Identify? Identify { get; set; }
            }

            public class ProofMedia
            {
                /// <summary>
                /// 获取或设置申请材料类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("proof_media_type")]
                [System.Text.Json.Serialization.JsonPropertyName("proof_media_type")]
                public string Type { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置申请材料 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("proof_media")]
                [System.Text.Json.Serialization.JsonPropertyName("proof_media")]
                public string MediaId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置微信二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户注销申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置提取资金类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw")]
        public string? WithdrawType { get; set; }

        /// <summary>
        /// 获取或设置收款信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee_info")]
        [System.Text.Json.Serialization.JsonPropertyName("payee_info")]
        public Types.Payee? Payee { get; set; }

        /// <summary>
        /// 获取或设置申请材料列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("proof_medias")]
        [System.Text.Json.Serialization.JsonPropertyName("proof_medias")]
        public IList<Types.ProofMedia>? ProofMediaList { get; set; }

        /// <summary>
        /// 获取或设置其他补充材料 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("additional_materials")]
        [System.Text.Json.Serialization.JsonPropertyName("additional_materials")]
        public IList<string>? AdditionalMaterialMediaIdList { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }
    }
}
