using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/favor/stocks/{stock_id} 接口的响应。</para>
    /// </summary>
    public class GetMarketingFavorStockByStockIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class StockUseRule
            {
                public static class Types
                {
                    public class NormalCoupon
                    {
                        /// <summary>
                        /// 获取或设置券面额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_amount")]
                        public int CouponAmount { get; set; }

                        /// <summary>
                        /// 获取或设置使用门槛（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_minimum")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_minimum")]
                        public int TransactionMinimum { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置发放总上限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_coupons")]
                [System.Text.Json.Serialization.JsonPropertyName("max_coupons")]
                public int MaxCoupons { get; set; }

                /// <summary>
                /// 获取或设置发放总预算（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("max_amount")]
                public long MaxAmount { get; set; }

                /// <summary>
                /// 获取或设置单天预算发放上限（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_amount_by_day")]
                [System.Text.Json.Serialization.JsonPropertyName("max_amount_by_day")]
                public long MaxAmountPerDay { get; set; }

                /// <summary>
                /// 获取或设置单个用户可领个数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_coupons_per_user")]
                [System.Text.Json.Serialization.JsonPropertyName("max_coupons_per_user")]
                public int MaxCouponsPerUser { get; set; }

                /// <summary>
                /// 获取或设置固定面额批次特定信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fixed_normal_coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("fixed_normal_coupon")]
                public Types.NormalCoupon? NormalCoupon { get; set; }

                /// <summary>
                /// 获取或设置券类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_type")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_type")]
                public string? CouponType { get; set; }

                /// <summary>
                /// 获取或设置订单优惠标记。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_tag")]
                public string[]? GoodsTagList { get; set; }

                /// <summary>
                /// 获取或设置指定支付方式列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_type")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_type")]
                public string[]? TradeTypeList { get; set; }

                /// <summary>
                /// 获取或设置是否可叠加其他优惠。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("combine_use")]
                [System.Text.Json.Serialization.JsonPropertyName("combine_use")]
                public bool? AllowCombineUse { get; set; }
            }

            public class CutToMessage
            {
                /// <summary>
                /// 获取或设置可用优惠的商品最高单价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("single_price_max")]
                [System.Text.Json.Serialization.JsonPropertyName("single_price_max")]
                public int SinglePriceMax { get; set; }

                /// <summary>
                /// 获取或设置减至后的优惠单价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cut_to_price")]
                [System.Text.Json.Serialization.JsonPropertyName("cut_to_price")]
                public int CutToPrice { get; set; }
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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("available_begin_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset AvailableBeginTime { get; set; }

        /// <summary>
        /// 获取或设置可用结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("available_end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// 获取或设置终止时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stop_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("stop_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? StopTime { get; set; }

        /// <summary>
        /// 获取或设置创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }
    }
}
