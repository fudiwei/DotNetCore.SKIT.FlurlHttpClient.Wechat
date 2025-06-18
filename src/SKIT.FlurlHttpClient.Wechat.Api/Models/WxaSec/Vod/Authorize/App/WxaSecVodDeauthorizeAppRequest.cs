namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/deauthorizeapp 接口的请求。</para>
    /// </summary>
    public class WxaSecVodDeauthorizeAppRequest : WechatApiRequest, IInferable<WxaSecVodDeauthorizeAppRequest, WxaSecVodDeauthorizeAppResponse>
    {
        /// <summary>
        /// 获取或设置被授权方小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorized_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("authorized_appid")]
        public string AuthorizedAppId { get; set; } = string.Empty;
    }
}
