namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/setbizattr?action=get_auth_field 接口的响应。</para>
    /// </summary>
    public class CardInvoiceGetAuthFieldResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AuthField
            {
                public static class Types
                {
                    public class UserField : CardInvoiceSetAuthFieldRequest.Types.AuthField.Types.__zz__UserField
                    {
                        /// <summary>
                        /// 获取或设置自定义字段列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_field")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_field")]
                        public List<CustomField>? CustomFieldList { get; set; }
                    }

                    public class BusinessField : CardInvoiceSetAuthFieldRequest.Types.AuthField.Types.__zz__BusinessField
                    {
                        /// <summary>
                        /// 获取或设置自定义字段列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_field")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_field")]
                        public List<CustomField>? CustomFieldList { get; set; }
                    }

                    public class CustomField : CardInvoiceSetAuthFieldRequest.Types.AuthField.Types.CustomField
                    {
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
        public Types.AuthField? AuthField { get; set; }
    }
}
