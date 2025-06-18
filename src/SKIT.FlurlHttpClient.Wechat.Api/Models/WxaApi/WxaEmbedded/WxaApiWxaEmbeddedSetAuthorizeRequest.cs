namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/wxaembedded/set_authorize 接口的请求。</para>
    /// </summary>
    public class WxaApiWxaEmbeddedSetAuthorizeRequest : WechatApiRequest, IInferable<WxaApiWxaEmbeddedSetAuthorizeRequest, WxaApiWxaEmbeddedSetAuthorizeResponse>
    {
        /// <summary>
        /// 获取或设置授权方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flag")]
        [System.Text.Json.Serialization.JsonPropertyName("flag")]
        public int AuthFlag { get; set; }
    }
}
