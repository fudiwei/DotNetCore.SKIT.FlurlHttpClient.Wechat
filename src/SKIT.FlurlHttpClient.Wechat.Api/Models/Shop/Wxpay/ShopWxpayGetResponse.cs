using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/wxpay/get 接口的响应。</para>
    /// </summary>
    public class ShopWxpayGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class PayRequest
            {
                public static class Types
                {
                    public class BusinessLicense
                    {
                        /// <summary>
                        /// 获取或设置法定代表人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("legal_person")]
                        [System.Text.Json.Serialization.JsonPropertyName("legal_person")]
                        public string LegalPerson { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商户名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
                        public string MerchantName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置营业执照编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("business_license_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("business_license_number")]
                        public string BusinessLicenseNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置营业执照图片 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("business_license_copy")]
                        [System.Text.Json.Serialization.JsonPropertyName("business_license_copy")]
                        public string BusinessLicenseCopyMediaId { get; set; } = default!;
                    }

                    public class IdCard
                    {
                        /// <summary>
                        /// 获取或设置身份证姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_card_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_card_name")]
                        public string IdCardName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置身份证号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_card_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_card_number")]
                        public string IdCardNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置身份证有效期字符串（格式：yyyy-MM-dd / "长期"）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_card_valid_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_card_valid_time")]
                        public string IdCardValidDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置身份证人像面图片 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_card_copy")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_card_copy")]
                        public string IdCardFrontCopyMediaId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置身份证国徽面图片 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_card_national")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_card_national")]
                        public string IdCardBackCopyMediaId { get; set; } = default!;
                    }

                    public class IdDocument
                    {
                        /// <summary>
                        /// 获取或设置证件姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_doc_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_doc_name")]
                        public string IdDocumentName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置证件号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_doc_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_doc_number")]
                        public string IdDocumentNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置证件有效期结束时间字符串（格式：yyyy-MM-dd / "长期"）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("doc_period_end")]
                        [System.Text.Json.Serialization.JsonPropertyName("doc_period_end")]
                        public string IdDocumentPeriodEndDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置证件图片 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_doc_copy")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_doc_copy")]
                        public string IdDocumentCopyMediaId { get; set; } = default!;

                    }

                    public class Contact
                    {
                        /// <summary>
                        /// 获取或设置联系人类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contact_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("contact_type")]
                        public string ContactType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置联系人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contact_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("contact_name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置联系人身份证号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contact_id_card_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("contact_id_card_number")]
                        public string IdCardNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置电子邮箱。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contact_email")]
                        [System.Text.Json.Serialization.JsonPropertyName("contact_email")]
                        public string Email { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置手机号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mobile_phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("mobile_phone")]
                        public string MobileNumber { get; set; } = default!;
                    }

                    public class SaleScene
                    {
                        /// <summary>
                        /// 获取或设置店铺名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("store_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("store_name")]
                        public string? StoreName { get; set; }

                        /// <summary>
                        /// 获取或设置店铺链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("store_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("store_url")]
                        public string? StoreUrl { get; set; }

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
                public string OutRequestNumber { get; set; } = default!;

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
                public string IdentityType { get; set; } = default!;

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
                public Types.Contact Contact { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户简称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_shortname")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_shortname")]
                public string? MerchantShortName { get; set; }

                /// <summary>
                /// 获取或设置是否填写结算银行账户。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_account_info")]
                [System.Text.Json.Serialization.JsonPropertyName("need_account_info")]
                public bool RequireBankAccount { get; set; }

                /// <summary>
                /// 获取或设置销售场景信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sales_scene_info")]
                [System.Text.Json.Serialization.JsonPropertyName("sales_scene_info")]
                public Types.SaleScene? SaleScene { get; set; }
            }

            public class PayResponse
            {
                public static class Types
                {
                    public class AccountValidation
                    {
                        /// <summary>
                        /// 获取或设置付款户名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_name")]
                        public string AccountName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置付款卡号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_no")]
                        public string? AccountNumber { get; set; }

                        /// <summary>
                        /// 获取或设置汇款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                        public int PayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置收款户名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("destination_account_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("destination_account_name")]
                        public string DestinationAccountName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收款卡号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("destination_account_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("destination_account_number")]
                        public string DestinationAccountNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收款开户银行。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("destination_account_bank")]
                        [System.Text.Json.Serialization.JsonPropertyName("destination_account_bank")]
                        public string DestinationAccountBank { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收款省市信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city")]
                        [System.Text.Json.Serialization.JsonPropertyName("city")]
                        public string DestinationAccountCity { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置备注信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remark")]
                        [System.Text.Json.Serialization.JsonPropertyName("remark")]
                        public string Remark { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置汇款截止时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("deadline")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("deadline")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset Deadline { get; set; }
                    }

                    public class AuditDetail
                    {
                        /// <summary>
                        /// 获取或设置参数名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("param_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("param_name")]
                        public string ParameterName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置驳回原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                        public string RejectReason { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置业务申请编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_request_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
                public string OutRequestNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请单编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applyment_id")]
                [System.Text.Json.Serialization.JsonPropertyName("applyment_id")]
                public long ApplymentId { get; set; }

                /// <summary>
                /// 获取或设置申请单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applyment_state")]
                [System.Text.Json.Serialization.JsonPropertyName("applyment_state")]
                public string ApplymentState { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请单状态描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applyment_state_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("applyment_state_desc")]
                public string ApplymentStateDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信二级商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
                public string? SubMerchantId { get; set; }

                /// <summary>
                /// 获取或设置签约状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sign_state")]
                [System.Text.Json.Serialization.JsonPropertyName("sign_state")]
                public string? SignState { get; set; }

                /// <summary>
                /// 获取或设置超级管理员签约链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sign_url")]
                [System.Text.Json.Serialization.JsonPropertyName("sign_url")]
                public string? SignUrl { get; set; }

                /// <summary>
                /// 获取或设置汇款账户验证信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_validation")]
                [System.Text.Json.Serialization.JsonPropertyName("account_validation")]
                public Types.AccountValidation? AccountValidation { get; set; }

                /// <summary>
                /// 获取或设置法人验证链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_validation_url")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_validation_url")]
                public string? LegalPersonValidationUrl { get; set; }

                /// <summary>
                /// 获取或设置驳回原因详情列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_detail")]
                public Types.AuditDetail[]? AuditList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置进件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_req")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_req")]
        public Types.PayRequest PayRequest { get; set; } = default!;

        /// <summary>
        /// 获取或设置进件状态信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_resp")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_resp")]
        public Types.PayResponse PayResponse { get; set; } = default!;
    }
}
