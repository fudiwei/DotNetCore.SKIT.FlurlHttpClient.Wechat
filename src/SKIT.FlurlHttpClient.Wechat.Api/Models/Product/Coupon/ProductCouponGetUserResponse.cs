using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/coupon/get_user 接口的响应。</para>
    /// </summary>
    public class ProductCouponGetUserResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Coupon
            {
                public static class Types
                {
                    public class Extra
                    {
                        /// <summary>
                        /// 获取或设置核销时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("use_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("use_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                        public DateTimeOffset? UseTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置优惠券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                public long CouponId { get; set; }

                /// <summary>
                /// 获取或设置优惠券状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置有效开始时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                public DateTimeOffset ValidityStartTime { get; set; }

                /// <summary>
                /// 获取或设置有效结束时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                public DateTimeOffset ValidityEndTime { get; set; }

                /// <summary>
                /// 获取或设置使用的订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public long? OrderId { get; set; }

                /// <summary>
                /// 获取或设置优惠金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_fee")]
                public int? DiscountFee { get; set; }

                /// <summary>
                /// 获取或设置扩展信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ext_info")]
                [System.Text.Json.Serialization.JsonPropertyName("ext_info")]
                public Types.Extra Extra { get; set; } = default!;

                /// <summary>
                /// 获取或设置更新时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                public DateTimeOffset UpdateTime { get; set; }

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户的优惠券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_coupon_list")]
        [System.Text.Json.Serialization.JsonPropertyName("user_coupon_list")]
        public Types.Coupon[] CouponList { get; set; } = default!;
    }
}
