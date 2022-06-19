namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/promoter/open_product/generate 接口的响应。</para>
    /// </summary>
    public class UnionPromoterOpenProductGenerateResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ProductPromotion
            {
                public static class Types
                {
                    public class Product
                    {
                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("productId")]
                        [System.Text.Json.Serialization.JsonPropertyName("productId")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置商品标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品副标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subTitle")]
                        [System.Text.Json.Serialization.JsonPropertyName("subTitle")]
                        public string? SubTitle { get; set; }

                        /// <summary>
                        /// 获取或设置主图 Url 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("headImg")]
                        [System.Text.Json.Serialization.JsonPropertyName("headImg")]
                        public string[] HeadImageUrlList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU 最低价格（单位：分）。
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
                        /// 获取或设置小商店名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shopName")]
                        [System.Text.Json.Serialization.JsonPropertyName("shopName")]
                        public string? ShopName { get; set; }

                        /// <summary>
                        /// 获取或设置店铺状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shopStatus")]
                        [System.Text.Json.Serialization.JsonPropertyName("shopStatus")]
                        public int? ShopStatus { get; set; }
                    }

                    public class Share
                    {
                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appId")]
                        [System.Text.Json.Serialization.JsonPropertyName("appId")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序原始 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("username")]
                        [System.Text.Json.Serialization.JsonPropertyName("username")]
                        public string Username { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path")]
                        [System.Text.Json.Serialization.JsonPropertyName("path")]
                        public string PagePath { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置推广商品文案。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotionWording")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotionWording")]
                        public string? PromotionText { get; set; }

                        /// <summary>
                        /// 获取或设置推广商品链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotionUrl")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotionUrl")]
                        public string? PromotionUrl { get; set; }

                        /// <summary>
                        /// 获取或设置推广商品 Tag。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotionTag")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotionTag")]
                        public string? PromotionTag { get; set; }

                        /// <summary>
                        /// 获取或设置获取素材状态码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public int Code { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置推广位 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pid")]
                [System.Text.Json.Serialization.JsonPropertyName("pid")]
                public string PromotionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("productInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("productInfo")]
                public Types.Product Product { get; set; } = default!;

                /// <summary>
                /// 获取或设置推广相关信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shareInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("shareInfo")]
                public Types.Share? Share { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品推广素材列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.ProductPromotion[] ProductPromotionList { get; set; } = default!;
    }
}
