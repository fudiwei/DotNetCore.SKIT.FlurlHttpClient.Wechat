using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/product-applications 接口的请求。</para>
    /// </summary>
    [WechatTenpayBusinessSensitive]
    public class CreateProductApplicationRequest : WechatTenpayBusinessRequest
    {
        public static class Types
        {
            public class BusinessLicense
            {
                /// <summary>
                /// 获取或设置工商注册类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_register_type")]
                [System.Text.Json.Serialization.JsonPropertyName("business_register_type")]
                public string BusinessRegisterType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置统一社会信用证代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unified_social_credit_code")]
                [System.Text.Json.Serialization.JsonPropertyName("unified_social_credit_code")]
                public string UnifiedSocialCreditCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_name")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
                public string MerchantName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商户简称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_short_name")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_short_name")]
                public string MerchantShortName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置法人姓名（需使用微企付公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_person_name")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_person_name")]
                [WechatTenpayBusinessSensitiveProperty]
                public string LegalPersonName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置营业期限（格式：["yyyy-MM-dd", "yyyy-MM-dd"]，长期用 "长期" 表示）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("validity_period")]
                [System.Text.Json.Serialization.JsonPropertyName("validity_period")]
                public IList<string> ValidityPeriodStrings { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置营业执照照片 FileId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("photocopy_file_id")]
                [System.Text.Json.Serialization.JsonPropertyName("photocopy_file_id")]
                public string PhotoCopyFileId { get; set; } = string.Empty;
            }

            public class IdCard
            {
                /// <summary>
                /// 获取或设置身份证姓名（需使用微企付公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                [WechatTenpayBusinessSensitiveProperty]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证号码（需使用微企付公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("number")]
                [System.Text.Json.Serialization.JsonPropertyName("number")]
                [WechatTenpayBusinessSensitiveProperty]
                public string IdNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证期限（格式：["yyyy-MM-dd", "yyyy-MM-dd"]，长期用 "长期" 表示）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("validity_period")]
                [System.Text.Json.Serialization.JsonPropertyName("validity_period")]
                public IList<string> ValidityPeriodStrings { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置身份证人像面照片 FileId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("front_photocopy_file_id")]
                [System.Text.Json.Serialization.JsonPropertyName("front_photocopy_file_id")]
                public string FrontPhotoCopyFileId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证国徽面照片 FileId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("back_photocopy_file_id")]
                [System.Text.Json.Serialization.JsonPropertyName("back_photocopy_file_id")]
                public string BackPhotoCopyFileId { get; set; } = string.Empty;
            }

            public class Contact
            {
                /// <summary>
                /// 获取或设置联系人手机号（需使用微企付公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile_number")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile_number")]
                [WechatTenpayBusinessSensitiveProperty]
                public string MobileNumber { get; set; } = string.Empty;
            }

            public class PayeeAccount
            {
                /// <summary>
                /// 获取或设置账户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                public string AccountType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开户名称（需使用微企付公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_name")]
                [WechatTenpayBusinessSensitiveProperty]
                public string BankAccountName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置银行账号（需使用微企付公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_number")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_number")]
                [WechatTenpayBusinessSensitiveProperty]
                public string BankAccountNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开户银行。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                public string BankName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开户银行联行号。与字段 <see cref="BankBranchName"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_branch_id")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_branch_id")]
                public string? BankBranchId { get; set; }

                /// <summary>
                /// 获取或设置开户银行全称（含支行）。与字段 <see cref="BankBranchId"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_branch_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_branch_name")]
                public string? BankBranchName { get; set; }
            }

            public class Product
            {
                /// <summary>
                /// 获取或设置产品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_name")]
                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                public string ProductName { get; set; } = string.Empty;
            }

            public class NotifyConfig
            {
                /// <summary>
                /// 获取或设置普通企业开户结果通知 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("server_notify_url")]
                [System.Text.Json.Serialization.JsonPropertyName("server_notify_url")]
                public string? ServerNotifyUrl { get; set; }

                /// <summary>
                /// 获取或设置前端成功回调 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("web_success_url")]
                [System.Text.Json.Serialization.JsonPropertyName("web_success_url")]
                public string? WebSuccessUrl { get; set; }

                /// <summary>
                /// 获取或设置前端异常回调刷新 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("web_refresh_url")]
                [System.Text.Json.Serialization.JsonPropertyName("web_refresh_url")]
                public string? WebRefreshUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置业务申请编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置营业执照信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_license")]
        [System.Text.Json.Serialization.JsonPropertyName("business_license")]
        public Types.BusinessLicense? BusinessLicense { get; set; }

        /// <summary>
        /// 获取或设置法人身份证信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_person_id_card")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_person_id_card")]
        public Types.IdCard? LegalPersonIdCard { get; set; }

        /// <summary>
        /// 获取或设置联系人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_info")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_info")]
        public Types.Contact Contact { get; set; } = new Types.Contact();

        /// <summary>
        /// 获取或设置收款账户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee_accounts")]
        [System.Text.Json.Serialization.JsonPropertyName("payee_accounts")]
        public IList<Types.PayeeAccount> PayeeAccountList { get; set; } = new List<Types.PayeeAccount>();

        /// <summary>
        /// 获取或设置开通产品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("products")]
        [System.Text.Json.Serialization.JsonPropertyName("products")]
        public IList<Types.Product> ProductList { get; set; } = new List<Types.Product>();

        /// <summary>
        /// 获取或设置回调配置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public Types.NotifyConfig NotifyConfig { get; set; } = new Types.NotifyConfig();
    }
}
