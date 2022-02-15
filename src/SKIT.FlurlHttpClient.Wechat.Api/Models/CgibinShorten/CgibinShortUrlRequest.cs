namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/shorturl 接口的请求。</para>
    /// </summary>
    public class CgibinShortUrlRequest : WechatApiRequest, IMapResponse<CgibinShortUrlRequest, CgibinShortUrlResponse>
    {
        /// <summary>
        /// <i>使用默认值即可，无需修改。</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "long2short";

        /// <summary>
        /// 获取或设置需要转换的长链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("long_url")]
        [System.Text.Json.Serialization.JsonPropertyName("long_url")]
        public string LongUrl { get; set; } = string.Empty;
    }
}
