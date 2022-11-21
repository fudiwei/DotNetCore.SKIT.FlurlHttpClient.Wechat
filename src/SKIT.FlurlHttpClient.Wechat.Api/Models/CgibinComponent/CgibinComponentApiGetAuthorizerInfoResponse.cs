namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/api_get_authorizer_info 接口的响应。</para>
    /// </summary>
    public class CgibinComponentApiGetAuthorizerInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Authorizer
            {
                public static class Types
                {
                    public class ServiceType
                    {
                        /// <summary>
                        /// 获取或设置类型 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public int Id { get; set; }

                        /// <summary>
                        /// 获取或设置类型名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }
                    }

                    public class VerifyType : ServiceType
                    {
                    }

                    public class Business
                    {
                        /// <summary>
                        /// 获取或设置是否开通微信门店功能。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_store")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("open_store")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsOpenStore { get; set; }

                        /// <summary>
                        /// 获取或设置是否开通微信扫商品功能。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_scan")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("open_scan")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsOpenScan { get; set; }

                        /// <summary>
                        /// 获取或设置是否开通微信支付功能。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_pay")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("open_pay")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsOpenPay { get; set; }

                        /// <summary>
                        /// 获取或设置是否开通微信卡券功能。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_card")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("open_card")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsOpenCard { get; set; }

                        /// <summary>
                        /// 获取或设置是否开通微信摇一摇功能。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_shake")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("open_shake")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsOpenShake { get; set; }
                    }

                    public class MiniProgram
                    {
                        public static class Types
                        {
                            public class Network
                            {
                                /// <summary>
                                /// 获取或设置 Request 合法域名列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("RequestDomain")]
                                [System.Text.Json.Serialization.JsonPropertyName("RequestDomain")]
                                public string[] RequestDomainList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 Socket 合法域名列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("WsRequestDomain")]
                                [System.Text.Json.Serialization.JsonPropertyName("WsRequestDomain")]
                                public string[] WebSocketDomainList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 UploadFile 合法域名列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("UploadDomain")]
                                [System.Text.Json.Serialization.JsonPropertyName("UploadDomain")]
                                public string[] UploadDomainList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 DownloadFile 合法域名列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("DownloadDomain")]
                                [System.Text.Json.Serialization.JsonPropertyName("DownloadDomain")]
                                public string[] DownloadDomainList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 UDP 合法域名列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("UDPDomain")]
                                [System.Text.Json.Serialization.JsonPropertyName("UDPDomain")]
                                public string[] UdpDomainList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置业务域名列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("BizDomain")]
                                [System.Text.Json.Serialization.JsonPropertyName("BizDomain")]
                                public string[] BusinessDomainList { get; set; } = default!;
                            }

                            public class Category
                            {
                                /// <summary>
                                /// 获取或设置一级分类。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("first")]
                                [System.Text.Json.Serialization.JsonPropertyName("first")]
                                public string FirstCategory { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置二级分类。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("second")]
                                [System.Text.Json.Serialization.JsonPropertyName("second")]
                                public string SecondCategory { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置网络配置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("network")]
                        [System.Text.Json.Serialization.JsonPropertyName("network")]
                        public Types.Network Network { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分类列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("categories")]
                        [System.Text.Json.Serialization.JsonPropertyName("categories")]
                        public Types.Category[] CategoryList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置访问状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("visit_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("visit_status")]
                        public int VisitStatus { get; set; }
                    }

                    public class BasicConfiguration
                    {
                        /// <summary>
                        /// 获取或设置是否已经绑定手机号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_phone_configured")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_phone_configured")]
                        public bool IsPhoneConfigured { get; set; }

                        /// <summary>
                        /// 获取或设置是否已经绑定邮箱。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_email_configured")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_email_configured")]
                        public bool IsEmailConfigured { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置原始 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_name")]
                [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                public string Username { get; set; } = default!;

                /// <summary>
                /// 获取或设置名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nick_name")]
                [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_img")]
                [System.Text.Json.Serialization.JsonPropertyName("head_img")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置公众号或小程序服务类型信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_type_info")]
                [System.Text.Json.Serialization.JsonPropertyName("service_type_info")]
                public Types.ServiceType ServiceType { get; set; } = default!;

                /// <summary>
                /// 获取或设置公众号或小程序认证类型信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_type_info")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_type_info")]
                public Types.VerifyType VerifyType { get; set; } = default!;

                /// <summary>
                /// 获取或设置主体名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("principal_name")]
                [System.Text.Json.Serialization.JsonPropertyName("principal_name")]
                public string? PrincipalName { get; set; }

                /// <summary>
                /// 获取或设置微信号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("alias")]
                [System.Text.Json.Serialization.JsonPropertyName("alias")]
                public string? Alias { get; set; }

                /// <summary>
                /// 获取或设置账号介绍。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("signature")]
                [System.Text.Json.Serialization.JsonPropertyName("signature")]
                public string? Signature { get; set; }

                /// <summary>
                /// 获取或设置二维码图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qrcode_url")]
                [System.Text.Json.Serialization.JsonPropertyName("qrcode_url")]
                public string? QrcodeUrl { get; set; }

                /// <summary>
                /// 获取或设置功能信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_info")]
                [System.Text.Json.Serialization.JsonPropertyName("business_info")]
                public Types.Business Business { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("MiniProgramInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("MiniProgramInfo")]
                public Types.MiniProgram? MiniProgram { get; set; }

                /// <summary>
                /// 获取或设置账号状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_status")]
                [System.Text.Json.Serialization.JsonPropertyName("account_status")]
                public int AccountStatus { get; set; }

                /// <summary>
                /// 获取或设置注册方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("register_type")]
                [System.Text.Json.Serialization.JsonPropertyName("register_type")]
                public int? RegisterType { get; set; }

                /// <summary>
                /// 获取或设置基础配置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("basic_config")]
                [System.Text.Json.Serialization.JsonPropertyName("basic_config")]
                public Types.BasicConfiguration? BasicConfiguration { get; set; }
            }

            public class Authorization
            {
                public static class Types
                {
                    public class Function : CgibinComponentApiQueryAuthResponse.Types.Authorization.Types.Function
                    {
                    }
                }

                /// <summary>
                /// 获取或设置授权方 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorizer_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("authorizer_appid")]
                public string AuthorizerAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置授权方 AccessToken。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorizer_access_token")]
                [System.Text.Json.Serialization.JsonPropertyName("authorizer_access_token")]
                public string? AuthorizerAccessToken { get; set; }

                /// <summary>
                /// 获取或设置授权方 RefreshToken。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorizer_refresh_token")]
                [System.Text.Json.Serialization.JsonPropertyName("authorizer_refresh_token")]
                public string? AuthorizerRefreshToken { get; set; }

                /// <summary>
                /// 获取或设置授权方 AccessToken 有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
                public int? ExpiresIn { get; set; }

                /// <summary>
                /// 获取或设置授权给开发者的权限集列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("func_info")]
                [System.Text.Json.Serialization.JsonPropertyName("func_info")]
                public Types.Function[] FunctionList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置授权方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorizer_info")]
        [System.Text.Json.Serialization.JsonPropertyName("authorizer_info")]
        public Types.Authorizer Authorizer { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_info")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_info")]
        public Types.Authorization Authorization { get; set; } = default!;
    }
}
