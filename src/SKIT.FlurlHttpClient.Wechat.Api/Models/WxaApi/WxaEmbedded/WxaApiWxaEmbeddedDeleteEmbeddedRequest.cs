namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/wxaembedded/del_embedded 接口的请求。</para>
    /// </summary>
    public class WxaApiWxaEmbeddedDeleteEmbeddedRequest : WechatApiRequest, IInferable<WxaApiWxaEmbeddedDeleteEmbeddedRequest, WxaApiWxaEmbeddedDeleteEmbeddedResponse>
    {
        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;
    }
}
