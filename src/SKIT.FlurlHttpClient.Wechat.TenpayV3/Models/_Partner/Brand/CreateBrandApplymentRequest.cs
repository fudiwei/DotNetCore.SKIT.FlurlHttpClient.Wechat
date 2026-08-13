using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /brand/applyments 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateBrandApplymentRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Administrator
            {
                /// <summary>
                /// 获取或设置管理员姓名（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("admin_name")]
                [System.Text.Json.Serialization.JsonPropertyName("admin_name")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string AdminName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置管理员证件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_doc_type")]
                [System.Text.Json.Serialization.JsonPropertyName("id_doc_type")]
                public string IdentityType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置管理员证件号码（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_number")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_number")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string IdCardNumber { get; set; } = string.Empty;
            }

            public class Subject
            {
                /// <summary>
                /// 获取或设置主体类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subject_type")]
                [System.Text.Json.Serialization.JsonPropertyName("subject_type")]
                public string SubjectType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置主体名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subject_name")]
                [System.Text.Json.Serialization.JsonPropertyName("subject_name")]
                public string SubjectName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置统一社会信用代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unified_social_credit_code")]
                [System.Text.Json.Serialization.JsonPropertyName("unified_social_credit_code")]
                public string UnifiedSocialCreditCode { get; set; } = string.Empty;
            }

            public class BrandBasic
            {
                /// <summary>
                /// 获取或设置品牌名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_name")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_name")]
                public string BrandName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置品牌 Logo MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_logo")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_logo")]
                public string BrandLogoMediaId { get; set; } = string.Empty;
            }

            public class Trademark
            {
                public static class Types
                {
                    public class TrademarkRegistrationCertificate
                    {
                        /// <summary>
                        /// 获取或设置商标注册证 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate")]
                        public string? CertificateMediaId { get; set; }

                        /// <summary>
                        /// 获取或设置商标注册证 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_list")]
                        public IList<string>? CertificateMediaIdList { get; set; }

                        /// <summary>
                        /// 获取或设置商标名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商标注册号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("number")]
                        [System.Text.Json.Serialization.JsonPropertyName("number")]
                        public string Number { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商标有效期开始日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_begin_time")]
                        public string? ValidBeginDateString { get; set; }

                        /// <summary>
                        /// 获取或设置商标有效期结束日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_end_time")]
                        public string? ValidEndDateString { get; set; }

                        /// <summary>
                        /// 获取或设置商标国际分类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("international_class")]
                        [System.Text.Json.Serialization.JsonPropertyName("international_class")]
                        public string InternationalClass { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商标持有人。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("holder")]
                        [System.Text.Json.Serialization.JsonPropertyName("holder")]
                        public string Holder { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商标授权许可使用授权书 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("license")]
                        [System.Text.Json.Serialization.JsonPropertyName("license")]
                        public string? AuthorizationLicenseMediaId { get; set; }

                        /// <summary>
                        /// 获取或设置商标授权许可使用授权书 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("license_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("license_list")]
                        public IList<string>? AuthorizationLicenseMediaIdList { get; set; }

                        /// <summary>
                        /// 获取或设置商标授权有效期开始日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("authorization_begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("authorization_begin_time")]
                        public string? AuthorizationBeginDateString { get; set; }

                        /// <summary>
                        /// 获取或设置商标授权有效期结束日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("authorization_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("authorization_end_time")]
                        public string? AuthorizationEndDateString { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置有无商标类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trademark_exists")]
                [System.Text.Json.Serialization.JsonPropertyName("trademark_exists")]
                public string TrademarkExistsType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置无商标额外证明材料 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("no_trademark_addition_prove")]
                [System.Text.Json.Serialization.JsonPropertyName("no_trademark_addition_prove")]
                public string? NoTrademarkAdditionalProveMediaId { get; set; }

                /// <summary>
                /// 获取或设置商标注册证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trademark_registration_certificate")]
                [System.Text.Json.Serialization.JsonPropertyName("trademark_registration_certificate")]
                public Types.TrademarkRegistrationCertificate? TrademarkRegistrationCertificate { get; set; }

                /// <summary>
                /// 获取或设置 Logo 商标注册证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logo_trademark_registration_certificate")]
                [System.Text.Json.Serialization.JsonPropertyName("logo_trademark_registration_certificate")]
                public Types.TrademarkRegistrationCertificate? LogoTrademarkRegistrationCertificate { get; set; }

                /// <summary>
                /// 获取或设置无商标额外证明材料 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("no_trademark_addition_prove_list")]
                [System.Text.Json.Serialization.JsonPropertyName("no_trademark_addition_prove_list")]
                public IList<string>? NoTrademarkAdditionalProveMediaIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置业务申请编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_code")]
        [System.Text.Json.Serialization.JsonPropertyName("business_code")]
        public string BusinessCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置管理员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admin_info")]
        [System.Text.Json.Serialization.JsonPropertyName("admin_info")]
        public Types.Administrator Administrator { get; set; } = new Types.Administrator();

        /// <summary>
        /// 获取或设置主体信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subject_info")]
        [System.Text.Json.Serialization.JsonPropertyName("subject_info")]
        public Types.Subject Subject { get; set; } = new Types.Subject();

        /// <summary>
        /// 获取或设置品牌基础信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_basic_info")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_basic_info")]
        public Types.BrandBasic BrandBasic { get; set; } = new Types.BrandBasic();

        /// <summary>
        /// 获取或设置品牌商标资料信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trademark")]
        [System.Text.Json.Serialization.JsonPropertyName("trademark")]
        public Types.Trademark Trademark { get; set; } = new Types.Trademark();
    }
}
