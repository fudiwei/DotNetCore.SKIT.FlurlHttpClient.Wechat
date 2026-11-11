namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    using SKIT.FlurlHttpClient.Internal.CodeAnalysis;

    /// <summary>
    /// <para>表示 [POST] /marketing/partner/product-coupon/users/{openid}/coupon-bundles/{user_coupon_bundle_id}/deactivate 接口的响应。</para>
    /// </summary>
    public class DeactivateMarketingPartnerProductCouponUserCouponBundleResponse : WechatTenpayResponse
    {
        public static class Types
        {
            [DisallowAnalyzerRule("type-declaration/no-external-contract-nested-types", Addition = "SKIT.FlurlHttpClient.Wechat.TenpayV3.Models." + nameof(QueryMarketingPartnerProductCouponUserCouponsResponse) + "+" + nameof(QueryMarketingPartnerProductCouponUserCouponsResponse.Types) + "+" + nameof(QueryMarketingPartnerProductCouponUserCouponsResponse.Types.UserCoupon))]
            public class UserCoupon : QueryMarketingPartnerProductCouponUserCouponsResponse.Types.UserCoupon
            {
            }
        }

        /// <summary>
        /// 获取或设置用户券组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_coupon_bundle_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_coupon_bundle_id")]
        public string? UserCouponBundleId { get; set; }

        /// <summary>
        /// 获取或设置用户券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_product_coupon_list")]
        [System.Text.Json.Serialization.JsonPropertyName("user_product_coupon_list")]
        public List<Types.UserCoupon>? UserCouponList { get; set; }
    }
}
