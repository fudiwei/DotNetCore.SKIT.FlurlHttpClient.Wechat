namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_live_commission_product_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetLiveCommissionProductListResponse : WechatApiResponse
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
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_name")]
                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_img_url")]
                [System.Text.Json.Serialization.JsonPropertyName("product_img_url")]
                public string ImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置售价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_price")]
                [System.Text.Json.Serialization.JsonPropertyName("product_price")]
                public int Price { get; set; }

                /// <summary>
                /// 获取或设置预估佣金金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("predict_commission_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("predict_commission_amount")]
                public int PredictCommissionAmount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_list")]
        [System.Text.Json.Serialization.JsonPropertyName("product_list")]
        public Types.Product[] ProductList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }
    }
}
