using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /mchalterapply/mchsubjectalterapplyment 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateMerchantAlterApplyMerchantSubjectAlterApplymentRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class BusinessLicense
            {
                /// <summary>
                /// 获取或设置营业执照注册号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("license_number")]
                [System.Text.Json.Serialization.JsonPropertyName("license_number")]
                public string LicenseNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置营业执照照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("license_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("license_copy")]
                public string LicenseCopyMediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置营业执照有效期开始日期字符串（格式："yyyy-MM-dd"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("license_period_begin")]
                [System.Text.Json.Serialization.JsonPropertyName("license_period_begin")]
                public string? LicensePeriodBeginDateString { get; set; }

                /// <summary>
                /// 获取或设置营业执照有效期结束日期字符串（格式："yyyy-MM-dd" / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("license_period_end")]
                [System.Text.Json.Serialization.JsonPropertyName("license_period_end")]
                public string? LicensePeriodEndDateString { get; set; }

                /// <summary>
                /// 获取或设置商户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_name")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
                public string MerchantName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置法人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_person")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_person")]
                public string LegalPerson { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置注册地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_address")]
                [System.Text.Json.Serialization.JsonPropertyName("company_address")]
                public string? CompanyAddress { get; set; }
            }

            public class FinanceInstitutionLicense : CreateApplyForSubjectApplymentRequest.Types.Subject.Types.FinanceInstitutionLicense
            {
            }

            public class InstitutionalCertificate
            {
                /// <summary>
                /// 获取或设置证书类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cert_type")]
                [System.Text.Json.Serialization.JsonPropertyName("cert_type")]
                public string CertificateType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证书编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cert_number")]
                [System.Text.Json.Serialization.JsonPropertyName("cert_number")]
                public string CertificateNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证书照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cert_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("cert_copy")]
                public string CertificateCopyMediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证书有效期开始日期字符串（格式："yyyy-MM-dd"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cert_period_begin")]
                [System.Text.Json.Serialization.JsonPropertyName("cert_period_begin")]
                public string? CertificatePeriodBeginDateString { get; set; }

                /// <summary>
                /// 获取或设置证书有效期结束日期字符串（格式："yyyy-MM-dd" / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cert_period_end")]
                [System.Text.Json.Serialization.JsonPropertyName("cert_period_end")]
                public string? CertificatePeriodEndDateString { get; set; }

                /// <summary>
                /// 获取或设置商户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_name")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
                public string MerchantName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置法人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_person")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_person")]
                public string LegalPerson { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置注册地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_address")]
                [System.Text.Json.Serialization.JsonPropertyName("company_address")]
                public string? CompanyAddress { get; set; }
            }

            public class LegalPerson
            {
                /// <summary>
                /// 获取或设置证件持有人类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_holder_type")]
                [System.Text.Json.Serialization.JsonPropertyName("id_holder_type")]
                public string? IdHolderType { get; set; }

                /// <summary>
                /// 获取或设置证件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_doc_type")]
                [System.Text.Json.Serialization.JsonPropertyName("id_doc_type")]
                public string? IdentityType { get; set; }

                /// <summary>
                /// 获取或设置证件姓名（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_name")]
                [System.Text.Json.Serialization.JsonPropertyName("card_name")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string? IdName { get; set; }

                /// <summary>
                /// 获取或设置证件号码（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_number")]
                [System.Text.Json.Serialization.JsonPropertyName("card_number")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string? IdNumber { get; set; }

                /// <summary>
                /// 获取或设置证件地址（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_address")]
                [System.Text.Json.Serialization.JsonPropertyName("card_address")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string? IdAddress { get; set; }

                /// <summary>
                /// 获取或设置证件有效期开始日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_period_begin")]
                [System.Text.Json.Serialization.JsonPropertyName("card_period_begin")]
                public string? IdPeriodBeginDateString { get; set; }

                /// <summary>
                /// 获取或设置证件有效期结束日期字符串（格式：yyyy-MM-dd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_period_end")]
                [System.Text.Json.Serialization.JsonPropertyName("card_period_end")]
                public string? IdPeriodEndDateString { get; set; }

                /// <summary>
                /// 获取或设置证件正面照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_front")]
                [System.Text.Json.Serialization.JsonPropertyName("card_front")]
                public string? IdFrontCopyMediaId { get; set; }

                /// <summary>
                /// 获取或设置证件反面照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_back")]
                [System.Text.Json.Serialization.JsonPropertyName("card_back")]
                public string? IdBackCopyMediaId { get; set; }

                /// <summary>
                /// 获取或设置法人代表授权函媒体文件标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorize_letter_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("authorize_letter_copy")]
                public string? AuthorizeLetterCopyMediaId { get; set; }

                /// <summary>
                /// 获取或设置法人是否为受益人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("as_ubo")]
                [System.Text.Json.Serialization.JsonPropertyName("as_ubo")]
                public bool? AsUBO { get; set; }
            }

            public class UBO
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
                [Newtonsoft.Json.JsonProperty("card_name")]
                [System.Text.Json.Serialization.JsonPropertyName("card_name")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string? IdName { get; set; }

                /// <summary>
                /// 获取或设置证件号码（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_number")]
                [System.Text.Json.Serialization.JsonPropertyName("card_number")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string? IdNumber { get; set; }

                /// <summary>
                /// 获取或设置证件地址（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_address")]
                [System.Text.Json.Serialization.JsonPropertyName("card_address")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string? IdAddress { get; set; }

                /// <summary>
                /// 获取或设置证件有效期开始日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_period_begin")]
                [System.Text.Json.Serialization.JsonPropertyName("card_period_begin")]
                public string? IdPeriodBeginDateString { get; set; }

                /// <summary>
                /// 获取或设置证件有效期结束日期字符串（格式：yyyy-MM-dd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_period_end")]
                [System.Text.Json.Serialization.JsonPropertyName("card_period_end")]
                public string? IdPeriodEndDateString { get; set; }

                /// <summary>
                /// 获取或设置证件正面照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_front")]
                [System.Text.Json.Serialization.JsonPropertyName("card_front")]
                public string? IdFrontCopyMediaId { get; set; }

                /// <summary>
                /// 获取或设置证件反面照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_back")]
                [System.Text.Json.Serialization.JsonPropertyName("card_back")]
                public string? IdBackCopyMediaId { get; set; }
            }

            public class Addition
            {
                /// <summary>
                /// 获取或设置银行开户许可证 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_openaccount_license")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_openaccount_license")]
                public string? BankOpenAccountLicenseCopyMediaId { get; set; }

                /// <summary>
                /// 获取或设置开户核准通知书 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openaccount_approval")]
                [System.Text.Json.Serialization.JsonPropertyName("openaccount_approval")]
                public string? OpenAccountApprovalCopyMediaId { get; set; }

                /// <summary>
                /// 获取或设置法人身份辅助证明 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_other_prove")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_other_prove")]
                public string? LegalPersonOtherProveCopyMediaId { get; set; }

                /// <summary>
                /// 获取或设置发证机关证明 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agency_prove")]
                [System.Text.Json.Serialization.JsonPropertyName("agency_prove")]
                public string? AgencyProveCopyMediaId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置特约商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_code")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_code")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置业务申请编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置主体类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organization_type")]
        [System.Text.Json.Serialization.JsonPropertyName("organization_type")]
        public string SubjectType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否是金融机构。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finance_institution")]
        [System.Text.Json.Serialization.JsonPropertyName("finance_institution")]
        public bool? IsFinanceInstitution { get; set; }

        /// <summary>
        /// 获取或设置营业执照信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_license_info")]
        [System.Text.Json.Serialization.JsonPropertyName("business_license_info")]
        public Types.BusinessLicense? BusinessLicense { get; set; }

        /// <summary>
        /// 获取或设置登记证书信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_info")]
        [System.Text.Json.Serialization.JsonPropertyName("certificate_info")]
        public Types.InstitutionalCertificate? InstitutionalCertificate { get; set; }

        /// <summary>
        /// 获取或设置金融机构许可证信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finance_institution_info")]
        [System.Text.Json.Serialization.JsonPropertyName("finance_institution_info")]
        public Types.FinanceInstitutionLicense? FinanceInstitutionLicense { get; set; }

        /// <summary>
        /// 获取或设置法人身份信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_person_info")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_person_info")]
        public Types.LegalPerson? LegalPerson { get; set; }

        /// <summary>
        /// 获取或设置最终受益人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ubo_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("ubo_info_list")]
        public IList<Types.UBO>? UBOList { get; set; }

        /// <summary>
        /// 获取或设置补充材料信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addition")]
        [System.Text.Json.Serialization.JsonPropertyName("addition")]
        public Types.Addition? Addition { get; set; }
    }
}
