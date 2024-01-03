using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 COUPON.USE 通知的数据。</para>
    /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/cash-coupons/check-notice.html </para>
    /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/cash-coupons/check-notice.html </para>
    /// </summary>
    public class MarketingFavorCouponResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        public static class Types
        {
            public class SingleItemDiscountOff
            {
                /// <summary>
                /// 获取或设置单品最高优惠价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("single_price_max")]
                [System.Text.Json.Serialization.JsonPropertyName("single_price_max")]
                public int? SinglePriceMax { get; set; }
            }

            public class DiscountTo
            {
                /// <summary>
                /// 获取或设置减至后优惠单价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cut_to_price")]
                [System.Text.Json.Serialization.JsonPropertyName("cut_to_price")]
                public int? CutToPrice { get; set; }

                /// <summary>
                /// 获取或设置最高价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_price")]
                [System.Text.Json.Serialization.JsonPropertyName("max_price")]
                public int? MaxPrice { get; set; }
            }

            public class NormalCoupon : Models.QueryMarketingFavorUserCouponsResponse.Types.Coupon.Types.NormalCoupon
            {
            }

            public class Consumption : Models.QueryMarketingFavorUserCouponsResponse.Types.Coupon.Types.Consumption
            {
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
        [Newtonsoft.Json.JsonProperty("singleitem_discount_off")]
        [System.Text.Json.Serialization.JsonPropertyName("singleitem_discount_off")]
        public Types.SingleItemDiscountOff? SingleItemDiscountOff { get; set; }

        /// <summary>
        /// 获取或设置减至优惠特定信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("discount_to")]
        [System.Text.Json.Serialization.JsonPropertyName("discount_to")]
        public Types.DiscountTo? DiscountTo { get; set; }

        /// <summary>
        /// 获取或设置普通满减券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("normal_coupon_information")]
        [System.Text.Json.Serialization.JsonPropertyName("normal_coupon_information")]
        public Types.NormalCoupon? NormalCoupon { get; set; }

        /// <summary>
        /// 获取或设置实扣代金券核销信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("consume_information")]
        [System.Text.Json.Serialization.JsonPropertyName("consume_information")]
        public Types.Consumption? Consumption { get; set; }

        /// <summary>
        /// 获取或设置领券时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }
    }
}
