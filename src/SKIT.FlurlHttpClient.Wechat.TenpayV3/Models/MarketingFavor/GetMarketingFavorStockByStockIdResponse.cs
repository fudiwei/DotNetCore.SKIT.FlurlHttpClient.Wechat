namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/favor/stocks/{stock_id} 接口的响应。</para>
    /// </summary>
    public class GetMarketingFavorStockByStockIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class StockUseRule : QueryMarketingFavorStocksResponse.Types.Stock.Types.__zz__StockUseRule
            {
                public static class Types
                {
                    public class NormalCoupon : QueryMarketingFavorStocksResponse.Types.Stock.Types.StockUseRule.Types.NormalCoupon
                    {
                    }

                    public class DiscountCoupon : QueryMarketingFavorStocksResponse.Types.Stock.Types.StockUseRule.Types.DiscountCoupon
                    {
                    }
                }

                /// <summary>
                /// 获取或设置满减券使用规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fixed_normal_coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("fixed_normal_coupon")]
                public Types.NormalCoupon? NormalCoupon { get; set; }

                /// <summary>
                /// 获取或设置折扣券使用规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fixed_discount_coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("fixed_discount_coupon")]
                public Types.DiscountCoupon? DiscountCoupon { get; set; }
            }

            public class CutToMessage : QueryMarketingFavorStocksResponse.Types.Stock.Types.CutToMessage
            {
            }

            public class AvailableRegion : QueryMarketingFavorStocksResponse.Types.Stock.Types.AvailableRegion
            {
            }
        }

        /// <summary>
        /// 获取或设置批次 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string? StockId { get; set; }

        /// <summary>
        /// 获取或设置批次名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_name")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_name")]
        public string? StockName { get; set; }

        /// <summary>
        /// 获取或设置批次类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_type")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_type")]
        public string? StockType { get; set; }

        /// <summary>
        /// 获取或设置创建批次的商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_creator_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_creator_mchid")]
        public string? StockCreatorMerchantId { get; set; }

        /// <summary>
        /// 获取或设置批次状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 获取或设置使用说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置可用开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_begin_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("available_begin_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset AvailableBeginTime { get; set; }

        /// <summary>
        /// 获取或设置可用结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("available_end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset AvailableEndTime { get; set; }

        /// <summary>
        /// 获取或设置发放规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_use_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_use_rule")]
        public Types.StockUseRule? StockUseRule { get; set; }

        /// <summary>
        /// 获取或设置已发券数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distributed_coupons")]
        [System.Text.Json.Serialization.JsonPropertyName("distributed_coupons")]
        public int DistributedCoupons { get; set; }

        /// <summary>
        /// 获取或设置消费卡 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string? CardId { get; set; }

        /// <summary>
        /// 获取或设置是否无资金流。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("no_cash")]
        [System.Text.Json.Serialization.JsonPropertyName("no_cash")]
        public bool IsNoCash { get; set; }

        /// <summary>
        /// 获取或设置是否单品优惠。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("singleitem")]
        [System.Text.Json.Serialization.JsonPropertyName("singleitem")]
        public bool IsSingleItem { get; set; }

        /// <summary>
        /// 获取或设置单品优惠特定信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cut_to_message")]
        [System.Text.Json.Serialization.JsonPropertyName("cut_to_message")]
        public Types.CutToMessage? CutToMessage { get; set; }

        /// <summary>
        /// 获取或设置激活时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// 获取或设置终止时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stop_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("stop_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? StopTime { get; set; }

        /// <summary>
        /// 获取或设置业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("business_type")]
        public string? BusinessType { get; set; }

        /// <summary>
        /// 获取或设置消费金可用地域列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_region_list")]
        [System.Text.Json.Serialization.JsonPropertyName("available_region_list")]
        public List<Types.AvailableRegion>? AvailableRegionList { get; set; }

        /// <summary>
        /// 获取或设置消费金可用行业列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_industry_list")]
        [System.Text.Json.Serialization.JsonPropertyName("available_industry_list")]
        public List<string>? AvailableIndustryList { get; set; }

        /// <summary>
        /// 获取或设置创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }
    }
}
