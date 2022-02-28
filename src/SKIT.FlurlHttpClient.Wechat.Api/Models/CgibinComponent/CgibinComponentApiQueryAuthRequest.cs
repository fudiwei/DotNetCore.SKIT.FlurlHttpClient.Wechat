namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/api_query_auth 接口的请求。</para>
    /// </summary>
    public class CgibinComponentApiQueryAuthRequest : WechatApiRequest, IMapResponse<CgibinComponentApiQueryAuthRequest, CgibinComponentApiQueryAuthResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置第三方平台 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("component_appid")]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_code")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_code")]
        public string AuthCode { get; set; } = string.Empty;
    }
}
