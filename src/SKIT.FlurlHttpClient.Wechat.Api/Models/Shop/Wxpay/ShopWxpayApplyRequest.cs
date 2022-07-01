using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/wxpay/apply 接口的请求。</para>
    /// </summary>
    public class ShopWxpayApplyRequest : WechatApiRequest, IInferable<ShopWxpayApplyRequest, ShopWxpayApplyResponse>
    {
        public static class Types
        {
            public class Image
            {
                /// <summary>
                /// 获取或设置图片名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置图片 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string? MediaId { get; set; }

                /// <summary>
                /// 获取或设置图片 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_media_id")]
                public string? PayMediaId { get; set; }
            }

            public class BusinessLicense
            {
                /// <summary>
                /// 获取或设置法定代表人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_person")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_person")]
                public string LegalPerson { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置有效期范围字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_time")]
                [System.Text.Json.Serialization.JsonPropertyName("business_time")]
                public string ValidPeriodString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置营业执照图片信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxa_business_license_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("wxa_business_license_copy")]
                public Image BusinessLicenseCopy { get; set; } = new Image();
            }

            public class IdCard
            {
                /// <summary>
                /// 获取或设置身份证姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_name")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_name")]
                public string IdCardName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_number")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_number")]
                public string IdCardNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证有效期字符串（格式：yyyy-MM-dd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_valid_time")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_valid_time")]
                public string IdCardValidDateString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证人像面图片信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxa_id_card_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("wxa_id_card_copy")]
                public Image IdCardFrontCopy { get; set; } = new Image();

                /// <summary>
                /// 获取或设置身份证国徽面图片信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxa_id_card_national")]
                [System.Text.Json.Serialization.JsonPropertyName("wxa_id_card_national")]
                public Image IdCardBackCopy { get; set; } = new Image();
            }

            public class IdDocument
            {
                /// <summary>
                /// 获取或设置证件姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_doc_name")]
                [System.Text.Json.Serialization.JsonPropertyName("id_doc_name")]
                public string IdDocumentName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_doc_number")]
                [System.Text.Json.Serialization.JsonPropertyName("id_doc_number")]
                public string IdDocumentNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件有效期结束时间字符串（格式：yyyy-MM-dd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("doc_period_end")]
                [System.Text.Json.Serialization.JsonPropertyName("doc_period_end")]
                public string IdDocumentPeriodEndDateString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件图片信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxa_id_doc_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("wxa_id_doc_copy")]
                public Image IdDocumentCopy { get; set; } = new Image();

            }

            public class Contact
            {
                /// <summary>
                /// 获取或设置联系人类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_type")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_type")]
                public string ContactType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置电子邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_email")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_email")]
                public string Email { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile_phone")]
                public string MobileNumber { get; set; } = string.Empty;
            }

            public class BankAccount
            {
                public static class Types
                {
                    public class AccountCertificate
                    {
                        /// <summary>
                        /// 获取或设置结算证明函图片信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wxa_settlement_cert_pic")]
                        [System.Text.Json.Serialization.JsonPropertyName("wxa_settlement_cert_pic")]
                        public Image SettlementCertificatePicture { get; set; } = new Image();

                        /// <summary>
                        /// 获取或设置结算证明函图片信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wxa_relation_cert_pic")]
                        [System.Text.Json.Serialization.JsonPropertyName("wxa_relation_cert_pic")]
                        public Image RelationCertificatePicture { get; set; } = new Image();

                        /// <summary>
                        /// 获取或设置其他补充证明图片信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wxa_other_cert_pics")]
                        [System.Text.Json.Serialization.JsonPropertyName("wxa_other_cert_pics")]
                        public IList<Image> OtherCertificatePictureList { get; set; } = new List<Image>();
                    }
                }

                /// <summary>
                /// 获取或设置账户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_type")]
                public string AccountType { get; set; } = string.Empty;

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

                /// <summary>
                /// 获取或设置账号证明材料信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_cert_info")]
                [System.Text.Json.Serialization.JsonPropertyName("account_cert_info")]
                public Types.AccountCertificate? AccountCertificate { get; set; }
            }


            public class Qualification
            {
                /// <summary>
                /// 获取或设置图片列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pic_file_list")]
                [System.Text.Json.Serialization.JsonPropertyName("pic_file_list")]
                public IList<Image> ImageList { get; set; } = new List<Image>();
            }

            public class Addition : Qualification
            {
            }
        }

        /// <summary>
        /// 获取或设置主体类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organization_type")]
        [System.Text.Json.Serialization.JsonPropertyName("organization_type")]
        public int SubjectType { get; set; }

        /// <summary>
        /// 获取或设置营业执照信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_license_info")]
        [System.Text.Json.Serialization.JsonPropertyName("business_license_info")]
        public Types.BusinessLicense BusinessLicense { get; set; } = new Types.BusinessLicense();

        /// <summary>
        /// 获取或设置证件类型。
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
        /// 获取或设置联系人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_info")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_info")]
        public Types.Contact Contact { get; set; } = new Types.Contact();

        /// <summary>
        /// 获取或设置结算银行账户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_info")]
        [System.Text.Json.Serialization.JsonPropertyName("account_info")]
        public Types.BankAccount BankAccount { get; set; } = new Types.BankAccount();

        /// <summary>
        /// 获取或设置商户简称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_shortname")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_shortname")]
        public string? MerchantShortName { get; set; }

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
        public Types.Addition? Addition { get; set; }

        /// <summary>
        /// 获取或设置补充描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_addition_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("business_addition_desc")]
        public string? AdditionDescription { get; set; }
    }
}
