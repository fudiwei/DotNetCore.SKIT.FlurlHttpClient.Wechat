using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/setbizattr?action=set_auth_field 接口的请求。</para>
    /// </summary>
    public class CardInvoiceSetAuthFieldRequest : WechatApiRequest, IMapResponse<CardInvoiceSetAuthFieldRequest, CardInvoiceSetAuthFieldResponse>
    {
        public static class Types
        {
            public class AuthField
            {
                public static class Types
                {
                    public class UserField
                    {
                        /// <summary>
                        /// 获取或设置是否填写抬头。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("show_title")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("show_title")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsShowTitle { get; set; }

                        /// <summary>
                        /// 获取或设置是否填写联系电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("show_phone")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("show_phone")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsShowPhoneNumber { get; set; }

                        /// <summary>
                        /// 获取或设置是否填写邮箱。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("show_email")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("show_email")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsShowEmail { get; set; }

                        /// <summary>
                        /// 获取或设置自定义字段列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_field")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_field")]
                        public IList<CustomField>? CustomFieldList { get; set; }
                    }

                    public class BusinessField
                    {
                        /// <summary>
                        /// 获取或设置是否填写抬头。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("show_title")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("show_title")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsShowTitle { get; set; }

                        /// <summary>
                        /// 获取或设置是否填写税号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("show_tax_no")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("show_tax_no")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsShowTaxNumber { get; set; }

                        /// <summary>
                        /// 获取或设置是否填写单位地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("show_addr")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("show_addr")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsShowAddress { get; set; }

                        /// <summary>
                        /// 获取或设置是否填写联系电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("show_phone")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("show_phone")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsShowPhoneNumber { get; set; }

                        /// <summary>
                        /// 获取或设置是否填写开户银行。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("show_bank_type")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("show_bank_type")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsShowBankType { get; set; }

                        /// <summary>
                        /// 获取或设置是否填写银行账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("show_bank_no")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("show_bank_no")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsShowBankNumber { get; set; }

                        /// <summary>
                        /// 获取或设置自定义字段列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_field")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_field")]
                        public IList<CustomField>? CustomFieldList { get; set; }
                    }

                    public class CustomField
                    {
                        /// <summary>
                        /// 获取或设置自定义字段名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("key")]
                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                        public string Key { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置个人发票字段信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_field")]
                [System.Text.Json.Serialization.JsonPropertyName("user_field")]
                public Types.UserField? UserField { get; set; }

                /// <summary>
                /// 获取或设置单位发票字段信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_field")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_field")]
                public Types.BusinessField? BusinessField { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置授权页信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_field")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_field")]
        public Types.AuthField AuthField { get; set; } = new Types.AuthField();
    }
}
