namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/get_effective_webviewdomain 接口的响应。</para>
    /// </summary>
    public class WxaGetEffectiveWebviewDomainResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置通过公众平台配置的 Webview 域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mp_webviewdomain")]
        [System.Text.Json.Serialization.JsonPropertyName("mp_webviewdomain")]
        public List<string>? MpWebviewDomain { get; set; }

        /// <summary>
        /// 获取或设置通过第三方平台接口配置的 Webview 域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("third_webviewdomain")]
        [System.Text.Json.Serialization.JsonPropertyName("third_webviewdomain")]
        public List<string>? ThirdWebviewDomain { get; set; }

        /// <summary>
        /// 获取或设置通过 ModifyServerDomainDirectly 接口配置的 Webview 域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("direct_webviewdomain")]
        [System.Text.Json.Serialization.JsonPropertyName("direct_webviewdomain")]
        public List<string>? DirectlyWebviewDomain { get; set; }

        /// <summary>
        /// 获取或设置最后提交代码或者发布上线后生效的 Webview 域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effective_webviewdomain")]
        [System.Text.Json.Serialization.JsonPropertyName("effective_webviewdomain")]
        public List<string>? EffectiveWebviewDomain { get; set; }
    }
}
