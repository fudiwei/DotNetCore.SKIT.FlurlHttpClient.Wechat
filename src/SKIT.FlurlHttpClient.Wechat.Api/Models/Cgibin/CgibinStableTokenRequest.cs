namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/stable_token 接口的请求。</para>
    /// </summary>
    public class CgibinStableTokenRequest : WechatApiRequest, IInferable<CgibinTokenRequest, CgibinTokenResponse>
    {
        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppSecret。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppSecret"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("secret")]
        [System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? AppSecret { get; set; }
        
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grant_type")]
        [System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        public string GrantType { get; set; } = "client_credential";

        /// <summary>
        /// 获取或设置是否强制刷新。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("force_refresh")]
        [System.Text.Json.Serialization.JsonPropertyName("force_refresh")]
        public bool ForceRefresh { get; set; }
    }
}
