namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/queryscheme 接口的请求。</para>
    /// </summary>
    public class WxaQuerySchemeRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置小程序 URL Scheme。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scheme")]
        [System.Text.Json.Serialization.JsonPropertyName("scheme")]
        public string UrlScheme { get; set; } = string.Empty;
    }
}
