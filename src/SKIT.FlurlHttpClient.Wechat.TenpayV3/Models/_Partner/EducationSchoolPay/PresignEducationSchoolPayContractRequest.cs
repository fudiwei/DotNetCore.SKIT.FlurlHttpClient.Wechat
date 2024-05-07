namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /eduschoolpay/contracts/presign 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class PresignEducationSchoolPayContractRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Identity
            {
                /// <summary>
                /// 获取或设置真实姓名（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("real_name")]
                [System.Text.Json.Serialization.JsonPropertyName("real_name")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string RealName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件号码（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_number")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_number")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string? CredentialNumber { get; set; }

                /// <summary>
                /// 获取或设置证件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("credential_type")]
                [System.Text.Json.Serialization.JsonPropertyName("credential_type")]
                public string? CredentialType { get; set; }
            }

            public class BankCard
            {
                /// <summary>
                /// 获取或设置银行类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_type")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_type")]
                public string? BankType { get; set; }

                /// <summary>
                /// 获取或设置银行卡号（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_card_no")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_card_no")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string BankCardNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置银行卡有效期字符串（单位：MM/yy）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_thru")]
                [System.Text.Json.Serialization.JsonPropertyName("valid_thru")]
                public string? ValidDateString { get; set; }

                /// <summary>
                /// 获取或设置银行卡开卡预留手机号（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string MobileNumber { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public string PlanId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户用户账号标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string OutUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置学校编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("school_id")]
        [System.Text.Json.Serialization.JsonPropertyName("school_id")]
        public string SchoolId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户签约号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_contract_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_contract_code")]
        public string OutContractCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置签约模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_mode")]
        public string? ContractMode { get; set; }

        /// <summary>
        /// 获取或设置是否允许降级为普通签约模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("downgrade_default_contract")]
        [System.Text.Json.Serialization.JsonPropertyName("downgrade_default_contract")]
        public bool? AllowDowngradeDefaultContract { get; set; }

        /// <summary>
        /// 获取或设置实名信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identity")]
        [System.Text.Json.Serialization.JsonPropertyName("identity")]
        public Types.Identity? Identity { get; set; }

        /// <summary>
        /// 获取或设置银行卡信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_card")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_card")]
        public Types.BankCard? BankCard { get; set; }
    }
}
