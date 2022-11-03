namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/coupon/push 接口的请求。</para>
    /// </summary>
    public class ProductCouponPushRequest : WechatApiRequest, IInferable<ProductCouponPushRequest, ProductCouponPushResponse>
    {
        /// <summary>
        /// 获取或设置优惠券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
        public long CouponId { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;
    }
}
