namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/productdetail/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierProductDetailGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class ProductInfo
                    {
                        public static class Types
                        {
                            public class Detail : ChannelsECProductGetResponse.Types.Product.Types.Detail
                            {
                            }

                            public class Category : ChannelsECProductGetResponse.Types.Product.Types.Category
                            {
                            }

                            public class SKU : ChannelsECProductGetResponse.Types.Product.Types.SKU
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品副标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_title")]
                        public string? SubTitle { get; set; }

                        /// <summary>
                        /// 获取或设置主图 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("head_imgs")]
                        [System.Text.Json.Serialization.JsonPropertyName("head_imgs")]
                        public string[] HeadImageUrlList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品详情信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc_info")]
                        public Types.Detail Detail { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置新版商品类目列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cats_v2")]
                        [System.Text.Json.Serialization.JsonPropertyName("cats_v2")]
                        public Types.Category[]? CategoryV2List { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skus")]
                        [System.Text.Json.Serialization.JsonPropertyName("skus")]
                        public Types.SKU[] SKUList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置近 30 天销量范围。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("monthly_sales_range")]
                        [System.Text.Json.Serialization.JsonPropertyName("monthly_sales_range")]
                        public int MonthlySalesRange { get; set; }
                    }

                    public class ShopInfo
                    {
                        /// <summary>
                        /// 获取或设置小店名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小店图标 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("icon")]
                        [System.Text.Json.Serialization.JsonPropertyName("icon")]
                        public string IconUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小店评分。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("score")]
                        [System.Text.Json.Serialization.JsonPropertyName("score")]
                        public int Score { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置小店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_info")]
                [System.Text.Json.Serialization.JsonPropertyName("product_info")]
                public Types.ProductInfo ProductInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置店铺信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop")]
                [System.Text.Json.Serialization.JsonPropertyName("shop")]
                public Types.ShopInfo ShopInfo { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Types.Product Product { get; set; } = default!;
    }
}
