namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/getcopyrightauthorizedlist 接口的请求。</para>
    /// </summary>
    public class WxaSecVodGetCopyrightAuthorizedListRequest : WechatApiRequest, IInferable<WxaSecVodGetCopyrightAuthorizedListRequest, WxaSecVodGetCopyrightAuthorizedListResponse>
    {
        /// <summary>
        /// 获取或设置授权方小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorizer_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("authorizer_appid")]
        public string? AuthorizerAppId { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
