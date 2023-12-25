using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/wxaauth 接口的请求。</para>
    /// </summary>
    public class WxaSecWxaAuthRequest : WechatApiRequest, IInferable<WxaSecWxaAuthRequest, WxaSecWxaAuthResponse>
    {
        public static class Types
        {
            public class AuthData
            {
                public static class Types
                {
                    public class Contact
                    {
                        /// <summary>
                        /// 获取或设置认证联系人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置认证联系人邮箱。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("email")]
                        [System.Text.Json.Serialization.JsonPropertyName("email")]
                        public string Email { get; set; } = string.Empty;
                    }

                    public class Invoice
                    {
                        public static class Types
                        {
                            public class ElectronicInfo
                            {
                                /// <summary>
                                /// 获取或设置纳税识别号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string TaxNumber { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置发票备注。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("desc")]
                                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                                public string? Description { get; set; }
                            }

                            public class VATInfo
                            {
                                /// <summary>
                                /// 获取或设置纳税识别号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string TaxNumber { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置企业电话。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("enterprise_phone")]
                                [System.Text.Json.Serialization.JsonPropertyName("enterprise_phone")]
                                public string EnterprisePhoneNumber { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置企业注册地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("enterprise_address")]
                                [System.Text.Json.Serialization.JsonPropertyName("enterprise_address")]
                                public string EnterpriseAddress { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置企业开户银行。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("bank_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                                public string BankName { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置企业银行账号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("bank_account")]
                                [System.Text.Json.Serialization.JsonPropertyName("bank_account")]
                                public string BankAccount { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置邮寄地址邮编。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mailing_address")]
                                [System.Text.Json.Serialization.JsonPropertyName("mailing_address")]
                                public string? MailingPostcode { get; set; }

                                /// <summary>
                                /// 获取或设置邮寄地址省份。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("province")]
                                [System.Text.Json.Serialization.JsonPropertyName("province")]
                                public string? MailingProvince { get; set; }

                                /// <summary>
                                /// 获取或设置邮寄地址城市。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city")]
                                [System.Text.Json.Serialization.JsonPropertyName("city")]
                                public string? MailingCity { get; set; }

                                /// <summary>
                                /// 获取或设置邮寄地址区县。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("district")]
                                [System.Text.Json.Serialization.JsonPropertyName("district")]
                                public string? MailingDistrict { get; set; }

                                /// <summary>
                                /// 获取或设置邮寄地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address")]
                                [System.Text.Json.Serialization.JsonPropertyName("address")]
                                public string? MailingAddress { get; set; }

                                /// <summary>
                                /// 获取或设置邮寄联系人。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string? MailingContactName { get; set; }

                                /// <summary>
                                /// 获取或设置邮寄联系电话。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phone")]
                                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                                public string? MailingContactPhoneNumber { get; set; }

                                /// <summary>
                                /// 获取或设置发票备注。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("desc")]
                                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                                public string? Description { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置发票类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("invoice_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("invoice_type")]
                        public int InvoiceType { get; set; }

                        /// <summary>
                        /// 获取或设置发票抬头。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("invoice_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("invoice_title")]
                        public string? InvoiceTitle { get; set; }

                        /// <summary>
                        /// 获取或设置电子发票开票信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("electronic")]
                        [System.Text.Json.Serialization.JsonPropertyName("electronic")]
                        public Types.ElectronicInfo? ElectronicInfo { get; set; }

                        /// <summary>
                        /// 获取或设置增值税专票开票信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("vat")]
                        [System.Text.Json.Serialization.JsonPropertyName("vat")]
                        public Types.VATInfo? VATInfo { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置客户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("customer_type")]
                [System.Text.Json.Serialization.JsonPropertyName("customer_type")]
                public int CustomerType { get; set; }

                /// <summary>
                /// 获取或设置认证任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("taskid")]
                [System.Text.Json.Serialization.JsonPropertyName("taskid")]
                public string? TaskId { get; set; }

                /// <summary>
                /// 获取或设置联系人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_info")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_info")]
                public Types.Contact Contact { get; set; } = new Types.Contact();

                /// <summary>
                /// 获取或设置主体资质材料 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification")]
                public string? QualificationMediaId { get; set; }

                /// <summary>
                /// 获取或设置主体资质其他材料 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification_other")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification_other")]
                public IList<string>? QualificationOtherMediaIdList { get; set; }

                /// <summary>
                /// 获取或设置小程序账号名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("account_name")]
                public string AccountName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序账号名称命名类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_name_type")]
                [System.Text.Json.Serialization.JsonPropertyName("account_name_type")]
                public int AccountNameType { get; set; }

                /// <summary>
                /// 获取或设置名称命中关键词补充材料 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_supplemental")]
                [System.Text.Json.Serialization.JsonPropertyName("account_supplemental")]
                public IList<string>? AccountSupplementalMediaIdList { get; set; }

                /// <summary>
                /// 获取或设置支付方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_type")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_type")]
                public int PayType { get; set; }

                /// <summary>
                /// 获取或设置发票信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invoice_info")]
                [System.Text.Json.Serialization.JsonPropertyName("invoice_info")]
                public Types.Invoice? Invoice { get; set; }

                /// <summary>
                /// 获取或设置要认证的身份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_identification")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_identification")]
                public string? AuthIdentification { get; set; }

                /// <summary>
                /// 获取或设置身份证明材料 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_ident_material")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_ident_material")]
                public IList<string>? AuthIdentificationMaterialIdList { get; set; }

                /// <summary>
                /// 获取或设置第三方联系电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_party_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("third_party_phone")]
                public string? ThirdPartyPhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置服务市场 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("service_appid")]
                public string? ServiceAppId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置认证信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_data")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_data")]
        public Types.AuthData AuthData { get; set; } = new Types.AuthData();
    }
}
