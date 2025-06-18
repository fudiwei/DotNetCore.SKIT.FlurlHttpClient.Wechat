namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/coupon/get_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECCouponGetListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Coupon
            {
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
        /// 获取或设置优惠券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupons")]
        [System.Text.Json.Serialization.JsonPropertyName("coupons")]
        public Types.Coupon[] CouponList { get; set; } = default!;

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
