namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /sns/oauth2/component/refresh_token 接口的请求。</para>
    /// </summary>
    public class SnsOAuth2ComponentRefreshTokenRequest : SnsOAuth2RefreshTokenRequest, IInferable<SnsOAuth2ComponentRefreshTokenRequest, SnsOAuth2ComponentRefreshTokenResponse>
    {
        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置第三方平台 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;
    }
}
