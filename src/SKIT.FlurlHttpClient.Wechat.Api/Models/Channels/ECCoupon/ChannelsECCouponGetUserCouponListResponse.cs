namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/coupon/get_user_coupon_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECCouponGetUserCouponListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class UserCoupon
            {
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
            }
        }

        /// <summary>
        /// 获取或设置用户优惠券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_coupon_list")]
        [System.Text.Json.Serialization.JsonPropertyName("user_coupon_list")]
        public Types.UserCoupon[] UserCouponList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_ctx")]
        [System.Text.Json.Serialization.JsonPropertyName("page_ctx")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
