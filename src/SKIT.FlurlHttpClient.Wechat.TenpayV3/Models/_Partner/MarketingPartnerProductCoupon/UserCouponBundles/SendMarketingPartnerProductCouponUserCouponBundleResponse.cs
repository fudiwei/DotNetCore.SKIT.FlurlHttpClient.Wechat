namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partner/product-coupon/users/{openid}/coupon-bundles 接口的响应。</para>
    /// </summary>
    public class SendMarketingPartnerProductCouponUserCouponBundleResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class UserCoupon : QueryMarketingPartnerProductCouponUserCouponsResponse.Types.UserCoupon
            {
            }
        }

        /// <summary>
        /// 获取或设置用户券组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_coupon_bundle_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_coupon_bundle_id")]
        public string UserCouponBundleId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_product_coupon_list")]
        [System.Text.Json.Serialization.JsonPropertyName("user_product_coupon_list")]
        public Types.UserCoupon[] UserCouponList { get; set; } = default!;
    }
}
