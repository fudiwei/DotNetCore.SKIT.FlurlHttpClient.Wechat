using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/coupon/get 接口的请求。</para>
    /// </summary>
    public class ProductCouponGetRequest : WechatApiRequest, IMapResponse<ProductCouponGetRequest, ProductCouponGetResponse>
    {
        /// <summary>
        /// 获取或设置优惠券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
        public int CouponId { get; set; }
    }
}
