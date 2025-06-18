namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/coupon/get_list 接口的响应。</para>
    /// </summary>
    public class ProductCouponGetListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Coupon : ProductCouponGetResponse.Types.Coupon
            {
            }
        }

        /// <summary>
        /// 获取或设置优惠券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupons")]
        [System.Text.Json.Serialization.JsonPropertyName("coupons")]
        public Types.Coupon[] CouponList { get; set; } = default!;
    }
}
