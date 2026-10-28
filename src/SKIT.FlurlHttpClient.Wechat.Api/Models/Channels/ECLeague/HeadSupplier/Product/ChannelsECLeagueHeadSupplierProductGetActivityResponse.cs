namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/product/getactivity 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierProductGetActivityResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ProductActivity
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long SKUId { get; set; }

                /// <summary>
                /// 获取或设置活动价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_price")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_price")]
                public int ActivityPrice { get; set; }

                /// <summary>
                /// 获取或设置平台补贴金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("platform_subsidy")]
                [System.Text.Json.Serialization.JsonPropertyName("platform_subsidy")]
                public int PlatformSubsidy { get; set; }

                /// <summary>
                /// 获取或设置平台补贴件数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("platform_subsidy_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("platform_subsidy_cnt")]
                public int PlatformSubsidyCount { get; set; }

                /// <summary>
                /// 获取或设置活动子类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_sub_type")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_sub_type")]
                public int ActivitySubType { get; set; }

                /// <summary>
                /// 获取或设置活动名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_name")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_name")]
                public string? ActivityName { get; set; }

                /// <summary>
                /// 获取或设置活动结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_end_time")]
                public long ActivityEndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置库存模式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_mode")]
                public int StockMode { get; set; }

                /// <summary>
                /// 获取或设置库存数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_number")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_number")]
                public int StockNumber { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置是否有活动。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_activity")]
        [System.Text.Json.Serialization.JsonPropertyName("has_activity")]
        public bool HasActivity { get; set; }

        /// <summary>
        /// 获取或设置商品活动列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_activity_list")]
        [System.Text.Json.Serialization.JsonPropertyName("product_activity_list")]
        public List<Types.ProductActivity>? ProductActivityList { get; set; }
    }
}
