namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/shop/product/data/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCompassShopProductDataGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product : ChannelsECCompassShopProductListGetResponse.Types.__zz__Product
            {
                public static class Types
                {
                    public class Data : ChannelsECCompassShopProductListGetResponse.Types.Product.Types.Data
                    {
                    }
                }

                /// <summary>
                /// 获取或设置统计数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Data? Data { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_info")]
        [System.Text.Json.Serialization.JsonPropertyName("product_info")]
        public Types.Product? Product { get; set; }
    }
}
