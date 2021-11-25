using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /apply4subject/applyment 接口的请求。</para>
    /// </summary>
    public class CreateApplyForSubjectApplymentRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Contact
            {
                /// <summary>
                /// 获取或设置联系人姓名（需使用微信支付平台公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置联系人手机号（需使用微信支付平台公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
                public string Mobile { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置联系人身份证号码（需使用微信支付平台公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_number")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_number")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
                public string IdCardNumber { get; set; } = string.Empty;
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
                        /// 获取或设置营业执照有效日期（格式：["yyyy-MM-dd", "yyyy-MM-dd"]，长期用 "forever" 表示）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("licence_valid_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("licence_valid_date")]
                        public string LicenseValidDate { get; set; } = string.Empty;

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
                        /// 获取或设置证书有效日期（格式：["yyyy-MM-dd", "yyyy-MM-dd"]，长期用 "forever" 表示）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cert_valid_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("cert_valid_date")]
                        public string CertificateValidDate { get; set; } = string.Empty;

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
                        public string CategoryId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置行业经营许可证资质照片媒体文件标识 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("operation_copy_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("operation_copy_list")]
                        public IList<string> OperationCopyMediaIdList { get; set; } = new List<string>();
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
            }

            public class Identification
            {
                /// <summary>
                /// 获取或设置证件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identification_type")]
                [System.Text.Json.Serialization.JsonPropertyName("identification_type")]
                public string IdentificationType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件姓名（需使用微信支付平台公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identification_name")]
                [System.Text.Json.Serialization.JsonPropertyName("identification_name")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
                public string IdentificationName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件号码（需使用微信支付平台公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identification_number")]
                [System.Text.Json.Serialization.JsonPropertyName("identification_number")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
                public string IdentificationNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件有效日期（格式：["yyyy-MM-dd", "yyyy-MM-dd"]）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identification_valid_date")]
                [System.Text.Json.Serialization.JsonPropertyName("identification_valid_date")]
                public string IdentificationValidDate { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件正面照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identification_front_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("identification_front_copy")]
                public string IdentificationFrontCopyMediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件反面照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identification_back_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("identification_back_copy")]
                public string? IdentificationBackCopyMediaId { get; set; }
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
        /// 获取或设置补充材料信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addition_info")]
        [System.Text.Json.Serialization.JsonPropertyName("addition_info")]
        public Types.Addition? Addition { get; set; }
    }
}
