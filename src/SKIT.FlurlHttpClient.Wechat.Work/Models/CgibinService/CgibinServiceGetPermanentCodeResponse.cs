namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_permanent_code 接口的响应。</para>
    /// </summary>
    public class CgibinServiceGetPermanentCodeResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class DealerCorp : CgibinServiceGetAuthInfoResponse.Types.DealerCorp
            {
            }

            public class AuthorizerCorp : CgibinServiceGetAuthInfoResponse.Types.__zz__AuthorizerCorp
            {
                /// <summary>
                /// 获取或设置授权模式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_type")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_type")]
                public int AuthType { get; set; }
            }

            public class Authorization
            {
                public static class Types
                {
                    public class Agent : CgibinServiceGetAuthInfoResponse.Types.Authorization.Types.__zz__Agent
                    {
                        public static class Types
                        {
                            public class Privilege : CgibinServiceGetAuthInfoResponse.Types.Authorization.Types.Agent.Types.Privilege
                            {
                            }

                            public class SharedFrom : CgibinServiceGetAuthInfoResponse.Types.Authorization.Types.Agent.Types.SharedFrom
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置应用权限信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("privilege")]
                        [System.Text.Json.Serialization.JsonPropertyName("privilege")]
                        public Types.Privilege? Privilege { get; set; }

                        /// <summary>
                        /// 获取或设置共享了应用的互联企业信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shared_from")]
                        [System.Text.Json.Serialization.JsonPropertyName("shared_from")]
                        public Types.SharedFrom? SharedFrom { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置授权的应用列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agent")]
                [System.Text.Json.Serialization.JsonPropertyName("agent")]
                public List<Types.Agent>? AgentList { get; set; }
            }

            public class AuthorizerUser
            {
                /// <summary>
                /// 获取或设置授权管理员的成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置授权管理员的名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置授权管理员的头像 Url。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avatar")]
                [System.Text.Json.Serialization.JsonPropertyName("avatar")]
                public string? AvatarUrl { get; set; }

                /// <summary>
                /// 获取或设置授权管理员的第三方成员唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("open_userid")]
                public string? OpenUserId { get; set; }
            }

            public class RegisterCode
            {
                /// <summary>
                /// 获取或设置注册码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("register_code")]
                [System.Text.Json.Serialization.JsonPropertyName("register_code")]
                public string? Code { get; set; }

                /// <summary>
                /// 获取或设置推广包 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public string? TemplateId { get; set; }

                /// <summary>
                /// 获取或设置自定义渠道参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public string? State { get; set; }
            }

            public class Edition
            {
                public static class Types
                {
                    public class Agent : CgibinServiceGetAuthInfoResponse.Types.Edition.Types.Agent
                    {
                    }
                }

                /// <summary>
                /// 获取或设置授权的应用信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agent")]
                [System.Text.Json.Serialization.JsonPropertyName("agent")]
                public List<Types.Agent>? AgentList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置永久授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("permanent_code")]
        [System.Text.Json.Serialization.JsonPropertyName("permanent_code")]
        public string? PermanentAuthCode { get; set; }

        /// <summary>
        /// 获取或设置授权方接口调用凭证凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置凭证有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// 获取或设置代理服务商企业信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dealer_corp_info")]
        [System.Text.Json.Serialization.JsonPropertyName("dealer_corp_info")]
        public Types.DealerCorp? DealerCorp { get; set; }

        /// <summary>
        /// 获取或设置授权方企业信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_corp_info")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_corp_info")]
        public Types.AuthorizerCorp? AuthorizerCorp { get; set; }

        /// <summary>
        /// 获取或设置授权信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_info")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_info")]
        public Types.Authorization? Authorization { get; set; }

        /// <summary>
        /// 获取或设置授权管理员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_user_info")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_user_info")]
        public Types.AuthorizerUser? AuthorizerUser { get; set; }

        /// <summary>
        /// 获取或设置推广二维码信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("register_code_info")]
        [System.Text.Json.Serialization.JsonPropertyName("register_code_info")]
        public Types.RegisterCode? RegisterCode { get; set; }

        /// <summary>
        /// 获取或设置扫码或者授权链接中的自定义参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 获取或设置当前生效的版本信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("edition_info")]
        [System.Text.Json.Serialization.JsonPropertyName("edition_info")]
        public Types.Edition? Edition { get; set; }
    }
}
