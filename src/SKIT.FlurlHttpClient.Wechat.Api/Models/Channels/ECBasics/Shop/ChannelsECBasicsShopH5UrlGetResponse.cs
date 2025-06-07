namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/shop/h5url/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECBasicsShopH5UrlGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置小店 H5 短链。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_h5url")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_h5url")]
        public string ShopH5Url { get; set; } = default!;
    }
}
