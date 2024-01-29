using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/favor/users/{openid}/coupons/{coupon_id} 接口的响应。</para>
    /// </summary>
    public class GetMarketingFavorUserCouponByCouponIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
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
        /// 获取或设置领券时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }
    }
}
