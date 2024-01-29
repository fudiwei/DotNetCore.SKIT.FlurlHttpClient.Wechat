namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/queryscheme 接口的请求。</para>
    /// </summary>
    public class WxaQuerySchemeRequest : WechatApiRequest, IInferable<WxaQuerySchemeRequest, WxaQuerySchemeResponse>
    {
        /// <summary>
        /// 获取或设置小程序 URL Scheme。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scheme")]
        [System.Text.Json.Serialization.JsonPropertyName("scheme")]
        public string? UrlScheme { get; set; }

        /// <summary>
        /// 获取或设置查询类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_type")]
        [System.Text.Json.Serialization.JsonPropertyName("query_type")]
        public int? QueryType { get; set; }
    }
}
