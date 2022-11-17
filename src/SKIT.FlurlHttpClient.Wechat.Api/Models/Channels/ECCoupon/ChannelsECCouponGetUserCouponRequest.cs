using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/coupon/get_user_coupon 接口的请求。</para>
    /// </summary>
    public class ChannelsECCouponGetUserCouponRequest : WechatApiRequest, IInferable<ChannelsECCouponGetUserCouponRequest, ChannelsECCouponGetUserCouponResponse>
    {
        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户优惠券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_coupon_id")]
        public string CouponId { get; set; } = string.Empty;
    }
}
