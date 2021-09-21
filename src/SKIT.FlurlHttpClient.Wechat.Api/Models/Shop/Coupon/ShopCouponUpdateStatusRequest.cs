using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/coupon/update_status 接口的请求。</para>
    /// </summary>
    public class ShopCouponUpdateStatusRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置商家侧优惠券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_coupon_id")]
        public string OutCouponId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置优惠券状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
