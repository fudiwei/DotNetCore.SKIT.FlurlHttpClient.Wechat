namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/talent/window/product/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECTalentWindowProductListGetResponse : WechatApiResponse
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
                /// 获取或设置商品来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_source")]
                [System.Text.Json.Serialization.JsonPropertyName("product_source")]
                public int ProductSource { get; set; }

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
            }
        }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("products")]
        [System.Text.Json.Serialization.JsonPropertyName("products")]
        public Types.Product[] ProductList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_buffer")]
        [System.Text.Json.Serialization.JsonPropertyName("last_buffer")]
        public string? NextCursor { get; set; }
    }
}
