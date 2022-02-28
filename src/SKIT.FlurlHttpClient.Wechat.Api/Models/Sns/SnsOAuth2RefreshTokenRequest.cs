namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /sns/oauth2/refresh_token 接口的请求。</para>
    /// </summary>
    public class SnsOAuth2RefreshTokenRequest : WechatApiRequest, IMapResponse<SnsOAuth2RefreshTokenRequest, SnsOAuth2RefreshTokenResponse>
    {
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string GrantType { get; set; } = "refresh_token";

        /// <summary>
        /// 获取或设置通过 AccessToken 获取到的 RefreshToken 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string RefreshToken { get; set; } = string.Empty;
    }
}
