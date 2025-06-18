namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/taglink/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductTagLinkGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置商品微信口令。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_taglink")]
        [System.Text.Json.Serialization.JsonPropertyName("product_taglink")]
        public string ProductTagLink { get; set; } = default!;
    }
}
