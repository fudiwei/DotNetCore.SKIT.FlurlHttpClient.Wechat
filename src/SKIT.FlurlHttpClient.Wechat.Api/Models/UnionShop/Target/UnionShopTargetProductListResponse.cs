namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/shop/target/product_list 接口的响应。</para>
    /// </summary>
    public class UnionShopTargetProductListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class Category
                    {
                        /// <summary>
                        /// 获取或设置商品类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("catId")]
                        [System.Text.Json.Serialization.JsonPropertyName("catId")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int CategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置商品类目层级。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("level")]
                        [System.Text.Json.Serialization.JsonPropertyName("level")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int Level { get; set; }

                        /// <summary>
                        /// 获取或设置上级商品类目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("productId")]
                [System.Text.Json.Serialization.JsonPropertyName("productId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("outProductId")]
                [System.Text.Json.Serialization.JsonPropertyName("outProductId")]
                public string OutProductId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品主图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("headImg")]
                [System.Text.Json.Serialization.JsonPropertyName("headImg")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品类目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cats")]
                [System.Text.Json.Serialization.JsonPropertyName("cats")]
                public Types.Category[] CategoryList { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string MiniProgramPagePath { get; set; } = default!;

                /// <summary>
                /// 获取或设置最低价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("minPrice")]
                [System.Text.Json.Serialization.JsonPropertyName("minPrice")]
                public int MinPrice { get; set; }

                /// <summary>
                /// 获取或设置商品库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("totalStockNum")]
                [System.Text.Json.Serialization.JsonPropertyName("totalStockNum")]
                public int Stock { get; set; }

                /// <summary>
                /// 获取或设置佣金率（单位：万分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commissionRatio")]
                [System.Text.Json.Serialization.JsonPropertyName("commissionRatio")]
                public int CommissionRatio { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productList")]
        [System.Text.Json.Serialization.JsonPropertyName("productList")]
        public Types.Product[] ProductList { get; set; } = default!;
    }
}
