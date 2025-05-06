namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/talent/window/product/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECTalentWindowProductGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置店铺 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string? AppId { get; set; }

                /// <summary>
                /// 获取或设置商家自定义商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
                public string? OutProductId { get; set; }

                /// <summary>
                /// 获取或设置商品标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品头图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("img_url")]
                [System.Text.Json.Serialization.JsonPropertyName("img_url")]
                public string ImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("leaf_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("leaf_category_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long CategoryId { get; set; }

                /// <summary>
                /// 获取或设置商品状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置售价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("selling_price")]
                [System.Text.Json.Serialization.JsonPropertyName("selling_price")]
                public int SellingPrice { get; set; }

                /// <summary>
                /// 获取或设置库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock")]
                [System.Text.Json.Serialization.JsonPropertyName("stock")]
                public int Stock { get; set; }

                /// <summary>
                /// 获取或设置销量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sales")]
                [System.Text.Json.Serialization.JsonPropertyName("sales")]
                public int Sales { get; set; }

                /// <summary>
                /// 获取或设置是否隐藏。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_hide")]
                [System.Text.Json.Serialization.JsonPropertyName("is_hide")]
                public bool IsHidden { get; set; }

                /// <summary>
                /// 获取或设置商品小程序跳转小店场景添加商品时传递的跟佣信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_promotion_link")]
                [System.Text.Json.Serialization.JsonPropertyName("product_promotion_link")]
                public string? ProductPromotionLink { get; set; }
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
