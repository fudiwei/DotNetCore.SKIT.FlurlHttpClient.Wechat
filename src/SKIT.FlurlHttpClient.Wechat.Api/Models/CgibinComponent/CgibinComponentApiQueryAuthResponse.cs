namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/api_query_auth 接口的响应。</para>
    /// </summary>
    public class CgibinComponentApiQueryAuthResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Authorization
            {
                public static class Types
                {
                    public class Function
                    {
                        public static class Types
                        {
                            public class ScopeCategory
                            {
                                /// <summary>
                                /// 获取或设置权限集 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public int Id { get; set; }

                                /// <summary>
                                /// 获取或设置权限集类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public int Type { get; set; }

                                /// <summary>
                                /// 获取或设置权限集名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置权限集描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("desc")]
                                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                                public string Description { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置权限集信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("funcscope_category")]
                        [System.Text.Json.Serialization.JsonPropertyName("funcscope_category")]
                        public Types.ScopeCategory ScopeCategory { get; set; } = default!;
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
                public string AuthorizerAccessToken { get; set; } = default!;

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
                public int ExpiresIn { get; set; }

                /// <summary>
                /// 获取或设置授权给开发者的权限集列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("func_info")]
                [System.Text.Json.Serialization.JsonPropertyName("func_info")]
                public Types.Function[]? FunctionList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置授权信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_info")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_info")]
        public Types.Authorization Authorization { get; set; } = default!;
    }
}
