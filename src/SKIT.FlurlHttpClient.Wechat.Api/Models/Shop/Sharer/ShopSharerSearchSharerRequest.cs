namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/sharer/search_sharer 接口的请求。</para>
    /// </summary>
    public class ShopSharerSearchSharerRequest : WechatApiRequest, IInferable<ShopSharerSearchSharerRequest, ShopSharerSearchSharerResponse>
    {
        /// <summary>
        /// 获取或设置分享员 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;
    }
}
