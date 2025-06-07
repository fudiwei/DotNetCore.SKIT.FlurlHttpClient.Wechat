namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/shop/taglink/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECBasicsShopTagLinkGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置小店微信口令。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_taglink")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_taglink")]
        public string ShopTagLink { get; set; } = default!;
    }
}
