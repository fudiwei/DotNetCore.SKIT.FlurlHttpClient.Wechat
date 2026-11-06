namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/reauth 接口的请求。</para>
    /// </summary>
    public class WxaSecReauthRequest : WechatApiRequest, IInferable<WxaSecReauthRequest, WxaSecReauthResponse>
    {
        public static class Types
        {
            public class AuthData : WxaSecWxaAuthRequest.Types.__zz__AuthData
            {
                public static class Types
                {
                    public class Contact : WxaSecWxaAuthRequest.Types.AuthData.Types.Contact
                    {
                    }

                    public class Invoice : WxaSecWxaAuthRequest.Types.AuthData.Types.__zz__Invoice
                    {
                        public static class Types
                        {
                            public class ElectronicInfo : WxaSecWxaAuthRequest.Types.AuthData.Types.Invoice.Types.ElectronicInfo
                            {
                            }

                            public class VATInfo : WxaSecWxaAuthRequest.Types.AuthData.Types.Invoice.Types.VATInfo
                            {
                            }
                        }

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
                public Types.Contact? Contact { get; set; }

                /// <summary>
                /// 获取或设置发票信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invoice_info")]
                [System.Text.Json.Serialization.JsonPropertyName("invoice_info")]
                public Types.Invoice? Invoice { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置认证信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_data")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_data")]
        public Types.AuthData? AuthData { get; set; }
    }
}
