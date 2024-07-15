namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/shop/finder/product/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCompassShopFinderProductListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class Data
                    {
                        /// <summary>
                        /// 获取或设置成交金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_gmv")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_gmv")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long PayGMV { get; set; }

                        /// <summary>
                        /// 获取或设置佣金率。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_ratio")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal CommissionRatio { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品头图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_img_url")]
                [System.Text.Json.Serialization.JsonPropertyName("head_img_url")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int Price { get; set; }

                /// <summary>
                /// 获取或设置一级分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("first_category_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long FirstCategoryId { get; set; }

                /// <summary>
                /// 获取或设置二级分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("second_category_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long SecondCategoryId { get; set; }

                /// <summary>
                /// 获取或设置三级分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("third_category_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ThirdCategoryId { get; set; }

                /// <summary>
                /// 获取或设置统计数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Data Data { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_list")]
        [System.Text.Json.Serialization.JsonPropertyName("product_list")]
        public Types.Product[] ProductList { get; set; } = default!;
    }
}
