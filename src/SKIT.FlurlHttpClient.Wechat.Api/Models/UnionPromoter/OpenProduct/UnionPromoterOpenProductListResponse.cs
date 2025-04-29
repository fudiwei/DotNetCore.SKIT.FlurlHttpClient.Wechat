namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/promoter/open_product/list 接口的响应。</para>
    /// </summary>
    public class UnionPromoterOpenProductListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class ProductDetail
                    {
                        public static class Types
                        {
                            public class Information
                            {
                                public static class Types
                                {
                                    public class Detail
                                    {
                                        /// <summary>
                                        /// 获取或设置商品详情图片 Url 列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("detailImg")]
                                        [System.Text.Json.Serialization.JsonPropertyName("detailImg")]
                                        public string[] ImageUrlList { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置商品标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品主图 URL 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("headImg")]
                                [System.Text.Json.Serialization.JsonPropertyName("headImg")]
                                public string[] HeadImageUrlList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品详情信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("detail")]
                                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                                public Types.Detail Detail { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置品牌 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("brandId")]
                                [System.Text.Json.Serialization.JsonPropertyName("brandId")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long BrandId { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 最低价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("minPrice")]
                                [System.Text.Json.Serialization.JsonPropertyName("minPrice")]
                                public int MinPrice { get; set; }

                                /// <summary>
                                /// 获取或设置总库存。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("totalStockNum")]
                                [System.Text.Json.Serialization.JsonPropertyName("totalStockNum")]
                                public int TotalStock { get; set; }

                                /// <summary>
                                /// 获取或设置小程序页面路径。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("path")]
                                [System.Text.Json.Serialization.JsonPropertyName("path")]
                                public string? PagePath { get; set; }
                            }

                            public class SKU
                            {
                                public static class Types
                                {
                                    public class Information
                                    {
                                        /// <summary>
                                        /// 获取或设置缩略图 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("thumbImg")]
                                        [System.Text.Json.Serialization.JsonPropertyName("thumbImg")]
                                        public string ThumbnailUrl { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置售价（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("salePrice")]
                                        [System.Text.Json.Serialization.JsonPropertyName("salePrice")]
                                        public int SalePrice { get; set; }

                                        /// <summary>
                                        /// 获取或设置市场价（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("marketPrice")]
                                        [System.Text.Json.Serialization.JsonPropertyName("marketPrice")]
                                        public int MarketPrice { get; set; }

                                        /// <summary>
                                        /// 获取或设置库存量。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("stockNum")]
                                        [System.Text.Json.Serialization.JsonPropertyName("stockNum")]
                                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                        public int Stock { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("skuId")]
                                [System.Text.Json.Serialization.JsonPropertyName("skuId")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long SKUId { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 基本信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("productSkuInfo")]
                                [System.Text.Json.Serialization.JsonPropertyName("productSkuInfo")]
                                public Types.Information Information { get; set; } = default!;
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
                        /// 获取或设置商品基本信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("info")]
                        [System.Text.Json.Serialization.JsonPropertyName("info")]
                        public Types.Information Information { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skus")]
                        [System.Text.Json.Serialization.JsonPropertyName("skus")]
                        public Types.SKU[] SKUList { get; set; } = default!;
                    }

                    public class Shop
                    {
                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appId")]
                        [System.Text.Json.Serialization.JsonPropertyName("appId")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序原始 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("username")]
                        [System.Text.Json.Serialization.JsonPropertyName("username")]
                        public string Username { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("headImgUrl")]
                        [System.Text.Json.Serialization.JsonPropertyName("headImgUrl")]
                        public string HeadImageUrl { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置商品详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product")]
                [System.Text.Json.Serialization.JsonPropertyName("product")]
                public Types.ProductDetail ProductDetail { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品所属小商店信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shopInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("shopInfo")]
                public Types.Shop Shop { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productList")]
        [System.Text.Json.Serialization.JsonPropertyName("productList")]
        public Types.Product[] ProductList { get; set; } = default!;

        /// <summary>
        /// 获取或设置商品总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }
    }
}
