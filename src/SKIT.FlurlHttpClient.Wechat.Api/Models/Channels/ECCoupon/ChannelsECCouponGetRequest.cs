using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/coupon/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECCouponGetRequest : WechatApiRequest, IInferable<ChannelsECCouponGetRequest, ChannelsECCouponGetResponse>
    {
        /// <summary>
        /// 获取或设置优惠券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
        public long CouponId { get; set; }
    }
}
