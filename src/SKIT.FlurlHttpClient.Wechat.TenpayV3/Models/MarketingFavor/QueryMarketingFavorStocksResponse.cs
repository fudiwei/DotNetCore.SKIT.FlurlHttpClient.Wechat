using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/favor/stocks 接口的响应。</para>
    /// </summary>
    public class QueryMarketingFavorStocksResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Stock
            {
                public static class Types
                {
                    public class StockUseRule : GetMarketingFavorStockByStockIdResponse.Types.StockUseRule
                    {
                    }

                    public class CutToMessage : GetMarketingFavorStockByStockIdResponse.Types.CutToMessage
                    {
                    }
                }

                /// <summary>
                /// 获取或设置批次号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_id")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
                public string StockId { get; set; } = default!;

                /// <summary>
                /// 获取或设置批次名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_name")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_name")]
                public string StockName { get; set; } = default!;

                /// <summary>
                /// 获取或设置批次类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_type")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_type")]
                public string StockType { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建批次的商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_creator_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_creator_mchid")]
                public string StockCreatorMerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置批次状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置使用说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置可用开始时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available_begin_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("available_begin_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset AvailableBeginTime { get; set; }

                /// <summary>
                /// 获取或设置可用结束时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available_end_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("available_end_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset AvailableEndTime { get; set; }

                /// <summary>
                /// 获取或设置发放规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_use_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_use_rule")]
                public Types.StockUseRule StockUseRule { get; set; } = default!;

                /// <summary>
                /// 获取或设置已发券数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("distributed_coupons")]
                [System.Text.Json.Serialization.JsonPropertyName("distributed_coupons")]
                public int DistributedCoupons { get; set; }

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
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                public DateTimeOffset? StartTime { get; set; }

                /// <summary>
                /// 获取或设置终止时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stop_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("stop_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                public DateTimeOffset? StopTime { get; set; }

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置批次列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Stock[] StockList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置批次总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
