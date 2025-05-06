namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/selectionproducts/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierSelectionProductsListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
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
                /// 获取或设置机构推广商品链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_supplier_item_link")]
                [System.Text.Json.Serialization.JsonPropertyName("head_supplier_item_link")]
                public string HeadSupplierItemLink { get; set; } = default!;
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
    }
}
