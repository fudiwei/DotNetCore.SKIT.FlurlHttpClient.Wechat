using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/miniapppay/apply_mch 接口的请求。</para>
    /// </summary>
    public class CgibinMiniAppPayApplyMechantRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class BusinessLicense
            {
                /// <summary>
                /// 获取或设置证书类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cert_type")]
                [System.Text.Json.Serialization.JsonPropertyName("cert_type")]
                public int CertificateType { get; set; }

                /// <summary>
                /// 获取或设置营业执照扫描件 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_license_copy_open_wx_pay_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("business_license_copy_open_wx_pay_media_id")]
                public string BusinessLicensePictureMediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置营业执照编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_license_number")]
                [System.Text.Json.Serialization.JsonPropertyName("business_license_number")]
                public string BusinessLicenseNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_name")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
                public string MerchantName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置法定代表人姓名。
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
                /// 获取或设置营业期限开始日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_time_begin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("business_time_begin_time")]
                public string? BusinessTimeBeginDateString { get; set; }

                /// <summary>
                /// 获取或设置营业期限截止日期字符串（格式：yyyy-MM-dd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_time_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("business_time_end_time")]
                public string? BusinessTimeEndDateString { get; set; }
            }

            public class FinanceInstitution
            {
                /// <summary>
                /// 获取或设置金融机构类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finance_type")]
                [System.Text.Json.Serialization.JsonPropertyName("finance_type")]
                public string FinanceType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置金融机构许可证图片 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finance_license_pics_open_wx_pay_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("finance_license_pics_open_wx_pay_media_id")]
                public IList<string> FinanceLicensePictureMediaIdList { get; set; } = new List<string>();
            }

            public class IdCard
            {
                /// <summary>
                /// 获取或设置证件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_doc_type")]
                [System.Text.Json.Serialization.JsonPropertyName("id_doc_type")]
                public int IdDocumentType { get; set; }

                /// <summary>
                /// 获取或设置证件人像面图片 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_copy_open_wx_pay_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_copy_open_wx_pay_media_id")]
                public string IdCardFrontPictureMediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件国徽面图片 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_national_open_wx_pay_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_national_open_wx_pay_media_id")]
                public string IdCardBackPictureMediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_name")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_name")]
                public string IdCardName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_number")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_number")]
                public string IdCardNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_address")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_address")]
                public string? IdCardAddress { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件有效期开始日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_valid_time_begin")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_valid_time_begin")]
                public string IdCardPeriodBeginDateString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件有效期截止日期字符串（格式：yyyy-MM-dd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_valid_time")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_valid_time")]
                public string IdCardPeriodEndDateString { get; set; } = string.Empty;
            }

            public class UBO : IdCard
            {
            }

            public class Contact
            {
                public static class Types
                {
                    public class IdCard : CgibinMiniAppPayApplyMechantRequest.Types.IdCard
                    {
                    }
                }

                /// <summary>
                /// 获取或设置超级管理员类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_type")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_type")]
                public string ContactType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置业务办理授权函图片 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_authorization_letter_open_wx_pay_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("business_authorization_letter_open_wx_pay_media_id")]
                public string? BusinessAuthorizationLetterPictureMediaId { get; set; }

                /// <summary>
                /// 获取或设置超级管理员证件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_info")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_info")]
                public Types.IdCard IdCard { get; set; } = new Types.IdCard();

                /// <summary>
                /// 获取或设置超级管理员手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile_phone")]
                public string? MobileNumber { get; set; }

                /// <summary>
                /// 获取或设置超级管理员邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_email")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_email")]
                public string? Email { get; set; }
            }

            public class BankAccount
            {
                public static class Types
                {
                    public class BankCardSupplement
                    {
                        /// <summary>
                        /// 获取或设置结算证明图片 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settlement_certificate_open_wx_pay_media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("settlement_certificate_open_wx_pay_media_id")]
                        public string? SettlementCertificatePictureMediaId { get; set; }

                        /// <summary>
                        /// 获取或设置关系证明图片 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("relationship_certificate_open_wx_pay_media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("relationship_certificate_open_wx_pay_media_id")]
                        public string? RelationshipCertificatePictureMediaId { get; set; }

                        /// <summary>
                        /// 获取或设置其他证明图片 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("other_certificate_open_wx_pay_media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("other_certificate_open_wx_pay_media_id")]
                        public IList<string>? OtherCertificatePictureMediaIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置账户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_type")]
                public int? BankAccountType { get; set; }

                /// <summary>
                /// 获取或设置开户银行。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_bank")]
                [System.Text.Json.Serialization.JsonPropertyName("account_bank")]
                public string AccountBank { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("account_name")]
                public string AccountName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置银行账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_number")]
                [System.Text.Json.Serialization.JsonPropertyName("account_number")]
                public string AccountNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开户银行省市编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_address_code")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_address_code")]
                public string BankAddressCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开户银行全称（含支行）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                public string? BankName { get; set; }

                /// <summary>
                /// 获取或设置银行卡补充资料。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_card_supplement")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_card_supplement")]
                public Types.BankCardSupplement? BankCardSupplement { get; set; }
            }

            public class Qualification
            {
                /// <summary>
                /// 获取或设置图片 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public IList<string> MediaId { get; set; } = new List<string>();
            }

            public class AdditionalPicture : Qualification
            {
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
        public int OrganizationType { get; set; }

        /// <summary>
        /// 获取或设置营业执照信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_license_info")]
        [System.Text.Json.Serialization.JsonPropertyName("business_license_info")]
        public Types.BusinessLicense BusinessLicense { get; set; } = new Types.BusinessLicense();

        /// <summary>
        /// 获取或设置金融机构信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finance_institution_info")]
        [System.Text.Json.Serialization.JsonPropertyName("finance_institution_info")]
        public Types.FinanceInstitution? FinanceInstitution { get; set; }

        /// <summary>
        /// 获取或设置商户简称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_short_name")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_short_name")]
        public string MerchantShortName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置法人证件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_card_info")]
        [System.Text.Json.Serialization.JsonPropertyName("id_card_info")]
        public Types.IdCard IdCard { get; set; } = new Types.IdCard();

        /// <summary>
        /// 获取或设置法人是否为受益人。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner")]
        [System.Text.Json.Serialization.JsonPropertyName("owner")]
        public bool? IsOwner { get; set; }

        /// <summary>
        /// 获取或设置受益人证件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ubo_info")]
        [System.Text.Json.Serialization.JsonPropertyName("ubo_info")]
        public Types.UBO? UBO { get; set; }

        /// <summary>
        /// 获取或设置超级管理员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_info")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_info")]
        public Types.Contact Contact { get; set; } = new Types.Contact();

        /// <summary>
        /// 获取或设置结算账户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_info")]
        [System.Text.Json.Serialization.JsonPropertyName("account_info")]
        public Types.BankAccount BankAccount { get; set; } = new Types.BankAccount();

        /// <summary>
        /// 获取或设置经营范围 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_id")]
        [System.Text.Json.Serialization.JsonPropertyName("business_id")]
        public int BusinessId { get; set; }

        /// <summary>
        /// 获取或设置特殊资质信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualifications")]
        [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
        public Types.Qualification? Qualification { get; set; }

        /// <summary>
        /// 获取或设置补充材料信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_addition_pics")]
        [System.Text.Json.Serialization.JsonPropertyName("business_addition_pics")]
        public Types.AdditionalPicture? AdditionalPicture { get; set; }

        /// <summary>
        /// 获取或设置提现成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string? UserId { get; set; }
    }
}
