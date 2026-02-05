namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_coupon_detail 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetCouponDetailResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Coupon : ChannelsECCouponGetResponse.Types.Coupon
            {
                /// <summary>
                /// 获取或设置是否可膨胀。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_can_up")]
                [System.Text.Json.Serialization.JsonPropertyName("is_can_up")]
                public bool IsCanUp { get; set; }

                /// <summary>
                /// 获取或设置膨胀最大倍数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("can_up_times")]
                [System.Text.Json.Serialization.JsonPropertyName("can_up_times")]
                public int CanUpTimes { get; set; }

                /// <summary>
                /// 获取或设置最大优惠金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_limit")]
                public int? DiscountLimit { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon")]
        public Types.Coupon Coupon { get; set; } = default!;
    }
}
