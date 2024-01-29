using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/favor/users/{openid}/coupons 接口的响应。</para>
    /// </summary>
    public class QueryMarketingFavorUserCouponsResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Coupon
            {
                public static class Types
                {
                    public class CutToMessage : GetMarketingFavorUserCouponByCouponIdResponse.Types.CutToMessage
                    {
                    }

                    public class NormalCoupon : GetMarketingFavorUserCouponByCouponIdResponse.Types.NormalCoupon
                    {
                    }

                    public class Consumption
                    {
                        public static class Types
                        {
                            public class GoodsDetail
                            {
                                /// <summary>
                                /// 获取或设置商品编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("goods_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("goods_id")]
                                public string GoodsId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                                public int Quantity { get; set; }

                                /// <summary>
                                /// 获取或设置商品单价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("price")]
                                [System.Text.Json.Serialization.JsonPropertyName("price")]
                                public int UnitPrice { get; set; }

                                /// <summary>
                                /// 获取或设置商品优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
                                public int DiscountAmount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置核销时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("consume_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("consume_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                        public DateTimeOffset ConsumeTime { get; set; }

                        /// <summary>
                        /// 获取或设置核销商户号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("consume_mchid")]
                        [System.Text.Json.Serialization.JsonPropertyName("consume_mchid")]
                        public string ConsumeMerchantId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置微信支付单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                        public string TransactionId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置单品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_detail")]
                        public Types.GoodsDetail[]? GoodsList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置代金券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                public string CouponId { get; set; } = default!;

                /// <summary>
                /// 获取或设置批次号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_id")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
                public string StockId { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建批次的商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_creator_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_creator_mchid")]
                public string StockCreatorMerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置代金券名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_name")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_name")]
                public string CouponName { get; set; } = default!;

                /// <summary>
                /// 获取或设置券类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_type")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_type")]
                public string CouponType { get; set; } = default!;

                /// <summary>
                /// 获取或设置券状态。
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
                /// 获取或设置满减券信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("normal_coupon_information")]
                [System.Text.Json.Serialization.JsonPropertyName("normal_coupon_information")]
                public Types.NormalCoupon? NormalCoupon { get; set; }

                /// <summary>
                /// 获取或设置已实扣代金券核销信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("consume_information")]
                [System.Text.Json.Serialization.JsonPropertyName("consume_information")]
                public Types.Consumption? Consumption { get; set; }

                /// <summary>
                /// 获取或设置领券时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Coupon[] CouponList { get; set; } = default!;

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
        /// 获取或设置券总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
