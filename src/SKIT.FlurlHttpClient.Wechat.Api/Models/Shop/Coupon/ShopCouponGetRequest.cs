using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/coupon/get 接口的请求。</para>
    /// </summary>
    public class ShopCouponGetRequest : WechatApiRequest, IMapResponse<ShopCouponGetRequest, ShopCouponGetResponse>
    {
        /// <summary>
        /// 获取或设置商家侧优惠券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_coupon_id")]
        public string OutCouponId { get; set; } = string.Empty;
    }
}
