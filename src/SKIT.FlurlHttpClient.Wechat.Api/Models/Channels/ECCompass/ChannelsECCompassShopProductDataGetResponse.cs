namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/shop/product/data/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCompassShopProductDataGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product : ChannelsECCompassShopProductListGetResponse.Types.Product
            {
            }
        }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_info")]
        [System.Text.Json.Serialization.JsonPropertyName("product_info")]
        public Types.Product Product { get; set; } = default!;
    }
}
