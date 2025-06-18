namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/delbookauth 接口的请求。</para>
    /// </summary>
    public class WxaBookDeleteBookAuthRequest : WechatApiRequest, IInferable<WxaBookDeleteBookAuthRequest, WxaBookDeleteBookAuthResponse>
    {
        /// <summary>
        /// 获取或设置作品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_id")]
        [System.Text.Json.Serialization.JsonPropertyName("book_id")]
        public string BookId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置被授权账号 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grantee_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("grantee_appid")]
        public string GranteeAppId { get; set; } = string.Empty;
    }
}
