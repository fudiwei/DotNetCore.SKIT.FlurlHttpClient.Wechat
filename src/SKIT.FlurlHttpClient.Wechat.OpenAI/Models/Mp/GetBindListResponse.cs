namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /getbindlist/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class GetBindListResponse : WechatOpenAIResponse
    {
        public static class Types
        {
            public class BindInfo
            {
                public static class Types
                {
                    public class Data
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
                                        /// <summary>
                                        /// 获取或设置访问状态。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("visit_status")]
                                        [System.Text.Json.Serialization.JsonPropertyName("visit_status")]
                                        public int VisitStatus { get; set; }
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
                            }

                            public class Authorization
                            {
                                /// <summary>
                                /// 获取或设置授权方 AppId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("authorizer_appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("authorizer_appid")]
                                public string AuthorizerAppId { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置授权方 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("authorizer_appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("authorizer_appid")]
                        public string AuthorizerAppId { get; set; } = default!;

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
                        public Types.Authorization? Authorization { get; set; }

                        /// <summary>
                        /// 获取或设置是否已绑定。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("binded")]
                        [System.Text.Json.Serialization.JsonPropertyName("binded")]
                        public bool IsBinded { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置绑定信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("info")]
                [System.Text.Json.Serialization.JsonPropertyName("info")]
                public Types.Data Data { get; set; } = default!;
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public override int? ReturnCode { get; set; }

        /// <summary>
        /// 获取微信智能对话 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string? ReturnMessage { get; set; }

        /// <summary>
        /// 获取或设置绑定列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bindlist")]
        [System.Text.Json.Serialization.JsonPropertyName("bindlist")]
        public Types.BindInfo[] BindList { get; set; } = default!;
    }
}
