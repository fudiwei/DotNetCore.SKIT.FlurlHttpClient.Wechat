using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/applyments/ 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateEcommerceApplymentRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class BusinessLicense
            {
                /// <summary>
                /// 获取或设置营业执照注册号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_license_number")]
                [System.Text.Json.Serialization.JsonPropertyName("business_license_number")]
                public string LicenceNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置营业执照照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_license_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("business_license_copy")]
                public string LicenseCopyMediaId { get; set; } = string.Empty;

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

                /// <summary>
                /// 获取或设置营业执照有效日期（格式：["yyyy-MM-dd", "yyyy-MM-dd"]，长期用 "长期" 表示）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_time")]
                [System.Text.Json.Serialization.JsonPropertyName("business_time")]
                public string? LicenseValidDate { get; set; }
            }

            public class OrganizationCertificate
            {
                /// <summary>
                /// 获取或设置组织机构代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("organization_number")]
                [System.Text.Json.Serialization.JsonPropertyName("organization_number")]
                public string OrganizationNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置组织机构代码证照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("organization_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("organization_copy")]
                public string OrganizationCopyMediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置组织机构代码证有效日期（格式：["yyyy-MM-dd", "yyyy-MM-dd"]，长期用 "长期" 表示）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("organization_time")]
                [System.Text.Json.Serialization.JsonPropertyName("organization_time")]
                public string OrganizationValidDate { get; set; } = string.Empty;
            }

            public class IdCard
            {
                /// <summary>
                /// 获取或设置身份证人像面照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_copy")]
                public string IdCardFrontCopyMediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证国徽面照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_national")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_national")]
                public string IdCardBackCopyMediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证姓名（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_name")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_name")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                public string IdCardName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证号码（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_number")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_number")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                public string IdCardNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证有效期结束时间（格式：yyyy-MM-dd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_valid_time")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_valid_time")]
                public string PeriodEndDate { get; set; } = string.Empty;
            }

            public class IdDocument
            {
                /// <summary>
                /// 获取或设置证件照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_doc_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("id_doc_copy")]
                public string IdDocumentCopyMediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件姓名（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_doc_name")]
                [System.Text.Json.Serialization.JsonPropertyName("id_doc_name")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                public string IdDocumentName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件号码（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_doc_number")]
                [System.Text.Json.Serialization.JsonPropertyName("id_doc_number")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                public string IdDocumentNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件有效期结束时间（格式：yyyy-MM-dd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("doc_period_end")]
                [System.Text.Json.Serialization.JsonPropertyName("doc_period_end")]
                public string PeriodEndDate { get; set; } = string.Empty;
            }

            public class Contact
            {
                /// <summary>
                /// 获取或设置超级管理员类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_type")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_type")]
                public string ContactType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置超级管理员姓名（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_name")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_name")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                public string ContactName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置联系人手机号（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile_phone")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                public string ContactMobile { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置超级管理员身份证号码（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_id_card_number")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_id_card_number")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                public string ContactIdCardNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置联系邮箱（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_email")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_email")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                public string ContactEmail { get; set; } = string.Empty;
            }

            public class BankAccount
            {
                /// <summary>
                /// 获取或设置账户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_type")]
                public string AccountType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开户名称（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("account_name")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                public string AccountName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置银行账号（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_number")]
                [System.Text.Json.Serialization.JsonPropertyName("account_number")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
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

            public class SaleScene
            {
                /// <summary>
                /// 获取或设置店铺名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_name")]
                [System.Text.Json.Serialization.JsonPropertyName("store_name")]
                public string StoreName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置店铺链接。与字段 <see cref="StoreQrcodeMediaId"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_url")]
                [System.Text.Json.Serialization.JsonPropertyName("store_url")]
                public string? StoreUrl { get; set; }

                /// <summary>
                /// 获取或设置店铺二维码媒体文件标识 ID。与字段 <see cref="StoreUrl"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_qr_code")]
                [System.Text.Json.Serialization.JsonPropertyName("store_qr_code")]
                public string? StoreQrcodeMediaId { get; set; }

                /// <summary>
                /// 获取或设置子商户小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mini_program_sub_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("mini_program_sub_appid")]
                public string? MiniProgramSubAppId { get; set; }
            }
        }

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
        /// 获取或设置营业执照信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_license_info")]
        [System.Text.Json.Serialization.JsonPropertyName("business_license_info")]
        public Types.BusinessLicense? BusinessLicense { get; set; }

        /// <summary>
        /// 获取或设置组织机构代码证信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organization_cert_info")]
        [System.Text.Json.Serialization.JsonPropertyName("organization_cert_info")]
        public Types.OrganizationCertificate? OrganizationCertificate { get; set; }

        /// <summary>
        /// 获取或设置法人证件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_doc_type")]
        [System.Text.Json.Serialization.JsonPropertyName("id_doc_type")]
        public string IdentityType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置身份证信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_card_info")]
        [System.Text.Json.Serialization.JsonPropertyName("id_card_info")]
        public Types.IdCard? IdCard { get; set; }

        /// <summary>
        /// 获取或设置其他类型证件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_doc_info")]
        [System.Text.Json.Serialization.JsonPropertyName("id_doc_info")]
        public Types.IdDocument? IdDocument { get; set; }

        /// <summary>
        /// 获取或设置是否填写结算银行账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_account_info")]
        [System.Text.Json.Serialization.JsonPropertyName("need_account_info")]
        public bool RequireBankAccount { get; set; }

        /// <summary>
        /// 获取或设置结算银行账户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_info")]
        [System.Text.Json.Serialization.JsonPropertyName("account_info")]
        public Types.BankAccount BankAccount { get; set; } = new Types.BankAccount();

        /// <summary>
        /// 获取或设置超级管理员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_info")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_info")]
        public Types.Contact Contact { get; set; } = new Types.Contact();

        /// <summary>
        /// 获取或设置销售场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sales_scene_info")]
        [System.Text.Json.Serialization.JsonPropertyName("sales_scene_info")]
        public Types.SaleScene SaleScene { get; set; } = new Types.SaleScene();

        /// <summary>
        /// 获取或设置商户简称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_shortname")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_shortname")]
        public string MerchantShortName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置特殊资质图片媒体文件标识 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualifications")]
        [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
        public IList<string>? QualificationPictureMediaIdList { get; set; }

        /// <summary>
        /// 获取或设置补充材料媒体文件标识 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_addition_pics")]
        [System.Text.Json.Serialization.JsonPropertyName("business_addition_pics")]
        public IList<string>? BusinessAdditionPictureMediaIdList { get; set; }

        /// <summary>
        /// 获取或设置补充说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_addition_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("business_addition_desc")]
        public string? BusinessAdditionDescription { get; set; }
    }
}
