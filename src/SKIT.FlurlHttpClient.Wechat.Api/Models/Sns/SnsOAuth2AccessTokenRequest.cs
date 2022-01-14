namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /sns/oauth2/access_token 接口的请求。</para>
    /// </summary>
    public class SnsOAuth2AccessTokenRequest : WechatApiRequest
    {
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string GrantType { get; set; } = "authorization_code";

        /// <summary>
        /// 获取或设置换取 AccessToken 的票据。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Code { get; set; } = string.Empty;
    }
}
