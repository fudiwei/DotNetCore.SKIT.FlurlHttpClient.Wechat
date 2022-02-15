using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/register/submit_merchantinfo 接口的请求。</para>
    /// </summary>
    public class ProductRegisterSubmitMerchantInfoRequest : WechatApiRequest, IMapResponse<ProductRegisterSubmitMerchantInfoRequest, ProductRegisterSubmitMerchantInfoResponse>
    {
        public static class Types
        {
            public class PictureFile
            {
                /// <summary>
                /// 获取或设置 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string MediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置支付专用 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_media_id")]
                public string PayMediaId { get; set; } = string.Empty;
            }

            public class BusinessLicense
            {
                /// <summary>
                /// 获取或设置营业执照类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("license_type")]
                [System.Text.Json.Serialization.JsonPropertyName("license_type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置营业执照上注册号或统一社会信用代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("registration_num")]
                [System.Text.Json.Serialization.JsonPropertyName("registration_num")]
                public string LicenceNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置营业执照图片信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pic_file")]
                [System.Text.Json.Serialization.JsonPropertyName("pic_file")]
                public PictureFile LicensePictureFile { get; set; } = new PictureFile();

                /// <summary>
                /// 获取或设置商户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_name")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
                public string MerchantName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置法定代表人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_representative")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_representative")]
                public string LegalPersion { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置注册地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("registered_addrs")]
                [System.Text.Json.Serialization.JsonPropertyName("registered_addrs")]
                public string? Address { get; set; }

                /// <summary>
                /// 获取或设置有效期限开始日期（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_date")]
                [System.Text.Json.Serialization.JsonPropertyName("start_date")]
                public string PeriodBeginDate { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置有效期限结束日期（格式：yyyy-MM-dd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_date")]
                [System.Text.Json.Serialization.JsonPropertyName("end_date")]
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
                /// 获取或设置组织机构图片信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pic_file")]
                [System.Text.Json.Serialization.JsonPropertyName("pic_file")]
                public PictureFile OrganizationPictureFile { get; set; } = new PictureFile();

                /// <summary>
                /// 获取或设置有效期限开始日期（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_date")]
                [System.Text.Json.Serialization.JsonPropertyName("start_date")]
                public string PeriodBeginDate { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置有效期限结束日期（格式：yyyy-MM-dd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_date")]
                [System.Text.Json.Serialization.JsonPropertyName("end_date")]
                public string PeriodEndDate { get; set; } = string.Empty;
            }

            public class IdCard
            {
                /// <summary>
                /// 获取或设置身份证人像面照片信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("portrait_pic_file")]
                [System.Text.Json.Serialization.JsonPropertyName("portrait_pic_file")]
                public PictureFile IdCardFrontPictureFile { get; set; } = new PictureFile();

                /// <summary>
                /// 获取或设置身份证人像面照片信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nation_pic_file")]
                [System.Text.Json.Serialization.JsonPropertyName("nation_pic_file")]
                public PictureFile IdCardBackPictureFile { get; set; } = new PictureFile();

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
                /// 获取或设置身份证有效期开始时间（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_date")]
                [System.Text.Json.Serialization.JsonPropertyName("start_date")]
                public string PeriodBeginDate { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证有效期结束时间（格式：yyyy-MM-dd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_date")]
                [System.Text.Json.Serialization.JsonPropertyName("end_date")]
                public string PeriodEndDate { get; set; } = string.Empty;
            }

            public class Administrator
            {
                /// <summary>
                /// 获取或设置管理员类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置管理员姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置管理员身份证号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_number")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_number")]
                public string IdCardNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置管理员手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                public string MobileNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置管理员邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mail")]
                [System.Text.Json.Serialization.JsonPropertyName("mail")]
                public string Email { get; set; } = string.Empty;
            }

            public class Qualification
            {
                /// <summary>
                /// 获取或设置特殊资质图片列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pic_file_list")]
                [System.Text.Json.Serialization.JsonPropertyName("pic_file_list")]
                public IList<PictureFile> PictureFileList { get; set; } = new List<PictureFile>();
            }
            
            public class Supplementary
            {
                /// <summary>
                /// 获取或设置补充材料图片列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pic_file_list")]
                [System.Text.Json.Serialization.JsonPropertyName("pic_file_list")]
                public IList<PictureFile> PictureFileList { get; set; } = new List<PictureFile>();
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置主体类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subject_type")]
        [System.Text.Json.Serialization.JsonPropertyName("subject_type")]
        public int SubjectType { get; set; }

        /// <summary>
        /// 获取或设置商户简称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_shortname")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_shortname")]
        public string MerchantShortName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置营业执照或登记证书信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("busi_license")]
        [System.Text.Json.Serialization.JsonPropertyName("busi_license")]
        public Types.BusinessLicense? BusinessLicense { get; set; }

        /// <summary>
        /// 获取或设置组织机构代码证信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organization_code_info")]
        [System.Text.Json.Serialization.JsonPropertyName("organization_code_info")]
        public Types.OrganizationCertificate? OrganizationCertificate { get; set; }

        /// <summary>
        /// 获取或设置身份证信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_card_info")]
        [System.Text.Json.Serialization.JsonPropertyName("id_card_info")]
        public Types.IdCard IdCard { get; set; } = new Types.IdCard();

        /// <summary>
        /// 获取或设置超级管理员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("super_administrator_info")]
        [System.Text.Json.Serialization.JsonPropertyName("super_administrator_info")]
        public Types.Administrator Administrator { get; set; } = new Types.Administrator();

        /// <summary>
        /// 获取或设置特殊资质信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("special_qualification")]
        [System.Text.Json.Serialization.JsonPropertyName("special_qualification")]
        public Types.Qualification? Qualification { get; set; }

        /// <summary>
        /// 获取或设置补充材料信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplementary_material")]
        [System.Text.Json.Serialization.JsonPropertyName("supplementary_material")]
        public Types.Supplementary? SupplementaryMaterial { get; set; }

        /// <summary>
        /// 获取或设置补充描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplementary_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("supplementary_desc")]
        public string? SupplementaryDescription { get; set; }
    }
}
