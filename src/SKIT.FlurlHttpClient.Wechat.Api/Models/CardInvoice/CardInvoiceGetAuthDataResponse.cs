namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/getauthdata 接口的响应。</para>
    /// </summary>
    public class CardInvoiceGetAuthDataResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AuthData
            {
                public static class Types
                {
                    public class UserField
                    {
                        /// <summary>
                        /// 获取或设置发票抬头。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置联系电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("phone")]
                        public string PhoneNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置邮箱。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("email")]
                        [System.Text.Json.Serialization.JsonPropertyName("email")]
                        public string Email { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置自定义字段列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_field")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_field")]
                        public CustomField[]? CustomFieldList { get; set; }
                    }

                    public class BusinessField
                    {
                        /// <summary>
                        /// 获取或设置单位抬头。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置联系电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("phone")]
                        public string PhoneNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置税号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tax_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("tax_no")]
                        public string TaxNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置单位地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("addr")]
                        [System.Text.Json.Serialization.JsonPropertyName("addr")]
                        public string Address { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置开户银行。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bank_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("bank_type")]
                        public string BankType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置银行账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bank_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("bank_no")]
                        public string BankNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置自定义字段列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_field")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_field")]
                        public CustomField[]? CustomFieldList { get; set; }
                    }

                    public class CustomField
                    {
                        /// <summary>
                        /// 获取或设置自定义字段名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("key")]
                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                        public string Key { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置自定义字段的值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string Value { get; set; } = default!;
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
        /// 获取或设置订单授权状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoice_status")]
        [System.Text.Json.Serialization.JsonPropertyName("invoice_status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单授权时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_time")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_time")]
        public long? AuthTimestamp { get; set; }

        /// <summary>
        /// 获取或设置用户授权信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_auth_info")]
        [System.Text.Json.Serialization.JsonPropertyName("user_auth_info")]
        public Types.AuthData? AuthData { get; set; }
    }
}
