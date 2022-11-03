namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/coupon/update_status 接口的请求。</para>
    /// </summary>
    public class ProductCouponUpdateStatusRequest : WechatApiRequest, IInferable<ProductCouponUpdateStatusRequest, ProductCouponUpdateStatusResponse>
    {
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
        public int Status { get; set; }
    }
}
