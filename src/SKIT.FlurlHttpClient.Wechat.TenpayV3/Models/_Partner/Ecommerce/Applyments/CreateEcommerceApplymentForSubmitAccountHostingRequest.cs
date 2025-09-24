using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/applyments/submit-account-hosting-applyment 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateEcommerceApplymentForSubmitAccountHostingRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class BusinessLicense : CreateEcommerceApplymentRequest.Types.BusinessLicense
            {
            }

            public class FinanceInstitutionLicense : CreateEcommerceApplymentRequest.Types.FinanceInstitutionLicense
            {
            }

            public class IdCard : CreateEcommerceApplymentRequest.Types.IdCard
            {
            }

            public class IdDocument : CreateEcommerceApplymentRequest.Types.IdDocument
            {
            }

            public class Contact : CreateEcommerceApplymentRequest.Types.Contact
            {
            }

            public class UBO : CreateEcommerceApplymentRequest.Types.UBO
            {
            }
            public class BankAccount : CreateEcommerceApplymentRequest.Types.BankAccount
            {
            }

            public class SaleScene : CreateEcommerceApplymentRequest.Types.SaleScene
            {
            }

            public class Settlement : CreateEcommerceApplymentRequest.Types.Settlement
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
        /// 获取或设置商户简称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_shortname")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_shortname")]
        public string MerchantShortName { get; set; } = string.Empty;

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
        /// 获取或设置金融机构许可证信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finance_institution_info")]
        [System.Text.Json.Serialization.JsonPropertyName("finance_institution_info")]
        public Types.FinanceInstitutionLicense? FinanceInstitutionLicense { get; set; }

        /// <summary>
        /// 获取或设置证件持有人类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_holder_type")]
        [System.Text.Json.Serialization.JsonPropertyName("id_holder_type")]
        public string? IdHolderType { get; set; }

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
        /// 获取或设置法人代表授权函媒体文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorize_letter_copy")]
        [System.Text.Json.Serialization.JsonPropertyName("authorize_letter_copy")]
        public string? AuthorizeLetterCopyMediaId { get; set; }

        /// <summary>
        /// 获取或设置最终受益人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ubo_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("ubo_info_list")]
        public IList<Types.UBO>? UBOList { get; set; }

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
        /// 获取或设置结算规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_info")]
        [System.Text.Json.Serialization.JsonPropertyName("settlement_info")]
        public Types.Settlement? Settlement { get; set; }

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

        /// <summary>
        /// 获取或设置是否走平台代理签约和代理核身入驻模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("proxy_sign_verify_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("proxy_sign_verify_mode")]
        public bool IsProxySignVerifyMode { get; set; }
    }
}
