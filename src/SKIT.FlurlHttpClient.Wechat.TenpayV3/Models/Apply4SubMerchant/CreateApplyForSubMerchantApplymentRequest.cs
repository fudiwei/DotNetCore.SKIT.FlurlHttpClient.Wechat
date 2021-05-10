using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /applyment4sub/applyment 接口的请求。</para>
    /// </summary>
    public class CreateApplyForSubMerchantApplymentRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Contact
            {
                /// <summary>
                /// 获取或设置超级管理员姓名（需使用微信支付平台公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_name")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_name")]
                public string NameEncryptedData { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置联系人手机号（需使用微信支付平台公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile_phone")]
                public string MobileEncryptedData { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置超级管理员身份证号码（需使用微信支付平台公钥加密）。与字段 <see cref="OpenId"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_id_number")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_id_number")]
                public string? IdCardNumberEncryptedData { get; set; }

                /// <summary>
                /// 获取或设置超级管理员微信 OpenId。与字段 <see cref="IdCardNumberEncryptedData"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string? OpenId { get; set; }

                /// <summary>
                /// 获取或设置联系邮箱（需使用微信支付平台公钥加密）。与字段 <see cref="OpenId"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_email")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_email")]
                public string EmailEncryptedData { get; set; } = string.Empty;
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
                        [Newtonsoft.Json.JsonProperty("license_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("license_number")]
                        public string LicenceNumber { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置营业执照照片媒体文件标识 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("license_copy")]
                        [System.Text.Json.Serialization.JsonPropertyName("license_copy")]
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
                        /// 获取或设置商户名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
                        public string MerchantName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置注册地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("company_address")]
                        [System.Text.Json.Serialization.JsonPropertyName("company_address")]
                        public string CompanyAddress { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置法人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("legal_person")]
                        [System.Text.Json.Serialization.JsonPropertyName("legal_person")]
                        public string LegalPerson { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置有效期限开始日期（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("period_begin")]
                        [System.Text.Json.Serialization.JsonPropertyName("period_begin")]
                        public string PeriodBeginDate { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置有效期限结束日期（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("period_end")]
                        [System.Text.Json.Serialization.JsonPropertyName("period_end")]
                        public string PeriodEndDate { get; set; } = string.Empty;
                    }

                    public class OrganizationCertificate
                    {
                        /// <summary>
                        /// 获取或设置组织机构代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("organization_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("organization_code")]
                        public string OrganizationCode { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置组织机构代码证照片媒体文件标识 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("organization_copy")]
                        [System.Text.Json.Serialization.JsonPropertyName("organization_copy")]
                        public string OrganizationCopyMediaId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置组织机构代码证有效期开始日期（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("org_period_begin")]
                        [System.Text.Json.Serialization.JsonPropertyName("org_period_begin")]
                        public string PeriodBeginDate { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置组织机构代码证有效期结束日期（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("org_period_end")]
                        [System.Text.Json.Serialization.JsonPropertyName("org_period_end")]
                        public string PeriodEndDate { get; set; } = string.Empty;
                    }

                    public class Identity
                    {
                        public static class Types
                        {
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
                                /// 获取或设置身份证姓名（需使用微信支付平台公钥加密）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id_card_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("id_card_name")]
                                public string IdCardNameEncryptedData { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置身份证号码（需使用微信支付平台公钥加密）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id_card_number")]
                                [System.Text.Json.Serialization.JsonPropertyName("id_card_number")]
                                public string IdCardNumberEncryptedData { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置身份证有效期开始时间（格式：yyyy-MM-dd）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("card_period_begin")]
                                [System.Text.Json.Serialization.JsonPropertyName("card_period_begin")]
                                public string PeriodBeginDate { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置身份证有效期结束时间（格式：yyyy-MM-dd / "长期"）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("card_period_end")]
                                [System.Text.Json.Serialization.JsonPropertyName("card_period_end")]
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
                                /// 获取或设置证件姓名（需使用微信支付平台公钥加密）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id_doc_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("id_doc_name")]
                                public string IdDocumentNameEncryptedData { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置证件号码（需使用微信支付平台公钥加密）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id_doc_number")]
                                [System.Text.Json.Serialization.JsonPropertyName("id_doc_number")]
                                public string IdDocumentNumberEncryptedData { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置证件有效期开始时间（格式：yyyy-MM-dd）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("doc_period_begin")]
                                [System.Text.Json.Serialization.JsonPropertyName("doc_period_begin")]
                                public string PeriodBeginDate { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置证件有效期结束时间（格式：yyyy-MM-dd / "长期"）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("doc_period_end")]
                                [System.Text.Json.Serialization.JsonPropertyName("doc_period_end")]
                                public string PeriodEndDate { get; set; } = string.Empty;
                            }
                        }

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
                        /// 获取或设置法人是否为受益人。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("owner")]
                        [System.Text.Json.Serialization.JsonPropertyName("owner")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.StringTypedBooleanConverter))]
                        public bool IsOwner { get; set; }
                    }

                    public class UBO
                    {
                        /// <summary>
                        /// 获取或设置证件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_type")]
                        public string IdentityType { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置身份证人像面照片媒体文件标识 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_card_copy")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_card_copy")]
                        public string? IdCardFrontCopyMediaId { get; set; }

                        /// <summary>
                        /// 获取或设置身份证国徽面照片媒体文件标识 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_card_national")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_card_national")]
                        public string? IdCardBackCopyMediaId { get; set; }

                        /// <summary>
                        /// 获取或设置证件照片媒体文件标识 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_doc_copy")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_doc_copy")]
                        public string? IdDocumentCopyMediaId { get; set; }

                        /// <summary>
                        /// 获取或设置受益人姓名（需使用微信支付平台公钥加密）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string NameEncryptedData { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置证件号码（需使用微信支付平台公钥加密）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_number")]
                        public string IdNumberEncryptedData { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置证件有效期开始时间（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_period_begin")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_period_begin")]
                        public string IdPeriodBeginDate { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置证件有效期结束时间（格式：yyyy-MM-dd / "长期"）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_period_end")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_period_end")]
                        public string IdPeriodEndDate { get; set; } = string.Empty;
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
                [Newtonsoft.Json.JsonProperty("certificate_letter_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate_letter_copy")]
                public string? CertificateLetterCopyMediaId { get; set; }

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
                /// 获取或设置组织机构代码证信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("organization_info")]
                [System.Text.Json.Serialization.JsonPropertyName("organization_info")]
                public Types.OrganizationCertificate? OrganizationCertificate { get; set; }

                /// <summary>
                /// 获取或设置法人身份证件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identity_info")]
                [System.Text.Json.Serialization.JsonPropertyName("identity_info")]
                public Types.Identity Identity { get; set; } = new Types.Identity();

                /// <summary>
                /// 获取或设置最终受益人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ubo_info")]
                [System.Text.Json.Serialization.JsonPropertyName("ubo_info")]
                public Types.UBO? UBO { get; set; }
            }

            public class Business
            {
                public static class Types
                {
                    public class SaleScene
                    {
                        public static class Types
                        {
                            public class Store
                            {
                                /// <summary>
                                /// 获取或设置门店名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("biz_store_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("biz_store_name")]
                                public string StoreName { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置门店省市编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("biz_address_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("biz_address_code")]
                                public string StoreAddressCode { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置门店地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("biz_store_address")]
                                [System.Text.Json.Serialization.JsonPropertyName("biz_store_address")]
                                public string StoreAddress { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置门店门头照片媒体文件标识 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("store_entrance_pic")]
                                [System.Text.Json.Serialization.JsonPropertyName("store_entrance_pic")]
                                public IList<string> StoreEntrancePictureMediaIdList { get; set; } = new List<string>();

                                /// <summary>
                                /// 获取或设置店内环境照片媒体文件标识 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("indoor_pic")]
                                [System.Text.Json.Serialization.JsonPropertyName("indoor_pic")]
                                public IList<string> StoreIndoorPictureMediaIdList { get; set; } = new List<string>();

                                /// <summary>
                                /// 获取或设置线下场所对应的商家 AppId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("biz_sub_appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("biz_sub_appid")]
                                public string? SubAppId { get; set; }
                            }

                            public class MediaPlatform
                            {
                                /// <summary>
                                /// 获取或设置服务商公众号 AppId。与字段 <see cref="SubAppId"/> 二选一。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mp_appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("mp_appid")]
                                public string? AppId { get; set; }

                                /// <summary>
                                /// 获取或设置商家公众号 AppId。与字段 <see cref="AppId"/> 二选一。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mp_sub_appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("mp_sub_appid")]
                                public string? SubAppId { get; set; }

                                /// <summary>
                                /// 获取或设置公众号页面截图媒体文件标识 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mp_pics")]
                                [System.Text.Json.Serialization.JsonPropertyName("mp_pics")]
                                public IList<string>? PictureMediaIdList { get; set; }
                            }

                            public class MiniProgram
                            {
                                /// <summary>
                                /// 获取或设置服务商小程序 AppId。与字段 <see cref="SubAppId"/> 二选一。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mini_program_appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("mini_program_appid")]
                                public string? AppId { get; set; }

                                /// <summary>
                                /// 获取或设置商家小程序 AppId。与字段 <see cref="AppId"/> 二选一。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mini_program_sub_appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("mini_program_sub_appid")]
                                public string? SubAppId { get; set; }

                                /// <summary>
                                /// 获取或设置小程序页面截图媒体文件标识 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mini_program_pics")]
                                [System.Text.Json.Serialization.JsonPropertyName("mini_program_pics")]
                                public IList<string>? PictureMediaIdList { get; set; }
                            }

                            public class App
                            {
                                /// <summary>
                                /// 获取或设置服务商应用 AppId。与字段 <see cref="SubAppId"/> 二选一。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("app_appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("app_appid")]
                                public string? AppId { get; set; }

                                /// <summary>
                                /// 获取或设置商家应用 AppId。与字段 <see cref="AppId"/> 二选一。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("app_sub_appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("app_sub_appid")]
                                public string? SubAppId { get; set; }

                                /// <summary>
                                /// 获取或设置应用页面截图媒体文件标识 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("app_pics")]
                                [System.Text.Json.Serialization.JsonPropertyName("app_pics")]
                                public IList<string>? PictureMediaIdList { get; set; }
                            }

                            public class Web
                            {
                                /// <summary>
                                /// 获取或设置网站域名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("domain")]
                                [System.Text.Json.Serialization.JsonPropertyName("domain")]
                                public string Domain { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置网站授权函媒体文件标识 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("web_authorisation")]
                                [System.Text.Json.Serialization.JsonPropertyName("web_authorisation")]
                                public string? AuthorizationCopyMediaId { get; set; }

                                /// <summary>
                                /// 获取或设置互联网网站对应的商家 AppId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("web_appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("web_appid")]
                                public string? AppId { get; set; }
                            }

                            public class Wework
                            {
                                /// <summary>
                                /// 获取或设置商家企业微信 CorpID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("corp_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("corp_id")]
                                public string? CorpId { get; set; }

                                /// <summary>
                                /// 获取或设置商家企业微信 CorpID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sub_corp_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sub_corp_id")]
                                public string? SubCorpId { get; set; }

                                /// <summary>
                                /// 获取或设置企业微信页面截图媒体文件标识 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("wework_pics")]
                                [System.Text.Json.Serialization.JsonPropertyName("wework_pics")]
                                public IList<string>? PictureMediaIdList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置经营场景类型列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sales_scenes_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("sales_scenes_type")]
                        public IList<string> SaleSceneTypeList { get; set; } = new List<string>();

                        /// <summary>
                        /// 获取或设置线下门店场景信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("biz_store_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("biz_store_info")]
                        public Types.Store? Store { get; set; }

                        /// <summary>
                        /// 获取或设置公众号场景信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_info")]
                        public Types.MediaPlatform? MediaPlatform { get; set; }

                        /// <summary>
                        /// 获取或设置小程序场景信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mini_program_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("mini_program_info")]
                        public Types.MiniProgram? MiniProgram { get; set; }

                        /// <summary>
                        /// 获取或设置 App 场景信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_info")]
                        public Types.App? App { get; set; }

                        /// <summary>
                        /// 获取或设置互联网网站场景信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("web_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("web_info")]
                        public Types.Web? Web { get; set; }

                        /// <summary>
                        /// 获取或设置企业微信场景信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wework_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("wework_info")]
                        public Types.Wework? Wework { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商户简称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_shortname")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_shortname")]
                public string MerchantShortName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置客服电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("service_phone")]
                public string ServicePhone { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置经营场景信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sales_info")]
                [System.Text.Json.Serialization.JsonPropertyName("sales_info")]
                public Types.SaleScene SaleScene { get; set; } = new Types.SaleScene();
            }

            public class Settlement
            {
                /// <summary>
                /// 获取或设置入驻结算规则 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settlement_id")]
                [System.Text.Json.Serialization.JsonPropertyName("settlement_id")]
                public string SettlementId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置所属行业。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification_type")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification_type")]
                public string QualificationType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置特殊资质图片媒体文件标识 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualifications")]
                [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
                public IList<string>? QualificationPictureMediaIdList { get; set; }

                /// <summary>
                /// 获取或设置优惠费率活动 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activities_id")]
                [System.Text.Json.Serialization.JsonPropertyName("activities_id")]
                public string? ActivityId { get; set; }

                /// <summary>
                /// 获取或设置优惠费率活动值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activities_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("activities_rate")]
                public double? ActivityRate { get; set; }

                /// <summary>
                /// 获取或设置优惠费率活动补充材料媒体文件标识 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activities_additions")]
                [System.Text.Json.Serialization.JsonPropertyName("activities_additions")]
                public IList<string>? ActivityAdditionMediaIdList { get; set; }
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
                /// 获取或设置开户名称（需使用微信支付平台公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("account_name")]
                public string AccountNameEncryptedData { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置银行账号（需使用微信支付平台公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_number")]
                [System.Text.Json.Serialization.JsonPropertyName("account_number")]
                public string AccountNumberEncryptedData { get; set; } = string.Empty;

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
                /// 获取或设置开户开户银行全称（含支行）。与字段 <see cref="BankBranchId"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                public string? BankBranchName { get; set; }
            }

            public class Addition
            {
                /// <summary>
                /// 获取或设置法人开户承诺函媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_person_commitment")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_person_commitment")]
                public string? LegalPermsonCommitmentMediaId { get; set; }

                /// <summary>
                /// 获取或设置法人开户意愿视频媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_person_video")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_person_video")]
                public string? LegalPermsonVideoMediaId { get; set; }

                /// <summary>
                /// 获取或设置补充材料媒体文件标识 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_addition_pics")]
                [System.Text.Json.Serialization.JsonPropertyName("business_addition_pics")]
                public IList<string>? BusinessAdditionPictureMediaIdList { get; set; }

                /// <summary>
                /// 获取或设置补充说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_addition_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("business_addition_msg")]
                public string? BusinessAdditionMessage { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置业务申请编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_code")]
        [System.Text.Json.Serialization.JsonPropertyName("business_code")]
        public string BusinessCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置超级管理员信息。
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
        /// 获取或设置经营资料信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_info")]
        [System.Text.Json.Serialization.JsonPropertyName("business_info")]
        public Types.Business Business { get; set; } = new Types.Business();

        /// <summary>
        /// 获取或设置结算规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_info")]
        [System.Text.Json.Serialization.JsonPropertyName("settlement_info")]
        public Types.Settlement Settlement { get; set; } = new Types.Settlement();

        /// <summary>
        /// 获取或设置银行账户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_account_info")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_account_info")]
        public Types.BankAccount BankAccount { get; set; } = new Types.BankAccount();

        /// <summary>
        /// 获取或设置补充材料信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addition_info")]
        [System.Text.Json.Serialization.JsonPropertyName("addition_info")]
        public Types.Addition? Addition { get; set; }
    }
}
