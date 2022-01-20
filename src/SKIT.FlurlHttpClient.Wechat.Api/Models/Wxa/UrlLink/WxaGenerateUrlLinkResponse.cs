namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/generate_urllink 接口的响应。</para>
    /// </summary>
    public class WxaGenerateUrlLinkResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置生成的小程序 URL Link。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_link")]
        [System.Text.Json.Serialization.JsonPropertyName("url_link")]
        public string UrlLink { get; set; } = default!;
    }
}
