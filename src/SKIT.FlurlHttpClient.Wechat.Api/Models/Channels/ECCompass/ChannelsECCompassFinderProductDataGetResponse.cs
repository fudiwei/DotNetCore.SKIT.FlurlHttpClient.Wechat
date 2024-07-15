namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/finder/product/data/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCompassFinderProductDataGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product : ChannelsECCompassFinderProductListGetResponse.Types.Product
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
