namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/stock/batchget 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductStockBatchGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ProductStock
                    {
                        public static class Types
                        {
                            public class SKUStock : ChannelsECProductStockGetResponse.Types.Data
                            {
                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long SKUId { get; set; }
                                
                                /// <summary>
                                /// 获取或设置达人专属计划营销库存。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("finder_total_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("finder_total_num")]
                                public int? FinderTotalStock { get; set; }
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
                        /// 获取或设置 SKU 库存列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_stock")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_stock")]
                        public Types.SKUStock[] SKUStockList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置商品库存列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_stock_list")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_stock_list")]
                public Types.ProductStock[] StockList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
