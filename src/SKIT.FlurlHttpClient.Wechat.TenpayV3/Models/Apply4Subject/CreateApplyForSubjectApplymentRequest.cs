using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /apply4subject/applyment 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateApplyForSubjectApplymentRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Contact
            {
                /// <summary>
                /// 获取或设置联系人类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_type")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_type")]
                public string? ContactType { get; set; }

                /// <summary>
                /// 获取或设置联系人姓名（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string ContactName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置联系人证件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_id_doc_type")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_id_doc_type")]
                public string? IdentityType { get; set; }

                /// <summary>
                /// 获取或设置联系人证件号码（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_number")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_number")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string? IdNumber { get; set; }

                /// <summary>
                /// 获取或设置联系人证件正面照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_id_doc_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_id_doc_copy")]
                public string? IdFrontCopyMediaId { get; set; }

                /// <summary>
                /// 获取或设置联系人证件背面照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_id_doc_copy_back")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_id_doc_copy_back")]
                public string? IdBackCopyMediaId { get; set; }

                /// <summary>
                /// 获取或设置联系人证件有效期开始日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_period_begin")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_period_begin")]
                public string? IdPeriodBeginDateString { get; set; }

                /// <summary>
                /// 获取或设置联系人证件有效期结束日期字符串（格式：yyyy-MM-dd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_period_end")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_period_end")]
                public string? IdPeriodEndDateString { get; set; }

                /// <summary>
                /// 获取或设置业务办理授权函媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_authorization_letter")]
                [System.Text.Json.Serialization.JsonPropertyName("business_authorization_letter")]
                public string? BusinessAuthorizeLetterCopyMediaId { get; set; }

                /// <summary>
                /// 获取或设置联系人手机号（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string MobileNumber { get; set; } = string.Empty;
            }

            public class Subject
            {
                public static class Types
                {
                    public class BusinessLicense
                    {
                        /// <summary>
                        /// 获取或设置营业执照注册号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("licence_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("licence_number")]
                        public string LicenseNumber { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置营业执照照片媒体文件标识 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("licence_copy")]
                        [System.Text.Json.Serialization.JsonPropertyName("licence_copy")]
                        public string LicenseCopyMediaId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置营业执照有效日期字符串（格式：["yyyy-MM-dd", "yyyy-MM-dd"]，长期用 "forever" 表示）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("licence_valid_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("licence_valid_date")]
                        public string LicenseValidPeriodString { get; set; } = string.Empty;

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
                        public string CompanyAddress { get; set; } = string.Empty;
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
                        /// 获取或设置证书有效日期字符串（格式：["yyyy-MM-dd", "yyyy-MM-dd"]，长期用 "forever" 表示）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cert_valid_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("cert_valid_date")]
                        public string CertificateValidPeriodString { get; set; } = string.Empty;

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
                        public string CompanyAddress { get; set; } = string.Empty;
                    }

                    public class AssistedProof
                    {
                        /// <summary>
                        /// 获取或设置小微经营类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("micro_biz_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("micro_biz_type")]
                        public string MicroBusinessType { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置门店名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("store_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("store_name")]
                        public string StoreName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置门店省市编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("store_address_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("store_address_code")]
                        public string StoreAddressCode { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置门店地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("store_address")]
                        [System.Text.Json.Serialization.JsonPropertyName("store_address")]
                        public string StoreAddress { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置门店门头照片媒体文件标识 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("store_header_copy")]
                        [System.Text.Json.Serialization.JsonPropertyName("store_header_copy")]
                        public string StoreEntranceCopyMediaId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置店内环境照片媒体文件标识 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("store_indoor_copy")]
                        [System.Text.Json.Serialization.JsonPropertyName("store_indoor_copy")]
                        public string StoreIndoorCopyMediaId { get; set; } = string.Empty;
                    }

                    public class SpecialOperation
                    {
                        /// <summary>
                        /// 获取或设置行业 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                        public int CategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置行业经营许可证资质照片媒体文件标识 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("operation_copy_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("operation_copy_list")]
                        public IList<string> OperationCopyMediaIdList { get; set; } = new List<string>();
                    }

                    public class FinanceInstitutionLicense
                    {
                        /// <summary>
                        /// 获取或设置金融机构类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("finance_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("finance_type")]
                        public string FinanceType { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置金融机构许可证图片媒体文件标识 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("finance_license_pics")]
                        [System.Text.Json.Serialization.JsonPropertyName("finance_license_pics")]
                        public IList<string> FinanceLicensePictureMediaIdList { get; set; } = new List<string>();
                    }
                }

                /// <summary>
                /// 获取或设置主体类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subject_type")]
                [System.Text.Json.Serialization.JsonPropertyName("subject_type")]
                public string SubjectType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置单位证明函照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_prove_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("company_prove_copy")]
                public string? CompanyProveCopyMediaId { get; set; }

                /// <summary>
                /// 获取或设置是否是金融机构。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_finance_institution")]
                [System.Text.Json.Serialization.JsonPropertyName("is_finance_institution")]
                public bool? IsFinanceInstitution { get; set; }

                /// <summary>
                /// 获取或设置营业执照信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_licence_info")]
                [System.Text.Json.Serialization.JsonPropertyName("business_licence_info")]
                public Types.BusinessLicense? BusinessLicense { get; set; }

                /// <summary>
                /// 获取或设置登记证书信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate_info")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate_info")]
                public Types.InstitutionalCertificate? InstitutionalCertificate { get; set; }

                /// <summary>
                /// 获取或设置辅助证明材料信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("assist_prove_info")]
                [System.Text.Json.Serialization.JsonPropertyName("assist_prove_info")]
                public Types.AssistedProof? AssistedProof { get; set; }

                /// <summary>
                /// 获取或设置经营许可证列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("special_operation_list")]
                [System.Text.Json.Serialization.JsonPropertyName("special_operation_list")]
                public IList<Types.SpecialOperation>? SpecialOperationList { get; set; }

                /// <summary>
                /// 获取或设置金融机构许可证信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finance_institution_info")]
                [System.Text.Json.Serialization.JsonPropertyName("finance_institution_info")]
                public Types.FinanceInstitutionLicense? FinanceInstitutionLicense { get; set; }
            }

            public class Identification
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
                [Newtonsoft.Json.JsonProperty("identification_type")]
                [System.Text.Json.Serialization.JsonPropertyName("identification_type")]
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
                [Newtonsoft.Json.JsonProperty("identification_number")]
                [System.Text.Json.Serialization.JsonPropertyName("identification_number")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string? IdNumber { get; set; }

                /// <summary>
                /// 获取或设置证件地址（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identification_address")]
                [System.Text.Json.Serialization.JsonPropertyName("identification_address")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string? IdAddress { get; set; }

                /// <summary>
                /// 获取或设置证件有效日期字符串（格式：["yyyy-MM-dd", "yyyy-MM-dd"]）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identification_valid_date")]
                [System.Text.Json.Serialization.JsonPropertyName("identification_valid_date")]
                public string? IdValidPeriodString { get; set; }

                /// <summary>
                /// 获取或设置证件正面照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identification_front_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("identification_front_copy")]
                public string? IdFrontCopyMediaId { get; set; }

                /// <summary>
                /// 获取或设置证件反面照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identification_back_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("identification_back_copy")]
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
                [Newtonsoft.Json.JsonProperty("owner")]
                [System.Text.Json.Serialization.JsonPropertyName("owner")]
                public bool? IsOwner { get; set; }
            }

            public class UBO
            {
                /// <summary>
                /// 获取或设置证件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ubo_id_doc_type")]
                [System.Text.Json.Serialization.JsonPropertyName("ubo_id_doc_type")]
                public string IdentityType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置受益人姓名（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ubo_id_doc_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ubo_id_doc_name")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string IdName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件正面照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ubo_id_doc_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("ubo_id_doc_copy")]
                public string? IdFrontCopyMediaId { get; set; }

                /// <summary>
                /// 获取或设置证件背面照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ubo_id_doc_copy_back")]
                [System.Text.Json.Serialization.JsonPropertyName("ubo_id_doc_copy_back")]
                public string? IdBackCopyMediaId { get; set; }

                /// <summary>
                /// 获取或设置证件号码（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ubo_id_doc_number")]
                [System.Text.Json.Serialization.JsonPropertyName("ubo_id_doc_number")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string? IdNumber { get; set; }

                /// <summary>
                /// 获取或设置证件地址（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ubo_id_doc_address")]
                [System.Text.Json.Serialization.JsonPropertyName("ubo_id_doc_address")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string? IdAddress { get; set; }

                /// <summary>
                /// 获取或设置证件有效期开始日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ubo_period_begin")]
                [System.Text.Json.Serialization.JsonPropertyName("ubo_period_begin")]
                public string? IdPeriodBeginDateString { get; set; }

                /// <summary>
                /// 获取或设置证件有效期结束日期字符串（格式：yyyy-MM-dd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ubo_period_end")]
                [System.Text.Json.Serialization.JsonPropertyName("ubo_period_end")]
                public string? IdPeriodEndDateString { get; set; }
            }

            public class Addition
            {
                /// <summary>
                /// 获取或设置待确认商户号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("confirm_mchid_list")]
                [System.Text.Json.Serialization.JsonPropertyName("confirm_mchid_list")]
                public IList<string>? ConfirmMerchantIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置渠道商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// 获取或设置业务申请编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_code")]
        [System.Text.Json.Serialization.JsonPropertyName("business_code")]
        public string BusinessCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置联系人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_info")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_info")]
        public Types.Contact Contact { get; set; } = new Types.Contact();

        /// <summary>
        /// 获取或设置主体信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subject_info")]
        [System.Text.Json.Serialization.JsonPropertyName("subject_info")]
        public Types.Subject Subject { get; set; } = new Types.Subject();

        /// <summary>
        /// 获取或设置法人身份信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identification_info")]
        [System.Text.Json.Serialization.JsonPropertyName("identification_info")]
        public Types.Identification Identification { get; set; } = new Types.Identification();

        /// <summary>
        /// 获取或设置最终受益人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ubo_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("ubo_info_list")]
        public IList<Types.UBO>? UBOList { get; set; }

        /// <summary>
        /// 获取或设置补充材料信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addition_info")]
        [System.Text.Json.Serialization.JsonPropertyName("addition_info")]
        public Types.Addition? Addition { get; set; }
    }
}
