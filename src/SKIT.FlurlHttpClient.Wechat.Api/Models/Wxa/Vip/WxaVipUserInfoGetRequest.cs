namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/vip/user/info/get 接口的请求。</para>
    /// </summary>
    public class WxaVipUserInfoGetRequest : WechatApiRequest, IInferable<WxaVipUserInfoGetRequest, WxaVipUserInfoGetResponse>
    {
        /// <summary>
        /// 获取或设置小程序用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxa_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("wxa_openid")]
        public string OpenId { get; set; } = string.Empty;
    }
}
