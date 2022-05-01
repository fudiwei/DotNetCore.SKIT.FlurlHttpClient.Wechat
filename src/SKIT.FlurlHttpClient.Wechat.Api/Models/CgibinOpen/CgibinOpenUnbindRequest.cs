namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/open/unbind 接口的请求。</para>
    /// </summary>
    public class CgibinOpenUnbindRequest : WechatApiRequest, IInferable<CgibinOpenUnbindRequest, CgibinOpenUnbindResponse>
    {
        /// <summary>
        /// 获取或设置授权方的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AuthorizerAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开放平台的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("open_appid")]
        public string OpenAppId { get; set; } = string.Empty;
    }
}
