namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/realname/getauthurl 接口的请求。</para>
    /// </summary>
    public class IntpRealNameGetAuthUrlRequest : WechatApiRequest, IMapResponse<IntpRealNameGetAuthUrlRequest, IntpRealNameGetAuthUrlResponse>
    {
        /// <summary>
        /// 获取或设置用户授权完成后回跳的 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redirect_url")]
        [System.Text.Json.Serialization.JsonPropertyName("redirect_url")]
        public string RedirectUrl { get; set; } = string.Empty;
    }
}
