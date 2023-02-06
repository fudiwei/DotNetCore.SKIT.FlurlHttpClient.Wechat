namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/stock/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductStockGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class WarehouseStock
                    {
                        /// <summary>
                        /// 获取或设置外部仓库 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
                        public string OutWarehouseId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置库存数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("num")]
                        [System.Text.Json.Serialization.JsonPropertyName("num")]
                        public int Stock { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置通用库存数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("normal_stock_num")]
                [System.Text.Json.Serialization.JsonPropertyName("normal_stock_num")]
                public int NormalStock { get; set; }

                /// <summary>
                /// 获取或设置限时抢购库存数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limited_discount_stock_num")]
                [System.Text.Json.Serialization.JsonPropertyName("limited_discount_stock_num")]
                public int LimitedDiscountStock { get; set; }

                /// <summary>
                /// 获取或设置区域库存列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("warehouse_stocks")]
                [System.Text.Json.Serialization.JsonPropertyName("warehouse_stocks")]
                public Types.WarehouseStock[] WarehouseStock { get; set; } = default!;

                /// <summary>
                /// 获取或设置库存总量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_stock_num")]
                [System.Text.Json.Serialization.JsonPropertyName("total_stock_num")]
                public int TotalStock { get; set; }
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
