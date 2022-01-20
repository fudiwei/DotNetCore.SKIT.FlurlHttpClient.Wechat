namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/setwebviewdomain 接口的响应。</para>
    /// </summary>
    public class WxaSetWebviewDomainResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置业务域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webviewdomain")]
        [System.Text.Json.Serialization.JsonPropertyName("webviewdomain")]
        public string[]? WebviewDomainList { get; set; }
    }
}
