namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/coupon/get_user_coupon 接口的响应。</para>
    /// </summary>
    public class ChannelsECCouponGetUserCouponResponse : WechatApiResponse
    {
        public static class Types
        {
            public class UserCoupon
            {
                public static class Types
                {
                    public class Extra
                    {
                        /// <summary>
                        /// 获取或设置核销时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("use_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("use_time")]
                        public long UseTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置用户优惠券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("user_coupon_id")]
                public string UserCouponId { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long CouponId { get; set; }

                /// <summary>
                /// 获取或设置优惠券状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置有效期开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long ValidityStartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置有效期结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long ValidityEndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置扩展信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ext_info")]
                [System.Text.Json.Serialization.JsonPropertyName("ext_info")]
                public Types.Extra? Extra { get; set; }

                /// <summary>
                /// 获取或设置使用的订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string? OrderId { get; set; }

                /// <summary>
                /// 获取或设置优惠金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_fee")]
                public int? DiscountFee { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户 UnionId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string? UnionId { get; set; }

        /// <summary>
        /// 获取或设置用户优惠券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_coupon")]
        [System.Text.Json.Serialization.JsonPropertyName("user_coupon")]
        public Types.UserCoupon UserCoupon { get; set; } = default!;
    }
}
