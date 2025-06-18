namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/generatenfcscheme 接口的响应。</para>
    /// </summary>
    public class WxaGenerateNFCSchemeResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置生成的小程序 URL Scheme。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openlink")]
        [System.Text.Json.Serialization.JsonPropertyName("openlink")]
        public string UrlScheme { get; set; } = default!;
    }
}
