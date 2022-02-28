namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/genwxashortlink 接口的请求。</para>
    /// </summary>
    public class WxaGenerateWxaShortLinkRequest : WechatApiRequest, IInferable<WxaGenerateWxaShortLinkRequest, WxaGenerateWxaShortLinkResponse>
    {
        /// <summary>
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_url")]
        [System.Text.Json.Serialization.JsonPropertyName("page_url")]
        public string PagePath { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小程序页面标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_title")]
        [System.Text.Json.Serialization.JsonPropertyName("page_title")]
        public string PageTitle { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否永久有效。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_permanent")]
        [System.Text.Json.Serialization.JsonPropertyName("is_permanent")]
        public bool? IsPermanent { get; set; }
    }
}
