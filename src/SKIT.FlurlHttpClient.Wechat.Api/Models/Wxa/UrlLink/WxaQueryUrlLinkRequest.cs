namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/query_urllink 接口的请求。</para>
    /// </summary>
    public class WxaQueryUrlLinkRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置小程序 URL Link。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_link")]
        [System.Text.Json.Serialization.JsonPropertyName("url_link")]
        public string UrlLink { get; set; } = string.Empty;
    }
}
