using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/api_authorizer_token 接口的响应。</para>
    /// </summary>
    public class CgibinComponentApiAuthorizerTokenResponse : WechatApiResponse
    {
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
    }
}
