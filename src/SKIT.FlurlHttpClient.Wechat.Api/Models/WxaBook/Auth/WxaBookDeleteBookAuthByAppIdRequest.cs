namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/delbookauthbyappid 接口的请求。</para>
    /// </summary>
    public class WxaBookDeleteBookAuthByAppIdRequest : WechatApiRequest, IInferable<WxaBookDeleteBookAuthByAppIdRequest, WxaBookDeleteBookAuthByAppIdResponse>
    {
        /// <summary>
        /// 获取或设置被授权账号 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grantee_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("grantee_appid")]
        public string? GranteeAppId { get; set; }
    }
}
