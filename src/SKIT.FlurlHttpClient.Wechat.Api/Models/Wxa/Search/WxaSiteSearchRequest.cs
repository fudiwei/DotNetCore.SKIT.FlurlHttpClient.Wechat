namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sitesearch 接口的请求。</para>
    /// </summary>
    public class WxaSiteSearchRequest : WechatApiRequest, IMapResponse<WxaSiteSearchRequest, WxaSiteSearchResponse>
    {
        /// <summary>
        /// 获取或设置关键词。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword")]
        public string Keyword { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置请求下一页的参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_page_info")]
        [System.Text.Json.Serialization.JsonPropertyName("next_page_info")]
        public string NextPageParameter { get; set; } = string.Empty;
    }
}
