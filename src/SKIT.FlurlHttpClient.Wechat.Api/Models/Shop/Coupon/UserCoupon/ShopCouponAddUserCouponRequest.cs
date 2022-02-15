using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/coupon/add_user_coupon 接口的请求。</para>
    /// </summary>
    public class ShopCouponAddUserCouponRequest : WechatApiRequest, IMapResponse<ShopCouponAddUserCouponRequest, ShopCouponAddUserCouponResponse>
    {
        public static class Types
        {
            public class UserCoupon
            {
                /// <summary>
                /// 获取或设置商家侧用户优惠券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_user_coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_user_coupon_id")]
                public string OutUserCouponId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商家侧优惠券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_coupon_id")]
                public string OutCouponId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置用户优惠券状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置优惠券库存信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_coupon")]
        [System.Text.Json.Serialization.JsonPropertyName("user_coupon")]
        public Types.UserCoupon UserCoupon { get; set; } = new Types.UserCoupon();

        /// <summary>
        /// 获取或设置领取时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recv_time")]
        [System.Text.Json.Serialization.JsonPropertyName("recv_time")]
        public long ReceiveTimestamp { get; set; }
    }
}
